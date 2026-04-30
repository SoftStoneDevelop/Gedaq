

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.40554938374720517d,right: 0.8950911726152456d,bottom: 0.30719036876304084d,left: 0.19673381149933367d),

new NpgsqlTypes.NpgsqlBox(top: 0.0884326951340898d,right: 0.6862048972776363d,bottom: 0.046356627518682525d,left: 0.5639761799830135d),

new NpgsqlTypes.NpgsqlBox(top: 0.9754782309549475d,right: 0.5665273533168097d,bottom: 0.7886365658193418d,left: 0.5265213644754337d),

new NpgsqlTypes.NpgsqlBox(top: 0.9530882826830246d,right: 0.9403901453100089d,bottom: 0.8398340938427816d,left: 0.5954164002918767d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5760782615111063d,right: 0.7207390007772143d,bottom: 0.050257044248434135d,left: 0.16127280205958294d),

new NpgsqlTypes.NpgsqlBox(top: 0.21243176640406658d,right: 0.8862836420394314d,bottom: 0.09431899876814875d,left: 0.25333437595028385d),

new NpgsqlTypes.NpgsqlBox(top: 0.4222912194486128d,right: 0.605757341063426d,bottom: 0.41984636634230477d,left: 0.2951959449221041d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9306816041860794d,right: 0.9600256698227541d,bottom: 0.17966993679607723d,left: 0.033574434333368264d),

new NpgsqlTypes.NpgsqlBox(top: 0.8019926983311924d,right: 0.6910172909598428d,bottom: 0.27341387769861825d,left: 0.13581558899103885d),

new NpgsqlTypes.NpgsqlBox(top: 0.9561807109688063d,right: 0.9474578011669977d,bottom: 0.12621040704201125d,left: 0.778150784020213d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7347962212550317d,right: 0.6430214040279337d,bottom: 0.6183556192072721d,left: 0.2556112555729463d),

new NpgsqlTypes.NpgsqlBox(top: 0.9845049122596717d,right: 0.9047290559325537d,bottom: 0.8259688987172622d,left: 0.36424097776236475d),

new NpgsqlTypes.NpgsqlBox(top: 0.9531222847793944d,right: 0.44821720344497995d,bottom: 0.4246399124498317d,left: 0.3001753686470112d),

new NpgsqlTypes.NpgsqlBox(top: 0.5428798674335101d,right: 0.46085772060486196d,bottom: 0.09041455593615488d,left: 0.020608162835455857d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.877823841856265d,right: 0.63084909607445d,bottom: 0.44915998764901255d,left: 0.35789808727717687d),

new NpgsqlTypes.NpgsqlBox(top: 0.7921678324000703d,right: 0.7617305086176257d,bottom: 0.663151135852181d,left: 0.500127801590121d),

new NpgsqlTypes.NpgsqlBox(top: 0.8949149155996831d,right: 0.4375748867519663d,bottom: 0.7945256245744124d,left: 0.3097137518515234d),

new NpgsqlTypes.NpgsqlBox(top: 0.9534695296568462d,right: 0.213277980363076d,bottom: 0.840441844950484d,left: 0.10909424094421472d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9254718534854869d,right: 0.5238070952347229d,bottom: 0.6101414779738655d,left: 0.3762119227095365d),

new NpgsqlTypes.NpgsqlBox(top: 0.7162428008447944d,right: 0.8560807986279035d,bottom: 0.37364388422925987d,left: 0.4598941520553135d),

new NpgsqlTypes.NpgsqlBox(top: 0.17508125978392297d,right: 0.8614982768073468d,bottom: 0.0281520258910275d,left: 0.18406732439196283d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9746355690431544d,right: 0.9737334215972357d,bottom: 0.44235264905241956d,left: 0.6067859036643363d),

new NpgsqlTypes.NpgsqlBox(top: 0.7911781315244225d,right: 0.34643191879800517d,bottom: 0.185959265505094d,left: 0.0951957592192677d),

new NpgsqlTypes.NpgsqlBox(top: 0.8579674498704034d,right: 0.392841817145268d,bottom: 0.17127082794674187d,left: 0.12402184812491701d),

new NpgsqlTypes.NpgsqlBox(top: 0.46370157181612415d,right: 0.79352209815657d,bottom: 0.05685889198806915d,left: 0.022513821370784504d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.643907870575242d,right: 0.9354759472035706d,bottom: 0.6405325654330859d,left: 0.83788825168542d),

new NpgsqlTypes.NpgsqlBox(top: 0.8849379949278532d,right: 0.5321673136623187d,bottom: 0.6968903544205679d,left: 0.48246708189003695d),

new NpgsqlTypes.NpgsqlBox(top: 0.9664106757788624d,right: 0.8729521182238584d,bottom: 0.41278530913332734d,left: 0.4770212008427027d),

new NpgsqlTypes.NpgsqlBox(top: 0.6585065272845917d,right: 0.9692932361145684d,bottom: 0.5798935665789445d,left: 0.7023419220007248d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3960174308996921d,right: 0.541514847707988d,bottom: 0.2415311441410064d,left: 0.30555776419594727d),

new NpgsqlTypes.NpgsqlBox(top: 0.6839595914769787d,right: 0.8279579927074084d,bottom: 0.32180287233113536d,left: 0.7791613762322934d),

new NpgsqlTypes.NpgsqlBox(top: 0.4773299782716005d,right: 0.3192076003673644d,bottom: 0.24526806175227878d,left: 0.2796939679387952d),

new NpgsqlTypes.NpgsqlBox(top: 0.30719358904769745d,right: 0.18084033221359053d,bottom: 0.20370501924232964d,left: 0.18048398417574651d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8162269289383453d,right: 0.7790229046006999d,bottom: 0.5731378799418282d,left: 0.6526514320575406d),

