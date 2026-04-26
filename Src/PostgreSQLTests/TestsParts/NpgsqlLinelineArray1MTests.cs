

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7998488845714652d, b: 0.03834938341779692d, c: 0.558943486735078d),
new NpgsqlTypes.NpgsqlLine(a: 0.809868719567188d, b: 0.22214037063167014d, c: 0.9477539433370739d),
new NpgsqlTypes.NpgsqlLine(a: 0.8270375722145198d, b: 0.07835481813056855d, c: 0.8794783749361879d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9742486227769847d, b: 0.7196076057250606d, c: 0.2483645259115641d),
new NpgsqlTypes.NpgsqlLine(a: 0.5648098876550659d, b: 0.22614261805530522d, c: 0.4720379740575009d),
new NpgsqlTypes.NpgsqlLine(a: 0.6587999989645352d, b: 0.47830926085780245d, c: 0.3320870010099697d),
new NpgsqlTypes.NpgsqlLine(a: 0.7854224339827867d, b: 0.23344390353145916d, c: 0.6188120492768094d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10520967538659265d, b: 0.05886180148775788d, c: 0.9955656658914591d),
new NpgsqlTypes.NpgsqlLine(a: 0.5812006136462186d, b: 0.23305196932864758d, c: 0.9117196653712302d),
new NpgsqlTypes.NpgsqlLine(a: 0.6713530394653208d, b: 0.41742170586557203d, c: 0.10229295997773402d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16806964158735893d, b: 0.06110813629682488d, c: 0.16337267681672563d),
new NpgsqlTypes.NpgsqlLine(a: 0.5641412031036126d, b: 0.7770648761585672d, c: 0.5959984178863459d),
new NpgsqlTypes.NpgsqlLine(a: 0.6527929138252169d, b: 0.7163018691131937d, c: 0.6878509534858216d),
new NpgsqlTypes.NpgsqlLine(a: 0.7997633808382216d, b: 0.1072487802407982d, c: 0.9151668717372996d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.597455532461518d, b: 0.3078435540244353d, c: 0.21447514943202328d),
new NpgsqlTypes.NpgsqlLine(a: 0.009086854416331613d, b: 0.9996935333079662d, c: 0.19137137901245105d),
new NpgsqlTypes.NpgsqlLine(a: 0.48403068440874486d, b: 0.40501789223142626d, c: 0.5270265782219347d),
new NpgsqlTypes.NpgsqlLine(a: 0.8992936908506778d, b: 0.016408881522829044d, c: 0.6514321986263647d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17821525814997707d, b: 0.5176016114949988d, c: 0.8001382523045161d),
new NpgsqlTypes.NpgsqlLine(a: 0.7988430877729252d, b: 0.9652205182831528d, c: 0.4078666708580658d),
new NpgsqlTypes.NpgsqlLine(a: 0.7431697395805497d, b: 0.8432371314980922d, c: 0.1742538598802773d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4286474674255233d, b: 0.35430772623760787d, c: 0.7717783650954329d),
new NpgsqlTypes.NpgsqlLine(a: 0.43403652956924677d, b: 0.5784031179767104d, c: 0.005562717814849405d),
new NpgsqlTypes.NpgsqlLine(a: 0.5034843402273772d, b: 0.9102077162958023d, c: 0.6087067913668307d),
new NpgsqlTypes.NpgsqlLine(a: 0.9080561534642723d, b: 0.7407573624635729d, c: 0.3532720069708938d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1189558831157731d, b: 0.5963476432673435d, c: 0.6311753036820623d),
new NpgsqlTypes.NpgsqlLine(a: 0.767187472151393d, b: 0.800394319398879d, c: 0.7704623487176798d),
new NpgsqlTypes.NpgsqlLine(a: 0.666787885256624d, b: 0.2073064035885288d, c: 0.3353851749090677d),
new NpgsqlTypes.NpgsqlLine(a: 0.06653205918501326d, b: 0.5059515701287438d, c: 0.7450077448178533d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6199774416687523d, b: 0.7738984199868459d, c: 0.20049397740284947d),
new NpgsqlTypes.NpgsqlLine(a: 0.5898560673738623d, b: 0.6484482206530212d, c: 0.15308176696917286d),
new NpgsqlTypes.NpgsqlLine(a: 0.5044757690214083d, b: 0.6090149992485786d, c: 0.3344517598107233d),
new NpgsqlTypes.NpgsqlLine(a: 0.38628287862838706d, b: 0.9167500047300801d, c: 0.5483208074531384d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19539397856384d, b: 0.7418578076212529d, c: 0.5903661594474318d),
new NpgsqlTypes.NpgsqlLine(a: 0.876864851369318d, b: 0.6248780964453573d, c: 0.13470873615583023d),
new NpgsqlTypes.NpgsqlLine(a: 0.5969453648340388d, b: 0.8931476300399427d, c: 0.170497761938032d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2739842252263378d, b: 0.6582480540052132d, c: 0.2727194713257267d),
new NpgsqlTypes.NpgsqlLine(a: 0.32734388447728924d, b: 0.2889617263506432d, c: 0.2845790435941964d),
new NpgsqlTypes.NpgsqlLine(a: 0.174403824349869d, b: 0.5920397520495658d, c: 0.405569072793152d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6651516382246345d, b: 0.10041421720383836d, c: 0.9244920271606085d),
new NpgsqlTypes.NpgsqlLine(a: 0.9576987669352744d, b: 0.5310328838792228d, c: 0.6236996521197538d),
new NpgsqlTypes.NpgsqlLine(a: 0.7898268555495088d, b: 0.8603007201383976d, c: 0.2749521802510506d),
new NpgsqlTypes.NpgsqlLine(a: 0.43890025797316556d, b: 0.3346311043996356d, c: 0.2570534023594675d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7493615695199534d, b: 0.08225061120711363d, c: 0.9316302791009545d),
new NpgsqlTypes.NpgsqlLine(a: 0.12076656963224286d, b: 0.7437492655470993d, c: 0.38470604173601974d),
new NpgsqlTypes.NpgsqlLine(a: 0.12705083243962478d, b: 0.8777164366503947d, c: 0.6843530471121538d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3399803567734968d, b: 0.7795104422097727d, c: 0.9714547917152433d),
new NpgsqlTypes.NpgsqlLine(a: 0.1109999341607174d, b: 0.5599303563229264d, c: 0.8281771841594371d),
new NpgsqlTypes.NpgsqlLine(a: 0.8036810878348469d, b: 0.5672732458477757d, c: 0.11159951362419418d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33104627906395634d, b: 0.3734649068284285d, c: 0.20369533893250846d),
new NpgsqlTypes.NpgsqlLine(a: 0.9064084076572925d, b: 0.21985959092498464d, c: 0.3630438872179381d),
new NpgsqlTypes.NpgsqlLine(a: 0.024979134998507235d, b: 0.2794929664565535d, c: 0.3075453658557026d),
new NpgsqlTypes.NpgsqlLine(a: 0.014591636116056073d, b: 0.9231939907367928d, c: 0.6394061135907636d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3038876398323449d, b: 0.9954149048116021d, c: 0.9562050218401522d),
new NpgsqlTypes.NpgsqlLine(a: 0.7540333758146025d, b: 0.3547561216211418d, c: 0.06781406622895858d),
new NpgsqlTypes.NpgsqlLine(a: 0.5011849047184773d, b: 0.33898041148985336d, c: 0.9228933284455882d),
new NpgsqlTypes.NpgsqlLine(a: 0.978500206172258d, b: 0.8228680403350652d, c: 0.05229097168476571d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49682420653457826d, b: 0.5307417949842088d, c: 0.7572373242711437d),
new NpgsqlTypes.NpgsqlLine(a: 0.3512443325818646d, b: 0.03115034526197269d, c: 0.41587447935651445d),
new NpgsqlTypes.NpgsqlLine(a: 0.3855042077739399d, b: 0.3232979183608192d, c: 0.9714348632494503d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.41761940776369233d, b: 0.49326500061787615d, c: 0.29545697487886835d),
new NpgsqlTypes.NpgsqlLine(a: 0.5441887463323704d, b: 0.046830042725153675d, c: 0.7141523699706729d),
new NpgsqlTypes.NpgsqlLine(a: 0.0007778417995844d, b: 0.36092198489739646d, c: 0.08613188551077222d),
new NpgsqlTypes.NpgsqlLine(a: 0.7077653910127617d, b: 0.2647928655435706d, c: 0.7798925309811071d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17191728044955124d, b: 0.31968989101868706d, c: 0.5118909087165725d),
new NpgsqlTypes.NpgsqlLine(a: 0.09676977361083228d, b: 0.11776547049188524d, c: 0.4406947869434198d),
new NpgsqlTypes.NpgsqlLine(a: 0.7708872490750356d, b: 0.7370834939537203d, c: 0.6066893449145383d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8518471189915487d, b: 0.2633134044861256d, c: 0.9809745340489169d),
new NpgsqlTypes.NpgsqlLine(a: 0.09648758400041424d, b: 0.6570970581603258d, c: 0.1931261668222657d),
new NpgsqlTypes.NpgsqlLine(a: 0.5095902115238201d, b: 0.24525960209193975d, c: 0.46559763394943554d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6059961030372074d, b: 0.7804493977931866d, c: 0.8332970032300244d),
new NpgsqlTypes.NpgsqlLine(a: 0.7606492195841723d, b: 0.47625052119733335d, c: 0.4077886833891958d),
new NpgsqlTypes.NpgsqlLine(a: 0.15737580219154346d, b: 0.7147183211610445d, c: 0.20286141222998477d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.796292045371104d, b: 0.8307929139860659d, c: 0.7624276348838355d),
new NpgsqlTypes.NpgsqlLine(a: 0.6580986460699102d, b: 0.7962450970303526d, c: 0.7327764039609499d),
new NpgsqlTypes.NpgsqlLine(a: 0.5630126937827353d, b: 0.6134890132565457d, c: 0.42545666486144695d),
new NpgsqlTypes.NpgsqlLine(a: 0.7383107147471062d, b: 0.20693185202316644d, c: 0.306146233020673d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0882730970265847d, b: 0.35433156887851713d, c: 0.2427964174509486d),
new NpgsqlTypes.NpgsqlLine(a: 0.4085836369780884d, b: 0.5641289582087178d, c: 0.8337734632453636d),
new NpgsqlTypes.NpgsqlLine(a: 0.07020791211847699d, b: 0.6337095321600972d, c: 0.8928581408825212d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9464486730981075d, b: 0.23413423658269128d, c: 0.5966555968483578d),
new NpgsqlTypes.NpgsqlLine(a: 0.10347176754532061d, b: 0.6586336438533879d, c: 0.14357573968131798d),
new NpgsqlTypes.NpgsqlLine(a: 0.8943495639855292d, b: 0.10506601942843896d, c: 0.4426350516769939d),
new NpgsqlTypes.NpgsqlLine(a: 0.49162794215490624d, b: 0.6064778055101061d, c: 0.10355787154237484d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8749600370038612d, b: 0.5781543513749542d, c: 0.35848190366221866d),
new NpgsqlTypes.NpgsqlLine(a: 0.15550963437927579d, b: 0.9303547661198746d, c: 0.8719387348510383d),
new NpgsqlTypes.NpgsqlLine(a: 0.10221837445487458d, b: 0.19560951353218192d, c: 0.6952020694224834d),
new NpgsqlTypes.NpgsqlLine(a: 0.9698770282532005d, b: 0.48386874897355703d, c: 0.15834021549481736d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5169678927555696d, b: 0.1414604595687029d, c: 0.4929257882026019d),
new NpgsqlTypes.NpgsqlLine(a: 0.8121074172580084d, b: 0.7788728483598919d, c: 0.6144598997372875d),
new NpgsqlTypes.NpgsqlLine(a: 0.7686607868251196d, b: 0.4572530931458715d, c: 0.1810410756805063d),
new NpgsqlTypes.NpgsqlLine(a: 0.35624756841074035d, b: 0.637888784820498d, c: 0.6921869028234445d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40073455341430186d, b: 0.6136927998095665d, c: 0.45442120837970623d),
new NpgsqlTypes.NpgsqlLine(a: 0.2577805944688488d, b: 0.05235835683892853d, c: 0.7762529514940908d),
new NpgsqlTypes.NpgsqlLine(a: 0.16975718139020357d, b: 0.7739184845079191d, c: 0.8358951760914952d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8082872590861374d, b: 0.3659001303843652d, c: 0.18424423634549114d),
new NpgsqlTypes.NpgsqlLine(a: 0.17553861199486664d, b: 0.8034462975965385d, c: 0.10048824939775802d),
new NpgsqlTypes.NpgsqlLine(a: 0.5378891441293093d, b: 0.6865668715163639d, c: 0.12023370277438927d),
new NpgsqlTypes.NpgsqlLine(a: 0.8758658151736739d, b: 0.1369419331069771d, c: 0.09853122678882065d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2775766354241148d, b: 0.032490401570087535d, c: 0.663751582496036d),
new NpgsqlTypes.NpgsqlLine(a: 0.8534495336130934d, b: 0.627724334735807d, c: 0.5252085117945784d),
new NpgsqlTypes.NpgsqlLine(a: 0.27161734914444924d, b: 0.3818878779939958d, c: 0.16641073356264957d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8206352846961625d, b: 0.6540348447028284d, c: 0.6349511928394098d),
new NpgsqlTypes.NpgsqlLine(a: 0.04503286775119619d, b: 0.4865611416846992d, c: 0.31460375146729924d),
new NpgsqlTypes.NpgsqlLine(a: 0.8289527664798614d, b: 0.11891789483201676d, c: 0.8782087520775267d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01585122298072561d, b: 0.26860638545695925d, c: 0.390555016931571d),
new NpgsqlTypes.NpgsqlLine(a: 0.20713003892165727d, b: 0.007244451265043694d, c: 0.5043017620109677d),
new NpgsqlTypes.NpgsqlLine(a: 0.9033925875479996d, b: 0.2995453612581105d, c: 0.35908783452735304d),
new NpgsqlTypes.NpgsqlLine(a: 0.7517385646840636d, b: 0.2022022393589198d, c: 0.8007897337459357d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4348273167286093d, b: 0.7286674336174084d, c: 0.037087063833336265d),
new NpgsqlTypes.NpgsqlLine(a: 0.8828255602927723d, b: 0.7716245594007692d, c: 0.28567648321617245d),
new NpgsqlTypes.NpgsqlLine(a: 0.22578324269982375d, b: 0.7266803963368121d, c: 0.9495050005473772d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1015863618503926d, b: 0.7808668811809182d, c: 0.6850093459225538d),
new NpgsqlTypes.NpgsqlLine(a: 0.12013492427832206d, b: 0.44380623624618853d, c: 0.6220512374795433d),
new NpgsqlTypes.NpgsqlLine(a: 0.5125567219890547d, b: 0.4383317200342307d, c: 0.2921515284300741d),
new NpgsqlTypes.NpgsqlLine(a: 0.05370916626743949d, b: 0.8577774466900436d, c: 0.5597005426266595d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6230228536765312d, b: 0.03363129801032805d, c: 0.8834527088476418d),
new NpgsqlTypes.NpgsqlLine(a: 0.24045196071626473d, b: 0.3042291186205093d, c: 0.23687230337436926d),
new NpgsqlTypes.NpgsqlLine(a: 0.2718846192467449d, b: 0.678875011761966d, c: 0.10573389131243316d),
new NpgsqlTypes.NpgsqlLine(a: 0.15568475974103912d, b: 0.789569213326416d, c: 0.002736781504448338d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01485189762589656d, b: 0.7393620863164936d, c: 0.3394136362487742d),
new NpgsqlTypes.NpgsqlLine(a: 0.5539416288259762d, b: 0.3978066856139326d, c: 0.47189095055274677d),
new NpgsqlTypes.NpgsqlLine(a: 0.28671688205806145d, b: 0.4996854131752303d, c: 0.99107515220118d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48708775021117723d, b: 0.7758868010367079d, c: 0.64977444501139d),
new NpgsqlTypes.NpgsqlLine(a: 0.1419533619938963d, b: 0.8966912235386345d, c: 0.33401314847013d),
new NpgsqlTypes.NpgsqlLine(a: 0.7799294040191781d, b: 0.5989892688187184d, c: 0.2481920109038498d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8024304687331646d, b: 0.5961210271478888d, c: 0.8137273274803813d),
new NpgsqlTypes.NpgsqlLine(a: 0.6431146966392888d, b: 0.5514500568574442d, c: 0.5781328294929017d),
new NpgsqlTypes.NpgsqlLine(a: 0.9009681310011695d, b: 0.14656408529645615d, c: 0.4071788787432252d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5812642396013218d, b: 0.8390214466010809d, c: 0.5460465459043147d),
new NpgsqlTypes.NpgsqlLine(a: 0.5054340893775657d, b: 0.31361574679854465d, c: 0.8240834898088963d),
new NpgsqlTypes.NpgsqlLine(a: 0.7209652159558733d, b: 0.3047437040877876d, c: 0.25109888253910506d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12051140879025679d, b: 0.13243742698274674d, c: 0.7935357438682299d),
new NpgsqlTypes.NpgsqlLine(a: 0.9727480259849156d, b: 0.1304057481158869d, c: 0.2021685822945236d),
new NpgsqlTypes.NpgsqlLine(a: 0.1423003554577763d, b: 0.7429094961809064d, c: 0.3421769938307434d),
new NpgsqlTypes.NpgsqlLine(a: 0.5507147961235864d, b: 0.164567902905563d, c: 0.8993264710220603d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18464363519466587d, b: 0.2567604067775714d, c: 0.4450136265641659d),
new NpgsqlTypes.NpgsqlLine(a: 0.5933258969131282d, b: 0.5582244774810805d, c: 0.23267264103693175d),
new NpgsqlTypes.NpgsqlLine(a: 0.7528620430346232d, b: 0.7631971941333743d, c: 0.2742516271555079d),
new NpgsqlTypes.NpgsqlLine(a: 0.2979848092651902d, b: 0.1700566585984592d, c: 0.33021567774910976d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4363879746634268d, b: 0.3438085340733311d, c: 0.8700858510324807d),
new NpgsqlTypes.NpgsqlLine(a: 0.11316907547042299d, b: 0.9560731167236796d, c: 0.53119955526341d),
new NpgsqlTypes.NpgsqlLine(a: 0.1664063544877874d, b: 0.4962277470652309d, c: 0.8784012171416387d),
new NpgsqlTypes.NpgsqlLine(a: 0.4634887476582784d, b: 0.39654999818893366d, c: 0.47724435443422986d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2696107893372618d, b: 0.13649040623870612d, c: 0.4441415260069502d),
new NpgsqlTypes.NpgsqlLine(a: 0.9955942684801062d, b: 0.7827408367885701d, c: 0.3065070012337755d),
new NpgsqlTypes.NpgsqlLine(a: 0.36710359861319886d, b: 0.4944796350583338d, c: 0.32890589129046d),
new NpgsqlTypes.NpgsqlLine(a: 0.8952752822673481d, b: 0.1916598895727042d, c: 0.9022406452043348d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21602575008512004d, b: 0.23313472573739313d, c: 0.5889134338744108d),
new NpgsqlTypes.NpgsqlLine(a: 0.2905208325235479d, b: 0.25092094367379636d, c: 0.01273058932416149d),
new NpgsqlTypes.NpgsqlLine(a: 0.8520340770320328d, b: 0.6696363865525389d, c: 0.00806865342933727d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28983820936170945d, b: 0.4774698881168421d, c: 0.8374638722944535d),
new NpgsqlTypes.NpgsqlLine(a: 0.30724474627380927d, b: 0.7565486115984213d, c: 0.5565495382299015d),
new NpgsqlTypes.NpgsqlLine(a: 0.7201926579079847d, b: 0.6127636067475014d, c: 0.754598778319272d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7220480280961703d, b: 0.2883512789483985d, c: 0.7936761489522841d),
new NpgsqlTypes.NpgsqlLine(a: 0.43613231992961554d, b: 0.7009886483585218d, c: 0.9752887622983006d),
new NpgsqlTypes.NpgsqlLine(a: 0.11078881469799617d, b: 0.270278427287421d, c: 0.475346448991781d),
new NpgsqlTypes.NpgsqlLine(a: 0.839392475584049d, b: 0.8923619795669752d, c: 0.41819034114355946d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5905526500439872d, b: 0.2955558906973821d, c: 0.5077388637869525d),
new NpgsqlTypes.NpgsqlLine(a: 0.1460584959349589d, b: 0.7971658740742907d, c: 0.841679695270541d),
new NpgsqlTypes.NpgsqlLine(a: 0.05174432973291376d, b: 0.21092021993562848d, c: 0.7491255420615469d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8158201616997791d, b: 0.6259971776185858d, c: 0.9375321331302262d),
new NpgsqlTypes.NpgsqlLine(a: 0.8002346315800799d, b: 0.21577482516190216d, c: 0.3661464956578825d),
new NpgsqlTypes.NpgsqlLine(a: 0.596885353854989d, b: 0.7564853097148094d, c: 0.9099024074514902d),
new NpgsqlTypes.NpgsqlLine(a: 0.21437456476024908d, b: 0.8486693917884129d, c: 0.5694089959605095d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5297411868828472d, b: 0.042154322258826094d, c: 0.3077228585824755d),
new NpgsqlTypes.NpgsqlLine(a: 0.8059215400417679d, b: 0.1642602287959536d, c: 0.3571947646593945d),
new NpgsqlTypes.NpgsqlLine(a: 0.8693502565033637d, b: 0.8104769342063932d, c: 0.5560908574747743d),
new NpgsqlTypes.NpgsqlLine(a: 0.09945513500462277d, b: 0.7837791438313154d, c: 0.3633170834295969d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2586099461964225d, b: 0.5612186599411181d, c: 0.2366999006792967d),
new NpgsqlTypes.NpgsqlLine(a: 0.6901362879989942d, b: 0.40643683109791184d, c: 0.8294868425486096d),
new NpgsqlTypes.NpgsqlLine(a: 0.9820611720912995d, b: 0.9272639996590003d, c: 0.8637532124338096d),
new NpgsqlTypes.NpgsqlLine(a: 0.4088580600571974d, b: 0.43918675758431724d, c: 0.02304897793166627d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16346767153327357d, b: 0.5918881135344021d, c: 0.3676101024812066d),
new NpgsqlTypes.NpgsqlLine(a: 0.37103656594929d, b: 0.8945212751420971d, c: 0.6457329603806263d),
new NpgsqlTypes.NpgsqlLine(a: 0.8457435783420001d, b: 0.9729691410183883d, c: 0.682207180937145d),
new NpgsqlTypes.NpgsqlLine(a: 0.7000759314724024d, b: 0.2571985486621876d, c: 0.12428499354376854d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47553958880522285d, b: 0.8979853120015145d, c: 0.41986194727825976d),
new NpgsqlTypes.NpgsqlLine(a: 0.024855127203205707d, b: 0.3515326366355823d, c: 0.2822527915776427d),
new NpgsqlTypes.NpgsqlLine(a: 0.27294880098081387d, b: 0.138201012309629d, c: 0.20102309573473143d),
new NpgsqlTypes.NpgsqlLine(a: 0.2051011333349747d, b: 0.0004860182530084245d, c: 0.3097789336079021d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7507798935463552d, b: 0.4786448506666998d, c: 0.5918667549858677d),
new NpgsqlTypes.NpgsqlLine(a: 0.4376266948797216d, b: 0.7203873545031104d, c: 0.05614654658517715d),
new NpgsqlTypes.NpgsqlLine(a: 0.4489370461202892d, b: 0.5596443989838978d, c: 0.4317234527557786d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1736035918276716d, b: 0.29021993860782114d, c: 0.31416406645502915d),
new NpgsqlTypes.NpgsqlLine(a: 0.044294353657602814d, b: 0.7878621528896327d, c: 0.0403058516959256d),
new NpgsqlTypes.NpgsqlLine(a: 0.01646879851685279d, b: 0.8391154845293973d, c: 0.7686006400440375d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8787425568313675d, b: 0.7135619309991892d, c: 0.4038588707232138d),
new NpgsqlTypes.NpgsqlLine(a: 0.8550000138467565d, b: 0.689199661671901d, c: 0.9452165755697405d),
new NpgsqlTypes.NpgsqlLine(a: 0.3294100315921389d, b: 0.89936640975114d, c: 0.9626125226053283d),
new NpgsqlTypes.NpgsqlLine(a: 0.2856980654330359d, b: 0.864651440316691d, c: 0.42619832824623216d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7283025449505529d, b: 0.894097619337906d, c: 0.7017250146119329d),
new NpgsqlTypes.NpgsqlLine(a: 0.9848359421772563d, b: 0.00039452228074443596d, c: 0.16536906540121787d),
new NpgsqlTypes.NpgsqlLine(a: 0.8488934017146711d, b: 0.8151126288358018d, c: 0.7591611738536113d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6953569426697672d, b: 0.2001318163984226d, c: 0.6530046952683399d),
new NpgsqlTypes.NpgsqlLine(a: 0.06307322030557738d, b: 0.37204741273857844d, c: 0.14700962529812245d),
new NpgsqlTypes.NpgsqlLine(a: 0.6914270471161408d, b: 0.07693230346901425d, c: 0.6954741821083433d),
new NpgsqlTypes.NpgsqlLine(a: 0.5579903970285348d, b: 0.602583612758718d, c: 0.20983322350258626d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9842040347181211d, b: 0.07815432553125834d, c: 0.12624803803550777d),
new NpgsqlTypes.NpgsqlLine(a: 0.9695865377225988d, b: 0.471427678857689d, c: 0.40502240999639894d),
new NpgsqlTypes.NpgsqlLine(a: 0.9290759544469314d, b: 0.18386057969404646d, c: 0.9823207830267285d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8375199562662118d, b: 0.5988936404961729d, c: 0.05379655922984017d),
new NpgsqlTypes.NpgsqlLine(a: 0.06051860556675692d, b: 0.8302074482359486d, c: 0.5151911985274726d),
new NpgsqlTypes.NpgsqlLine(a: 0.4383423661549213d, b: 0.43050896379552284d, c: 0.1915634613572339d),
new NpgsqlTypes.NpgsqlLine(a: 0.2513085608180867d, b: 0.24710524590689953d, c: 0.6151931103912264d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19906635384499438d, b: 0.4032082653302743d, c: 0.7547822092128164d),
new NpgsqlTypes.NpgsqlLine(a: 0.4574699281848944d, b: 0.8725917325346737d, c: 0.24924144793321235d),
new NpgsqlTypes.NpgsqlLine(a: 0.14176267832685452d, b: 0.1808816175572221d, c: 0.7296685672499318d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5025388973766186d, b: 0.013760173752773164d, c: 0.40487085434960846d),
new NpgsqlTypes.NpgsqlLine(a: 0.41753161091131574d, b: 0.7747339171055722d, c: 0.956103318065663d),
new NpgsqlTypes.NpgsqlLine(a: 0.5979984185788078d, b: 0.9157996738999483d, c: 0.42718853834639237d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6593578116192828d, b: 0.9117894217583544d, c: 0.04251086546782479d),
new NpgsqlTypes.NpgsqlLine(a: 0.282819841714704d, b: 0.9089874035355674d, c: 0.9773458460740706d),
new NpgsqlTypes.NpgsqlLine(a: 0.7812633567449186d, b: 0.5405268559201553d, c: 0.6267427453192651d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7396848982919774d, b: 0.5912565220629029d, c: 0.8145712005298011d),
new NpgsqlTypes.NpgsqlLine(a: 0.2964069484747711d, b: 0.09330196069787522d, c: 0.4705674835112227d),
new NpgsqlTypes.NpgsqlLine(a: 0.08549487525742239d, b: 0.6943977977611776d, c: 0.4966022714592384d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5007029555317363d, b: 0.0615167322051432d, c: 0.06455264689662366d),
new NpgsqlTypes.NpgsqlLine(a: 0.17494500895600928d, b: 0.792597247798323d, c: 0.4347123073383552d),
new NpgsqlTypes.NpgsqlLine(a: 0.1802963544974645d, b: 0.9073453272694231d, c: 0.12843935629243952d),
new NpgsqlTypes.NpgsqlLine(a: 0.25374713366749335d, b: 0.6881744523925245d, c: 0.012771770637174495d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9368307271669202d, b: 0.12114850160769763d, c: 0.023899308600411673d),
new NpgsqlTypes.NpgsqlLine(a: 0.1668250496774346d, b: 0.20255791165369252d, c: 0.4059505853278359d),
new NpgsqlTypes.NpgsqlLine(a: 0.783011453884912d, b: 0.8291537537132986d, c: 0.2889889285903412d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8505864862998137d, b: 0.40711076170808347d, c: 0.7705350707630594d),
new NpgsqlTypes.NpgsqlLine(a: 0.6012321589350468d, b: 0.9011583614478776d, c: 0.4568929562059745d),
new NpgsqlTypes.NpgsqlLine(a: 0.6366673635660789d, b: 0.5966794690031004d, c: 0.4279179279268249d),
new NpgsqlTypes.NpgsqlLine(a: 0.631298597605341d, b: 0.7494993891934338d, c: 0.18997985268351558d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4861421524681875d, b: 0.9512237780707522d, c: 0.7910389801585348d),
new NpgsqlTypes.NpgsqlLine(a: 0.8701815174934905d, b: 0.870757277415787d, c: 0.8764683019761247d),
new NpgsqlTypes.NpgsqlLine(a: 0.5152491822112713d, b: 0.03482574479777012d, c: 0.3567462381620309d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2739842252263378d, b: 0.6582480540052132d, c: 0.2727194713257267d),
new NpgsqlTypes.NpgsqlLine(a: 0.32734388447728924d, b: 0.2889617263506432d, c: 0.2845790435941964d),
new NpgsqlTypes.NpgsqlLine(a: 0.174403824349869d, b: 0.5920397520495658d, c: 0.405569072793152d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6059961030372074d, b: 0.7804493977931866d, c: 0.8332970032300244d),
new NpgsqlTypes.NpgsqlLine(a: 0.7606492195841723d, b: 0.47625052119733335d, c: 0.4077886833891958d),
new NpgsqlTypes.NpgsqlLine(a: 0.15737580219154346d, b: 0.7147183211610445d, c: 0.20286141222998477d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8749600370038612d, b: 0.5781543513749542d, c: 0.35848190366221866d),
new NpgsqlTypes.NpgsqlLine(a: 0.15550963437927579d, b: 0.9303547661198746d, c: 0.8719387348510383d),
new NpgsqlTypes.NpgsqlLine(a: 0.10221837445487458d, b: 0.19560951353218192d, c: 0.6952020694224834d),
new NpgsqlTypes.NpgsqlLine(a: 0.9698770282532005d, b: 0.48386874897355703d, c: 0.15834021549481736d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 36, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 103, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