new NpgsqlTypes.NpgsqlBox(top: 0.7705178410430144d,right: 0.3963714788128849d,bottom: 0.29245288564804583d,left: 0.020298360191461584d),

new NpgsqlTypes.NpgsqlBox(top: 0.5044185509927327d,right: 0.9605094942423492d,bottom: 0.4275875775662157d,left: 0.0060224867300820994d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20312339206468188d,right: 0.061986808766659296d,bottom: 0.17150178936496663d,left: 0.04684442816594214d),

new NpgsqlTypes.NpgsqlBox(top: 0.6013395993595367d,right: 0.8260138882047067d,bottom: 0.5295696767637648d,left: 0.394800902323695d),

new NpgsqlTypes.NpgsqlBox(top: 0.8051273278415767d,right: 0.5463328110116353d,bottom: 0.021809524268853298d,left: 0.05066862214563961d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.04753584543464462d,right: 0.8604471111467734d,bottom: 0.009657082414555207d,left: 0.038616748120624655d),

new NpgsqlTypes.NpgsqlBox(top: 0.4405082094453212d,right: 0.5589762298950072d,bottom: 0.38410204269675974d,left: 0.25877727217633406d),

new NpgsqlTypes.NpgsqlBox(top: 0.8769491456883415d,right: 0.7945745898891595d,bottom: 0.5233887829573439d,left: 0.5939186107442187d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7208369606758236d,right: 0.8062990408234739d,bottom: 0.13730019650963476d,left: 0.18395477312624042d),

new NpgsqlTypes.NpgsqlBox(top: 0.9669301241583741d,right: 0.3062413999432424d,bottom: 0.909426860078206d,left: 0.10516150079811792d),

new NpgsqlTypes.NpgsqlBox(top: 0.22881094358420206d,right: 0.9839344361207905d,bottom: 0.07653801572128027d,left: 0.5912568940466801d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7713237962260496d,right: 0.6841916584539045d,bottom: 0.7085788825511418d,left: 0.5346596973108666d),

new NpgsqlTypes.NpgsqlBox(top: 0.8279010464284786d,right: 0.29065969831578087d,bottom: 0.5293241531373428d,left: 0.021574444258911418d),

new NpgsqlTypes.NpgsqlBox(top: 0.13614674730660492d,right: 0.9275039684778401d,bottom: 0.09430076318254921d,left: 0.39201585049328336d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4867856452224266d,right: 0.8609424189015206d,bottom: 0.231554988970621d,left: 0.4774987018178911d),

new NpgsqlTypes.NpgsqlBox(top: 0.6083087523089573d,right: 0.26351917495396515d,bottom: 0.5880245469582963d,left: 0.06125206969554298d),

new NpgsqlTypes.NpgsqlBox(top: 0.9078792836196049d,right: 0.23967128765079715d,bottom: 0.4200184290735137d,left: 0.005915566763819213d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46828329982442174d,right: 0.32730808025724933d,bottom: 0.04823286465217813d,left: 0.09280299341493714d),

new NpgsqlTypes.NpgsqlBox(top: 0.9013200344227765d,right: 0.7170357754829473d,bottom: 0.7064038989932823d,left: 0.4708772877587546d),

new NpgsqlTypes.NpgsqlBox(top: 0.6403295182434855d,right: 0.7243935587624732d,bottom: 0.3247755790394341d,left: 0.39397893900979797d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.969685783197269d,right: 0.699057271614059d,bottom: 0.9483774054625673d,left: 0.3670507495767067d),

new NpgsqlTypes.NpgsqlBox(top: 0.564226804078575d,right: 0.6417691400405302d,bottom: 0.01596652159320966d,left: 0.3382056821528172d),

new NpgsqlTypes.NpgsqlBox(top: 0.5780431607643973d,right: 0.5176743384253255d,bottom: 0.030184445585053732d,left: 0.23752386163642647d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.30917799347907304d,right: 0.20756805860477068d,bottom: 0.09744178837047413d,left: 0.13878686520977734d),

new NpgsqlTypes.NpgsqlBox(top: 0.6616148944413176d,right: 0.7038923062585997d,bottom: 0.07521897597352156d,left: 0.30985651249723d),

new NpgsqlTypes.NpgsqlBox(top: 0.9596060019445978d,right: 0.8193997263904922d,bottom: 0.4884841277371571d,left: 0.5590521667600085d),

new NpgsqlTypes.NpgsqlBox(top: 0.5821540238097661d,right: 0.929793797025876d,bottom: 0.49918422140129004d,left: 0.874459036024204d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.910884313496778d,right: 0.3404097168258131d,bottom: 0.7221049499406955d,left: 0.1471666319580367d),

new NpgsqlTypes.NpgsqlBox(top: 0.2641117839165549d,right: 0.5243548949109251d,bottom: 0.03530228877157293d,left: 0.42704286917846346d),

new NpgsqlTypes.NpgsqlBox(top: 0.7035943207031674d,right: 0.30852176279534416d,bottom: 0.0790323404842388d,left: 0.005192451411092924d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.34629122504021337d,right: 0.7976687037869549d,bottom: 0.208435264358669d,left: 0.2736672784512546d),

new NpgsqlTypes.NpgsqlBox(top: 0.7110558515963858d,right: 0.8105440169422236d,bottom: 0.6915660268032059d,left: 0.625705114053284d),

new NpgsqlTypes.NpgsqlBox(top: 0.9157871699492143d,right: 0.9655018633758471d,bottom: 0.5644724800079495d,left: 0.20684382419821135d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.742136894002314d,right: 0.8702115489497715d,bottom: 0.37952028235465907d,left: 0.09516417617771755d),

new NpgsqlTypes.NpgsqlBox(top: 0.7713843186980641d,right: 0.45731951820423034d,bottom: 0.3079219599956371d,left: 0.05526922854492877d),

new NpgsqlTypes.NpgsqlBox(top: 0.8554169445407732d,right: 0.1059263456399927d,bottom: 0.8134462250309064d,left: 0.037726567463982064d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8529953562411585d,right: 0.8641455663137351d,bottom: 0.059795389740688654d,left: 0.5916031687889245d),

new NpgsqlTypes.NpgsqlBox(top: 0.5751660286898063d,right: 0.568128815192385d,bottom: 0.20219665089402372d,left: 0.3582775618955941d),

new NpgsqlTypes.NpgsqlBox(top: 0.8034659889582365d,right: 0.68764691672847d,bottom: 0.2406286286792787d,left: 0.3615485876843957d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9537331756244828d,right: 0.7013909156281991d,bottom: 0.6929533524660565d,left: 0.13840921600662137d),

new NpgsqlTypes.NpgsqlBox(top: 0.9228927813198151d,right: 0.7368312135965812d,bottom: 0.02561679384324489d,left: 0.715714608677557d),

new NpgsqlTypes.NpgsqlBox(top: 0.8889542053168966d,right: 0.9696539404731993d,bottom: 0.31207845305916804d,left: 0.5119839045270013d),

new NpgsqlTypes.NpgsqlBox(top: 0.9227250593082412d,right: 0.8060988115232451d,bottom: 0.7326395651979366d,left: 0.42681954831775293d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5204009511792305d,right: 0.22812307468088822d,bottom: 0.2685835971881938d,left: 0.04279944717344797d),

new NpgsqlTypes.NpgsqlBox(top: 0.551019906513106d,right: 0.6208344144938681d,bottom: 0.14532805889629496d,left: 0.15759054744565082d),

new NpgsqlTypes.NpgsqlBox(top: 0.4976618812968133d,right: 0.9014511182342396d,bottom: 0.19748429181246718d,left: 0.7968140911093863d),

new NpgsqlTypes.NpgsqlBox(top: 0.5976760697550658d,right: 0.3079281868792305d,bottom: 0.019744158080616914d,left: 0.1914779462932057d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1475678616748658d,right: 0.5500276275261063d,bottom: 0.12724490398937505d,left: 0.4835221719401267d),

new NpgsqlTypes.NpgsqlBox(top: 0.2617542898878291d,right: 0.8451079729139804d,bottom: 0.22642631932483348d,left: 0.6259671820918763d),

new NpgsqlTypes.NpgsqlBox(top: 0.7123385743333079d,right: 0.8901016125922729d,bottom: 0.45697584826258d,left: 0.42312227284407244d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6807144707005256d,right: 0.595332872238526d,bottom: 0.444611571440511d,left: 0.5195566224894084d),

new NpgsqlTypes.NpgsqlBox(top: 0.9895295383988547d,right: 0.38959149799976656d,bottom: 0.837262376124464d,left: 0.02526075296839092d),

new NpgsqlTypes.NpgsqlBox(top: 0.5814043565674557d,right: 0.8152818447083318d,bottom: 0.38223110501937796d,left: 0.6908758425521678d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.745203820914593d,right: 0.4182254301087974d,bottom: 0.43135469191538234d,left: 0.047967437928509216d),

new NpgsqlTypes.NpgsqlBox(top: 0.6312989238530772d,right: 0.13162370554525837d,bottom: 0.6254557971110399d,left: 0.08488721257898435d),

new NpgsqlTypes.NpgsqlBox(top: 0.5785006668650464d,right: 0.16802954762031397d,bottom: 0.41652620902415705d,left: 0.033577565775748885d),

new NpgsqlTypes.NpgsqlBox(top: 0.8118871816208633d,right: 0.8099159812101238d,bottom: 0.39558596125916046d,left: 0.8004926257563936d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4412338665795399d,right: 0.5580303874552993d,bottom: 0.15162533618510143d,left: 0.18552104438466643d),

new NpgsqlTypes.NpgsqlBox(top: 0.6637624410910508d,right: 0.8019184023641605d,bottom: 0.045851035887666036d,left: 0.11210884083184913d),

new NpgsqlTypes.NpgsqlBox(top: 0.5215834601435302d,right: 0.5753991473183379d,bottom: 0.13681464119706932d,left: 0.20454933241071227d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8949063972059266d,right: 0.7591763560241447d,bottom: 0.49154934619757396d,left: 0.2333840454250039d),

new NpgsqlTypes.NpgsqlBox(top: 0.635718494292234d,right: 0.47715194263739025d,bottom: 0.26450883275762105d,left: 0.2710317650435732d),

new NpgsqlTypes.NpgsqlBox(top: 0.8094668496121881d,right: 0.915146552818319d,bottom: 0.1289712611748144d,left: 0.577142467548168d),

new NpgsqlTypes.NpgsqlBox(top: 0.652530613628538d,right: 0.7111463677054577d,bottom: 0.5447963661202239d,left: 0.14011253424489334d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5298464073336868d,right: 0.8688767782262405d,bottom: 0.23553641506456202d,left: 0.23492398001396142d),

new NpgsqlTypes.NpgsqlBox(top: 0.6585721432366294d,right: 0.6282681577856689d,bottom: 0.40023513062554994d,left: 0.46770795850780633d),

new NpgsqlTypes.NpgsqlBox(top: 0.901887650409228d,right: 0.7534910163706949d,bottom: 0.2782285843706511d,left: 0.319887983627271d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8034451621376162d,right: 0.6589565058364619d,bottom: 0.4107848988173659d,left: 0.19595440280973864d),

new NpgsqlTypes.NpgsqlBox(top: 0.5464203263636765d,right: 0.5224399475091336d,bottom: 0.03508719787594716d,left: 0.02229751622789533d),

new NpgsqlTypes.NpgsqlBox(top: 0.5950417572400668d,right: 0.9603073590522364d,bottom: 0.09587572535817945d,left: 0.6708148818942312d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7769536466241457d,right: 0.7200589390086978d,bottom: 0.21763404954776744d,left: 0.02720765791187174d),

new NpgsqlTypes.NpgsqlBox(top: 0.7956696920079868d,right: 0.6896766712826172d,bottom: 0.22329849124781953d,left: 0.6289690141673725d),

new NpgsqlTypes.NpgsqlBox(top: 0.9701730016202306d,right: 0.9802411666494094d,bottom: 0.34870323955077764d,left: 0.42165584472946516d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3287615996556785d,right: 0.8197456601308637d,bottom: 0.19987367299607228d,left: 0.38978769820872916d),

new NpgsqlTypes.NpgsqlBox(top: 0.5289502140988321d,right: 0.7364832686652734d,bottom: 0.14336315426979596d,left: 0.7032114614886724d),

new NpgsqlTypes.NpgsqlBox(top: 0.29903324119753116d,right: 0.10117959039973978d,bottom: 0.14252632675978794d,left: 0.016838037674385298d),

new NpgsqlTypes.NpgsqlBox(top: 0.15703948380821642d,right: 0.6778916362181395d,bottom: 0.1546094342017178d,left: 0.40465283673050956d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7135340513148188d,right: 0.8156868796174882d,bottom: 0.6533586142679224d,left: 0.6723291301827212d),

new NpgsqlTypes.NpgsqlBox(top: 0.6109023410170327d,right: 0.7512361154685432d,bottom: 0.5129668262044017d,left: 0.7102666428347759d),

new NpgsqlTypes.NpgsqlBox(top: 0.4390500288988596d,right: 0.9220153716096049d,bottom: 0.3463299343275821d,left: 0.9096318625562981d),

new NpgsqlTypes.NpgsqlBox(top: 0.6009973551547302d,right: 0.7838707092814752d,bottom: 0.45213545786136977d,left: 0.3079674104438722d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3807036317311324d,right: 0.9381640377416417d,bottom: 0.08882440049994444d,left: 0.13916619184789758d),

new NpgsqlTypes.NpgsqlBox(top: 0.8835815448846449d,right: 0.9480356013248343d,bottom: 0.4755056358362516d,left: 0.9140458221715251d),

new NpgsqlTypes.NpgsqlBox(top: 0.8906618891823666d,right: 0.896047930016541d,bottom: 0.5011482674749416d,left: 0.278316354955097d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2678183159492993d,right: 0.9538645399683181d,bottom: 0.001061979345489017d,left: 0.07911243558319914d),

new NpgsqlTypes.NpgsqlBox(top: 0.8745671229693097d,right: 0.9134222771713301d,bottom: 0.7273641144650672d,left: 0.5750484566503621d),

new NpgsqlTypes.NpgsqlBox(top: 0.5112893517063551d,right: 0.6712754252268367d,bottom: 0.0446884003526723d,left: 0.18928908781450304d),

new NpgsqlTypes.NpgsqlBox(top: 0.4822732021162218d,right: 0.4666413018020441d,bottom: 0.30704120836301885d,left: 0.2519117904167605d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.790805959475333d,right: 0.9525559373428412d,bottom: 0.1752950589897595d,left: 0.8254651083278085d),

new NpgsqlTypes.NpgsqlBox(top: 0.6329755372989162d,right: 0.25735002908862026d,bottom: 0.051585548064696174d,left: 0.05043212323039847d),

new NpgsqlTypes.NpgsqlBox(top: 0.13717797583513924d,right: 0.9134682269209236d,bottom: 0.08388735857985952d,left: 0.2726938105869239d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5873523581396679d,right: 0.7677692693125553d,bottom: 0.5654379808489899d,left: 0.08211874711866285d),

new NpgsqlTypes.NpgsqlBox(top: 0.7722052126485629d,right: 0.6729107389018938d,bottom: 0.04417838243891392d,left: 0.6093639422886857d),

new NpgsqlTypes.NpgsqlBox(top: 0.5807555927794908d,right: 0.9360554744713702d,bottom: 0.057042196363601416d,left: 0.8276233228940371d),

new NpgsqlTypes.NpgsqlBox(top: 0.9135340168508878d,right: 0.6497024808908896d,bottom: 0.8858347858358105d,left: 0.5679263527360354d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46523807849040966d,right: 0.7077890131172904d,bottom: 0.011639074144956796d,left: 0.3612809082605021d),

new NpgsqlTypes.NpgsqlBox(top: 0.8278742568985561d,right: 0.0861487826015751d,bottom: 0.7959244179003336d,left: 0.00033635236936191415d),

new NpgsqlTypes.NpgsqlBox(top: 0.8305498734155465d,right: 0.7472155827295327d,bottom: 0.7618373578370699d,left: 0.5186850707546713d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6873353022615083d,right: 0.9290928838819777d,bottom: 0.6439689743885094d,left: 0.034621770007444486d),

new NpgsqlTypes.NpgsqlBox(top: 0.7561476882921807d,right: 0.652275279295415d,bottom: 0.7106909805780557d,left: 0.46336468036361744d),

new NpgsqlTypes.NpgsqlBox(top: 0.847950552539123d,right: 0.8605710823894956d,bottom: 0.4003548718551543d,left: 0.41969349898451236d),

new NpgsqlTypes.NpgsqlBox(top: 0.14405762164462055d,right: 0.5601050657250772d,bottom: 0.08021267006202437d,left: 0.5532457870265848d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7127151235117004d,right: 0.4424360657580405d,bottom: 0.4686718316349907d,left: 0.22807205627884475d),

new NpgsqlTypes.NpgsqlBox(top: 0.9176301441103338d,right: 0.3003327613485307d,bottom: 0.4179762481860607d,left: 0.17001725996014772d),

new NpgsqlTypes.NpgsqlBox(top: 0.7515922940797486d,right: 0.5292984166284987d,bottom: 0.44111821850490673d,left: 0.046099475074171226d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3492612293960886d,right: 0.515288608893949d,bottom: 0.009218217802946405d,left: 0.4614673525219357d),

new NpgsqlTypes.NpgsqlBox(top: 0.9044816406035351d,right: 0.9382944125241488d,bottom: 0.6932811098256592d,left: 0.39900233199292134d),

new NpgsqlTypes.NpgsqlBox(top: 0.8381613727100738d,right: 0.5651449953553864d,bottom: 0.24361294857611782d,left: 0.3571305568031443d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8676346994381348d,right: 0.5618532316674406d,bottom: 0.08928715729972792d,left: 0.2515189911191853d),

new NpgsqlTypes.NpgsqlBox(top: 0.9871086887732922d,right: 0.10371956112956371d,bottom: 0.8706991508433842d,left: 0.017813188814413183d),

new NpgsqlTypes.NpgsqlBox(top: 0.8629485479858068d,right: 0.9223184372413988d,bottom: 0.6004863779700992d,left: 0.17490212352209022d),

new NpgsqlTypes.NpgsqlBox(top: 0.9821172414032757d,right: 0.6290389071026117d,bottom: 0.2353008642822213d,left: 0.4980962556613855d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6959889970697383d,right: 0.996984120842005d,bottom: 0.1658443029431299d,left: 0.2653227797097282d),

new NpgsqlTypes.NpgsqlBox(top: 0.5432866834021828d,right: 0.6426032959607357d,bottom: 0.2845908798269644d,left: 0.0605759668771334d),

new NpgsqlTypes.NpgsqlBox(top: 0.5825976086421816d,right: 0.1525183412326051d,bottom: 0.5042098636719362d,left: 0.052891121869662716d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9053079433573417d,right: 0.8842564266280762d,bottom: 0.6341302818951285d,left: 0.4079344452214292d),

new NpgsqlTypes.NpgsqlBox(top: 0.4883858420608862d,right: 0.6577000724545762d,bottom: 0.3046763441706314d,left: 0.3220356326958458d),

new NpgsqlTypes.NpgsqlBox(top: 0.41430263431371583d,right: 0.8395815656216056d,bottom: 0.40931917409592455d,left: 0.4120024061515406d),

new NpgsqlTypes.NpgsqlBox(top: 0.9110448577387465d,right: 0.9351320298998529d,bottom: 0.4864715063754418d,left: 0.46571356111979745d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5125840898406796d,right: 0.9931002932362848d,bottom: 0.07544653848058125d,left: 0.24192527896646177d),

new NpgsqlTypes.NpgsqlBox(top: 0.6352030149869222d,right: 0.6608230333857547d,bottom: 0.27832847744754885d,left: 0.5801836849299618d),

new NpgsqlTypes.NpgsqlBox(top: 0.8447140783389299d,right: 0.7132807697941344d,bottom: 0.22746880541377623d,left: 0.01844168128068724d),

new NpgsqlTypes.NpgsqlBox(top: 0.8113461009426444d,right: 0.9684432976067441d,bottom: 0.40408575342554454d,left: 0.9561853433719268d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6780349274843399d,right: 0.7990602561697838d,bottom: 0.6045085634402124d,left: 0.5546251229726744d),

new NpgsqlTypes.NpgsqlBox(top: 0.7017005435147102d,right: 0.750840108569684d,bottom: 0.4153033368288701d,left: 0.19853473514678255d),

new NpgsqlTypes.NpgsqlBox(top: 0.3052881437974351d,right: 0.8420520412175435d,bottom: 0.1635977445407426d,left: 0.502610640383183d),

new NpgsqlTypes.NpgsqlBox(top: 0.96867436027172d,right: 0.44475945007676954d,bottom: 0.518462856565119d,left: 0.05699479613046199d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8723791059137951d,right: 0.5083863349866109d,bottom: 0.7165015320293008d,left: 0.26924229866777794d),

new NpgsqlTypes.NpgsqlBox(top: 0.6465968426334296d,right: 0.9421342252676693d,bottom: 0.014558211637421214d,left: 0.5388517779221388d),

new NpgsqlTypes.NpgsqlBox(top: 0.6771201511174091d,right: 0.608094288725767d,bottom: 0.17140175732947582d,left: 0.550961733946149d),

new NpgsqlTypes.NpgsqlBox(top: 0.8005772475278043d,right: 0.4634582973364203d,bottom: 0.12161061976412046d,left: 0.35400475889443317d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9177982688653771d,right: 0.8552455840383613d,bottom: 0.11488207107588433d,left: 0.5096289168834d),

new NpgsqlTypes.NpgsqlBox(top: 0.821469599384681d,right: 0.3137656700071899d,bottom: 0.7365900513320525d,left: 0.28357910545612286d),

new NpgsqlTypes.NpgsqlBox(top: 0.7349666031024764d,right: 0.5121869338342996d,bottom: 0.4382224534950684d,left: 0.020668168142474075d),

new NpgsqlTypes.NpgsqlBox(top: 0.3056565280194602d,right: 0.4864926627195595d,bottom: 0.18857944403029203d,left: 0.0563895083232937d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3371231749765655d,right: 0.690963508494657d,bottom: 0.22402377218507163d,left: 0.022388231024675576d),

new NpgsqlTypes.NpgsqlBox(top: 0.24791923786269754d,right: 0.7423740333914798d,bottom: 0.11791736516839724d,left: 0.44190449541346055d),

new NpgsqlTypes.NpgsqlBox(top: 0.17444777845650894d,right: 0.34033376697477347d,bottom: 0.1237075790588068d,left: 0.18040498566176488d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44157548322863427d,right: 0.8609948120263424d,bottom: 0.1080554691006198d,left: 0.14114657023963084d),

new NpgsqlTypes.NpgsqlBox(top: 0.9865393983710851d,right: 0.39120616295962674d,bottom: 0.004559901002881284d,left: 0.13677798819902542d),

new NpgsqlTypes.NpgsqlBox(top: 0.9857522050467085d,right: 0.7269049433577123d,bottom: 0.43755212251788833d,left: 0.005413602188783506d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5514393320448995d,right: 0.9141491356045406d,bottom: 0.4767480926701442d,left: 0.9050496528137149d),

new NpgsqlTypes.NpgsqlBox(top: 0.7345657655726022d,right: 0.6948522243975993d,bottom: 0.4085873452091905d,left: 0.0037957716282444043d),

new NpgsqlTypes.NpgsqlBox(top: 0.27006099087606805d,right: 0.4767543065424693d,bottom: 0.24840481022039684d,left: 0.17189055813496423d),

new NpgsqlTypes.NpgsqlBox(top: 0.7880522954414506d,right: 0.794035264861792d,bottom: 0.08132305823683239d,left: 0.4932770989849744d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7517963724701708d,right: 0.6398324065309352d,bottom: 0.5523492598544569d,left: 0.26060949987965176d),

new NpgsqlTypes.NpgsqlBox(top: 0.8789129093296838d,right: 0.7747202685822185d,bottom: 0.7347915697895265d,left: 0.07559298470422082d),

new NpgsqlTypes.NpgsqlBox(top: 0.2686880665201816d,right: 0.3428466956952688d,bottom: 0.030940887458034805d,left: 0.2714028171153957d),

new NpgsqlTypes.NpgsqlBox(top: 0.5009223700647369d,right: 0.9952562197098366d,bottom: 0.24403924490681894d,left: 0.3302946101377302d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8008626531525352d,right: 0.6398309749587826d,bottom: 0.5136857252595386d,left: 0.5276618136267898d),

new NpgsqlTypes.NpgsqlBox(top: 0.8023771524322607d,right: 0.9865776588040254d,bottom: 0.1631293641103282d,left: 0.909354074767792d),

new NpgsqlTypes.NpgsqlBox(top: 0.6417091553801102d,right: 0.3320062001403785d,bottom: 0.09210765059574888d,left: 0.2786045887409344d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.855166767947849d,right: 0.8076059649739928d,bottom: 0.6666936366851162d,left: 0.609723136566684d),

new NpgsqlTypes.NpgsqlBox(top: 0.906458977604663d,right: 0.7989534435812347d,bottom: 0.40201606074408525d,left: 0.7531101784523936d),

new NpgsqlTypes.NpgsqlBox(top: 0.8346305606735291d,right: 0.9989813976624634d,bottom: 0.3878949740452027d,left: 0.5821178155505106d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6486360196779061d,right: 0.936452528358322d,bottom: 0.6057564111914339d,left: 0.006510645595884101d),

new NpgsqlTypes.NpgsqlBox(top: 0.7971729679568508d,right: 0.34906161154441095d,bottom: 0.5282228450424344d,left: 0.06265885078017963d),

new NpgsqlTypes.NpgsqlBox(top: 0.8996874401806731d,right: 0.5574891345019153d,bottom: 0.1510163920440445d,left: 0.040428659616192575d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.972372146020193d,right: 0.764239998040012d,bottom: 0.6444819211949192d,left: 0.43095875346900003d),

new NpgsqlTypes.NpgsqlBox(top: 0.5899318798588471d,right: 0.9113599088261078d,bottom: 0.4840944926176526d,left: 0.03979716657107857d),

new NpgsqlTypes.NpgsqlBox(top: 0.4023225257911991d,right: 0.9622746106203032d,bottom: 0.40203171174572006d,left: 0.5026558475851015d),

new NpgsqlTypes.NpgsqlBox(top: 0.8060487249946044d,right: 0.7559153616340036d,bottom: 0.5910978367657512d,left: 0.10784053286281259d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8167082200423922d,right: 0.3141683366888406d,bottom: 0.061190872729281365d,left: 0.27071468678097277d),

new NpgsqlTypes.NpgsqlBox(top: 0.5125795191416246d,right: 0.19883261077588255d,bottom: 0.3492802810016151d,left: 0.0987041347404356d),

new NpgsqlTypes.NpgsqlBox(top: 0.9952196014627235d,right: 0.9805094580474244d,bottom: 0.06651643444136224d,left: 0.5862369652398945d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8051497875606408d,right: 0.671803904570514d,bottom: 0.13953428670183687d,left: 0.023611212753543498d),

new NpgsqlTypes.NpgsqlBox(top: 0.37097311548052736d,right: 0.6018994865151344d,bottom: 0.08600170272798546d,left: 0.025379878484724894d),

new NpgsqlTypes.NpgsqlBox(top: 0.706644920305892d,right: 0.7051665212306737d,bottom: 0.09933224578429667d,left: 0.46817373363097425d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49472887913093944d,right: 0.3872697085836265d,bottom: 0.29469005681464944d,left: 0.03738322721286691d),

new NpgsqlTypes.NpgsqlBox(top: 0.3078876220734664d,right: 0.8637782696432383d,bottom: 0.018797342923657978d,left: 0.8255379846256404d),

new NpgsqlTypes.NpgsqlBox(top: 0.5521032169521115d,right: 0.8544399832878052d,bottom: 0.29795744924997714d,left: 0.5606029169743995d),

new NpgsqlTypes.NpgsqlBox(top: 0.9884127441408913d,right: 0.7665606937604567d,bottom: 0.364264604662762d,left: 0.15431608763914206d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8108849443921459d,right: 0.4797919829820958d,bottom: 0.260021724374649d,left: 0.2615023809818139d),

new NpgsqlTypes.NpgsqlBox(top: 0.6051252621146505d,right: 0.845682607657144d,bottom: 0.2174902619254242d,left: 0.4101784622389021d),

new NpgsqlTypes.NpgsqlBox(top: 0.9775723192911093d,right: 0.9688479457000336d,bottom: 0.33059660868336427d,left: 0.5229277774916716d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5793562390802839d,right: 0.9253289249445286d,bottom: 0.058222425490305985d,left: 0.20990831775038232d),

new NpgsqlTypes.NpgsqlBox(top: 0.93005536486158d,right: 0.9836317900489019d,bottom: 0.6182050098723371d,left: 0.722230148103042d),

new NpgsqlTypes.NpgsqlBox(top: 0.5440849566466088d,right: 0.22626945147636468d,bottom: 0.18724732152882795d,left: 0.036156624295336504d),

new NpgsqlTypes.NpgsqlBox(top: 0.309202824920636d,right: 0.5635975560252311d,bottom: 0.2986141613997837d,left: 0.5456741339463719d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7332091210155507d,right: 0.9075308924517151d,bottom: 0.5654328717167992d,left: 0.4245307722877222d),

new NpgsqlTypes.NpgsqlBox(top: 0.8753674778202357d,right: 0.5044871719301357d,bottom: 0.6818057462281825d,left: 0.09954253917435674d),

new NpgsqlTypes.NpgsqlBox(top: 0.832205833752787d,right: 0.5992346054629603d,bottom: 0.28442914897901495d,left: 0.29029844789736536d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9360306373476032d,right: 0.18895560331065286d,bottom: 0.060392373029407254d,left: 0.10537899564353181d),

new NpgsqlTypes.NpgsqlBox(top: 0.920157568486006d,right: 0.3103993996515251d,bottom: 0.5319146764172996d,left: 0.25213185424687734d),

new NpgsqlTypes.NpgsqlBox(top: 0.8043356073046891d,right: 0.7122904732197102d,bottom: 0.7012440307487915d,left: 0.3420462645784047d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5281873291831085d,right: 0.7379624669179545d,bottom: 0.48062825464087133d,left: 0.20344370592473238d),

new NpgsqlTypes.NpgsqlBox(top: 0.44357122178737807d,right: 0.6066834422356183d,bottom: 0.18141404905016345d,left: 0.4824811366413908d),

new NpgsqlTypes.NpgsqlBox(top: 0.8744924489640397d,right: 0.9937524145018642d,bottom: 0.6830309973338133d,left: 0.08550229437864632d),

new NpgsqlTypes.NpgsqlBox(top: 0.9626071215820212d,right: 0.6730306508945535d,bottom: 0.09719196912688977d,left: 0.5818317561811523d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5461325552043412d,right: 0.8923853506018442d,bottom: 0.4828655916190332d,left: 0.6279673066965018d),

new NpgsqlTypes.NpgsqlBox(top: 0.8148774362461052d,right: 0.4428818000639966d,bottom: 0.47694376164863395d,left: 0.3230380678747995d),

new NpgsqlTypes.NpgsqlBox(top: 0.9158999960568128d,right: 0.8907729778080412d,bottom: 0.6899658731476144d,left: 0.3174433544615406d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7980446173320471d,right: 0.8238952409914378d,bottom: 0.5743664604964598d,left: 0.46648998599235125d),

new NpgsqlTypes.NpgsqlBox(top: 0.9111777057497041d,right: 0.9350750909792768d,bottom: 0.07811172949202494d,left: 0.45423056024859754d),

new NpgsqlTypes.NpgsqlBox(top: 0.6472003224759286d,right: 0.7787574669088437d,bottom: 0.40987120530580823d,left: 0.679679572743322d),

new NpgsqlTypes.NpgsqlBox(top: 0.7799793836002094d,right: 0.1461029794082661d,bottom: 0.5569931992978991d,left: 0.12445383424177425d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8598159780872613d,right: 0.6294963240546942d,bottom: 0.3361751756713407d,left: 0.5070527525348784d),

new NpgsqlTypes.NpgsqlBox(top: 0.35721698575925787d,right: 0.22662237413124942d,bottom: 0.24235479095272705d,left: 0.13092470005753554d),

new NpgsqlTypes.NpgsqlBox(top: 0.07403202093549444d,right: 0.6659826593389411d,bottom: 0.035374306839408454d,left: 0.25527057586933277d),

new NpgsqlTypes.NpgsqlBox(top: 0.6056656852867387d,right: 0.9718360227543851d,bottom: 0.4200165602726833d,left: 0.6908132533973786d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8490491165710299d,right: 0.2778207129973721d,bottom: 0.6673554549639137d,left: 0.20531660151208575d),

new NpgsqlTypes.NpgsqlBox(top: 0.9268802191282873d,right: 0.8102210747846932d,bottom: 0.3850068883176875d,left: 0.5388471775593949d),

new NpgsqlTypes.NpgsqlBox(top: 0.46123364522314214d,right: 0.6537616581293388d,bottom: 0.4509379927694359d,left: 0.5225219951512291d),

new NpgsqlTypes.NpgsqlBox(top: 0.8776246725116419d,right: 0.8536864638968876d,bottom: 0.6302032413601026d,left: 0.30854037562607073d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5818736495998635d,right: 0.4039931785214699d,bottom: 0.3472450952195171d,left: 0.028114776352402115d),

new NpgsqlTypes.NpgsqlBox(top: 0.9491111295424802d,right: 0.6577900023017621d,bottom: 0.19624083802738002d,left: 0.4507526147387706d),

new NpgsqlTypes.NpgsqlBox(top: 0.4318505232458877d,right: 0.87012532920858d,bottom: 0.4208683808090695d,left: 0.2878945364612391d),

new NpgsqlTypes.NpgsqlBox(top: 0.4113781195117231d,right: 0.9334084872223335d,bottom: 0.32573236598217314d,left: 0.4150182289622586d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8984588067889865d,right: 0.7194622477616812d,bottom: 0.044213520111724636d,left: 0.6431088736686341d),

new NpgsqlTypes.NpgsqlBox(top: 0.6657494199184285d,right: 0.29739868053134877d,bottom: 0.24294908743687427d,left: 0.07656162238049613d),

new NpgsqlTypes.NpgsqlBox(top: 0.5859289425059933d,right: 0.8901988266831798d,bottom: 0.4819584340376798d,left: 0.333302015493918d),

new NpgsqlTypes.NpgsqlBox(top: 0.8108088728560188d,right: 0.5136591453114329d,bottom: 0.21390532889152847d,left: 0.3519081495279428d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4999723297961858d,right: 0.9201886944484424d,bottom: 0.10534647995644042d,left: 0.5438403311119858d),

new NpgsqlTypes.NpgsqlBox(top: 0.6776187439908394d,right: 0.8926749506620444d,bottom: 0.21001080582558762d,left: 0.4885988456771043d),

new NpgsqlTypes.NpgsqlBox(top: 0.5345626677688868d,right: 0.13149960887487333d,bottom: 0.1920660316924785d,left: 8.378759744409603E-05d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8715175212824815d,right: 0.7691439250874482d,bottom: 0.02424008270745459d,left: 0.1267307682110197d),

new NpgsqlTypes.NpgsqlBox(top: 0.7442643756450685d,right: 0.5226830121595373d,bottom: 0.4227337379924194d,left: 0.05372795329521041d),

new NpgsqlTypes.NpgsqlBox(top: 0.5439739726912879d,right: 0.9308960526766725d,bottom: 0.09142360244778935d,left: 0.17272600551054662d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6600366680456357d,right: 0.5579777331384349d,bottom: 0.575007332635632d,left: 0.44841500873614404d),

new NpgsqlTypes.NpgsqlBox(top: 0.24901177061563062d,right: 0.5239634666162751d,bottom: 0.12094426571407524d,left: 0.1910266567124247d),

new NpgsqlTypes.NpgsqlBox(top: 0.7985158782787246d,right: 0.7978895926844806d,bottom: 0.5969365705627067d,left: 0.15555344919837155d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9898696375498285d,right: 0.22044766697707852d,bottom: 0.9128644269544719d,left: 0.04026930400057216d),

new NpgsqlTypes.NpgsqlBox(top: 0.4247613267773884d,right: 0.6701938289525815d,bottom: 0.0731888716282838d,left: 0.20093387080328784d),

new NpgsqlTypes.NpgsqlBox(top: 0.8112150243794425d,right: 0.818262306303747d,bottom: 0.5933176042435162d,left: 0.38371464720832826d),

new NpgsqlTypes.NpgsqlBox(top: 0.553619451220549d,right: 0.8838782147687108d,bottom: 0.5348891624667724d,left: 0.8112598905814661d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8555420226748428d,right: 0.9379573445274832d,bottom: 0.7889949966521603d,left: 0.8608937748715813d),

new NpgsqlTypes.NpgsqlBox(top: 0.9850937357772019d,right: 0.9683151907008094d,bottom: 0.520871568809881d,left: 0.43351908747697565d),

new NpgsqlTypes.NpgsqlBox(top: 0.9304662387620575d,right: 0.9213844985467733d,bottom: 0.07942527536079547d,left: 0.8991686041601269d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9213584762022994d,right: 0.7147355360323724d,bottom: 0.39792991695288915d,left: 0.27492508421946404d),

new NpgsqlTypes.NpgsqlBox(top: 0.9802090523305218d,right: 0.8286256640255432d,bottom: 0.929317214068694d,left: 0.4622694338427352d),

new NpgsqlTypes.NpgsqlBox(top: 0.9056649637208042d,right: 0.8101700105404526d,bottom: 0.1311369084639793d,left: 0.17782508335059743d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5345614662114162d,right: 0.9646148505731231d,bottom: 0.2957513237638669d,left: 0.04163287532690674d),

new NpgsqlTypes.NpgsqlBox(top: 0.817885477904117d,right: 0.7054001374235969d,bottom: 0.2131856407186591d,left: 0.6154656566433695d),

new NpgsqlTypes.NpgsqlBox(top: 0.4318938965385146d,right: 0.8925340940003146d,bottom: 0.12326924150763285d,left: 0.2477858378137009d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3867817282963597d,right: 0.6662318033760029d,bottom: 0.2803263038116195d,left: 0.3390774891305187d),

new NpgsqlTypes.NpgsqlBox(top: 0.821135889703011d,right: 0.49780990785085333d,bottom: 0.6537870318796452d,left: 0.2488958434453502d),

new NpgsqlTypes.NpgsqlBox(top: 0.7290939137739465d,right: 0.5850331874530459d,bottom: 0.07706274373083333d,left: 0.4078081299421621d),

new NpgsqlTypes.NpgsqlBox(top: 0.3737168676781396d,right: 0.9523264282396599d,bottom: 0.03258934763108723d,left: 0.9136249742150592d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 126, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 135, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 38, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 145, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 36, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[30], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[31], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[32], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[33], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

