

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD1
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD1 : INpgsqlPolygonMArraypolygonMMArrayD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD1E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD1E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21750456715679212d, y: 0.7365460898863329d), new NpgsqlTypes.NpgsqlPoint(x: 0.09750886869679476d, y: 0.11873258441052181d), new NpgsqlTypes.NpgsqlPoint(x: 0.4166685993917808d, y: 0.26238736370749716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1793086340665364d, y: 0.1394514342351283d), new NpgsqlTypes.NpgsqlPoint(x: 0.24735825831601943d, y: 0.03525801883106683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875655574562572d, y: 0.18804403333068342d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3409992591033325d, y: 0.2590766718970142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717395947614891d, y: 0.9576703001088062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092526111294105d, y: 0.7052992531126602d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20051330092746023d, y: 0.7221395006139868d), new NpgsqlTypes.NpgsqlPoint(x: 0.746455564812203d, y: 0.6184577984931358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651447731084019d, y: 0.2752615800167041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30484697649881976d, y: 0.9078140850593547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525785061821658d, y: 0.34598306406581303d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353729378436805d, y: 0.17683084124983683d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6443786873366729d, y: 0.9338012331279834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641554361970986d, y: 0.18736391213002979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6892742289414919d, y: 0.8099369151184163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6082492918332775d, y: 0.10611643169814511d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641956976654271d, y: 0.5640083333393433d), new NpgsqlTypes.NpgsqlPoint(x: 0.032370052037450914d, y: 0.5035877614001445d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.708090102839555d, y: 0.6663561589177893d), new NpgsqlTypes.NpgsqlPoint(x: 0.04004423056419393d, y: 0.18250173491905497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382317762711545d, y: 0.2013560333084975d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19113099639856002d, y: 0.2612646948429045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230678489694008d, y: 0.9202905132320087d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335318685470016d, y: 0.2111390197604579d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4626680721476163d, y: 0.8328961619162492d), new NpgsqlTypes.NpgsqlPoint(x: 0.40095330010625363d, y: 0.0785500197832465d), new NpgsqlTypes.NpgsqlPoint(x: 0.36474995526837484d, y: 0.9164103179220077d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3678879509845401d, y: 0.40858549391830257d), new NpgsqlTypes.NpgsqlPoint(x: 0.14753514411587565d, y: 0.7310496706029199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699224231047923d, y: 0.049707115715492356d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4365709932418501d, y: 0.4104004918644757d), new NpgsqlTypes.NpgsqlPoint(x: 0.9762662567220252d, y: 0.2479751164521673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417976808487014d, y: 0.9888177320989842d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6184825649924458d, y: 0.19371052835532454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913157746470108d, y: 0.7118075171268651d), new NpgsqlTypes.NpgsqlPoint(x: 0.49595403797488635d, y: 0.30150150269361276d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8990894731545883d, y: 0.9110487250568041d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920538496863008d, y: 0.9359254080347079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047444483989396d, y: 0.13465394065037117d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22025522423795796d, y: 0.06312234298019415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850075207692579d, y: 0.6679925888950727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130136048604145d, y: 0.03472058269692235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46707550157336086d, y: 0.4663742408896717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752931740931479d, y: 0.42048455274620067d), new NpgsqlTypes.NpgsqlPoint(x: 0.30815648188734335d, y: 0.2604399303757965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.573888372051193d, y: 0.6826193732677729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249095513538604d, y: 0.26526829905007365d), new NpgsqlTypes.NpgsqlPoint(x: 0.17517110334644814d, y: 0.610042060853045d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5989655054135345d, y: 0.30025763651058146d), new NpgsqlTypes.NpgsqlPoint(x: 0.971597595916307d, y: 0.2483260986731649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252710753709912d, y: 0.45013513571120667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24018336312897748d, y: 0.20211281759127087d), new NpgsqlTypes.NpgsqlPoint(x: 0.04223187771424464d, y: 0.2190177502671612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752805597813868d, y: 0.5137548327318318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08432115598836609d, y: 0.9217730431338634d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345914839962033d, y: 0.3619318901834756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7428440868990865d, y: 0.15999465621422182d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8146710357156587d, y: 0.8471609282745187d), new NpgsqlTypes.NpgsqlPoint(x: 0.16507933658646823d, y: 0.8896462038337277d), new NpgsqlTypes.NpgsqlPoint(x: 0.24294886967910767d, y: 0.3355994168211913d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4454768079802761d, y: 0.5520138528069969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901085870884475d, y: 0.48357374738618397d), new NpgsqlTypes.NpgsqlPoint(x: 0.012079227605423681d, y: 0.8220348820523941d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9868223881740774d, y: 0.5544971262940159d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300662374519621d, y: 0.32711664097025117d), new NpgsqlTypes.NpgsqlPoint(x: 0.17189919125963693d, y: 0.15970581154245655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09372932135209211d, y: 0.666907360680829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084558058036244d, y: 0.44207199659277363d), new NpgsqlTypes.NpgsqlPoint(x: 0.941297326166466d, y: 0.046752505616151074d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8694056901267097d, y: 0.98858122098739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7914528350340352d, y: 0.03798148097824938d), new NpgsqlTypes.NpgsqlPoint(x: 0.1395736329300653d, y: 0.20796629676715173d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11883476524490655d, y: 0.9167490047531306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776520837818083d, y: 0.25500027523376856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261862691949324d, y: 0.28010112428065037d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4301432764721178d, y: 0.056039148565176d), new NpgsqlTypes.NpgsqlPoint(x: 0.15051319200536917d, y: 0.011084546752377467d), new NpgsqlTypes.NpgsqlPoint(x: 0.11160468321421868d, y: 0.14679289049532007d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8331839531934696d, y: 0.7348803674003862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363516608105312d, y: 0.5890814386811752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157327161741233d, y: 0.8632567235062985d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06482303821459234d, y: 0.586262544790362d), new NpgsqlTypes.NpgsqlPoint(x: 0.0354782150634213d, y: 0.8229876750844336d), new NpgsqlTypes.NpgsqlPoint(x: 0.07924003932862944d, y: 0.9879891894906472d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9726400673893063d, y: 0.8421740626192169d), new NpgsqlTypes.NpgsqlPoint(x: 0.37662766726190666d, y: 0.31602608340910954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5876097811908102d, y: 0.8955340226952339d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6062068242980603d, y: 0.856617262744992d), new NpgsqlTypes.NpgsqlPoint(x: 0.4959298756499737d, y: 0.8029016265933064d), new NpgsqlTypes.NpgsqlPoint(x: 0.1580633561902799d, y: 0.6119659653747873d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6088301450483993d, y: 0.8823141704755243d), new NpgsqlTypes.NpgsqlPoint(x: 0.676051539542666d, y: 0.5182183582796726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377262093498268d, y: 0.17909793756767878d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1210222578690392d, y: 0.8875520220444966d), new NpgsqlTypes.NpgsqlPoint(x: 0.42682881940170236d, y: 0.4549359093494414d), new NpgsqlTypes.NpgsqlPoint(x: 0.959528163183565d, y: 0.33921642553053766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6888430474510979d, y: 0.04716116907385093d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340672311940915d, y: 0.6702650871501703d), new NpgsqlTypes.NpgsqlPoint(x: 0.28530460468226104d, y: 0.10252889734673765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39789362007772333d, y: 0.8324407857167119d), new NpgsqlTypes.NpgsqlPoint(x: 0.06714194937877493d, y: 0.8737665382439275d), new NpgsqlTypes.NpgsqlPoint(x: 0.22913549687323398d, y: 0.026604536823141012d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8330990422682849d, y: 0.019001022196731943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5257459223317918d, y: 0.47581555728665836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3706699671712982d, y: 0.8611180545694964d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7922253057511766d, y: 0.09271433144746422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832939852200744d, y: 0.740737652905465d), new NpgsqlTypes.NpgsqlPoint(x: 0.0897089677916979d, y: 0.547885093499408d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944000693484093d, y: 0.4854378399564714d), new NpgsqlTypes.NpgsqlPoint(x: 0.06145381803989414d, y: 0.8067719693614305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004903638613422d, y: 0.7314166063782308d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210893408534168d, y: 0.37422417938767594d), new NpgsqlTypes.NpgsqlPoint(x: 0.34430782469704335d, y: 0.8855264967285711d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100203132552725d, y: 0.8483498100709761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.822308310808342d, y: 0.8083293372705016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4835295447883706d, y: 0.8337709602525407d), new NpgsqlTypes.NpgsqlPoint(x: 0.11592686514451911d, y: 0.9176046371661235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8078406541893545d, y: 0.19029138108230426d), new NpgsqlTypes.NpgsqlPoint(x: 0.017074627930657837d, y: 0.8905354170433812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469356029089574d, y: 0.2657310960906767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.333996136293527d, y: 0.5245781998410983d), new NpgsqlTypes.NpgsqlPoint(x: 0.17433742402673702d, y: 0.15699984606664297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4821497867227159d, y: 0.5256939749399675d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2750704331951923d, y: 0.5353029696842797d), new NpgsqlTypes.NpgsqlPoint(x: 0.008874786861342576d, y: 0.5744931141429662d), new NpgsqlTypes.NpgsqlPoint(x: 0.702709119231658d, y: 0.8957396242649085d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7212951654013092d, y: 0.9530468064373389d), new NpgsqlTypes.NpgsqlPoint(x: 0.3302591462503931d, y: 0.059778398124676d), new NpgsqlTypes.NpgsqlPoint(x: 0.05630856107022708d, y: 0.4885357450229566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.636682378169938d, y: 0.07198127249453157d), new NpgsqlTypes.NpgsqlPoint(x: 0.32191478119017036d, y: 0.4479664644954088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1175141829545443d, y: 0.9401596386202709d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017230891108391044d, y: 0.1743635756501799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147407867655735d, y: 0.6236237692683181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468102410694766d, y: 0.6826281016102236d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7368077701325751d, y: 0.7419514262429241d), new NpgsqlTypes.NpgsqlPoint(x: 0.26409351742831666d, y: 0.9683733143598146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285761012150749d, y: 0.3061990415014504d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6068991628245887d, y: 0.21823574201675033d), new NpgsqlTypes.NpgsqlPoint(x: 0.09329601446704228d, y: 0.5266488943378883d), new NpgsqlTypes.NpgsqlPoint(x: 0.29982181018090015d, y: 0.053642854621961944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5592100422160057d, y: 0.8350141596307329d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238601102846461d, y: 0.48643841310061575d), new NpgsqlTypes.NpgsqlPoint(x: 0.970599527128731d, y: 0.8436883075727636d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17575058906637875d, y: 0.3648452653768809d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690507851663083d, y: 0.5330929155255864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294707570797666d, y: 0.05472509025099359d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024691012171226934d, y: 0.21749671290859007d), new NpgsqlTypes.NpgsqlPoint(x: 0.10627656720825018d, y: 0.4240754909322044d), new NpgsqlTypes.NpgsqlPoint(x: 0.42199873061815985d, y: 0.5191893932838895d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36426066887346d, y: 0.9819712475449167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784450809570579d, y: 0.7334031562965087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4152070804722815d, y: 0.4580503574374456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08610814219498508d, y: 7.997783215707432E-05d), new NpgsqlTypes.NpgsqlPoint(x: 0.39726055946565597d, y: 0.5491448953617819d), new NpgsqlTypes.NpgsqlPoint(x: 0.19509789811133882d, y: 0.6431639540204959d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8212669647751658d, y: 0.19875979026521295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113426427844603d, y: 0.7659536416803326d), new NpgsqlTypes.NpgsqlPoint(x: 0.693268669492606d, y: 0.9084596984675773d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7589680096957533d, y: 0.7272498893189925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214718237880132d, y: 0.3286445422696206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187416700759056d, y: 0.9029220155569637d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16403201876103346d, y: 0.926586749351787d), new NpgsqlTypes.NpgsqlPoint(x: 0.09246120773918498d, y: 0.5517563530126545d), new NpgsqlTypes.NpgsqlPoint(x: 0.4275257766271582d, y: 0.23556228896849896d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.570229624494673d, y: 0.24698365212916884d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767525199140147d, y: 0.7719819917068322d), new NpgsqlTypes.NpgsqlPoint(x: 0.38024216864432636d, y: 0.11016946483967993d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8534709730924174d, y: 0.7544495030132418d), new NpgsqlTypes.NpgsqlPoint(x: 0.39389012819892677d, y: 0.9870068722444676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275050355305602d, y: 0.24730795288584828d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04124263428676389d, y: 0.41891000869230544d), new NpgsqlTypes.NpgsqlPoint(x: 0.23855118458459024d, y: 0.15929660839379445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370178935792283d, y: 0.7046444298875572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296541211719049d, y: 0.3027486874386893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805530207930806d, y: 0.33155330012191264d), new NpgsqlTypes.NpgsqlPoint(x: 0.09814185497021466d, y: 0.4371388421391713d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41431776946693444d, y: 0.7411513254031972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661322357630554d, y: 0.2830196107393731d), new NpgsqlTypes.NpgsqlPoint(x: 0.48631142499405555d, y: 0.8359917310634217d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.758895125256087d, y: 0.5214355634240394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076148065815393d, y: 0.4777265803646328d), new NpgsqlTypes.NpgsqlPoint(x: 0.677563525588289d, y: 0.2523310006113657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735171933643842d, y: 0.10808552261148763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443354829249853d, y: 0.6751113957286465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852293058994346d, y: 0.3462470458172662d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6842689279590256d, y: 0.10731311187193915d), new NpgsqlTypes.NpgsqlPoint(x: 0.24783012808196747d, y: 0.245720579787983d), new NpgsqlTypes.NpgsqlPoint(x: 0.26073213590250044d, y: 0.9530672536121063d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9882931460378978d, y: 0.22513299988706548d), new NpgsqlTypes.NpgsqlPoint(x: 0.44878170214272883d, y: 0.377799922582007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7286064619410648d, y: 0.8013885035427759d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2823043608286677d, y: 0.8087127363417743d), new NpgsqlTypes.NpgsqlPoint(x: 0.46718262967071555d, y: 0.6857092305973057d), new NpgsqlTypes.NpgsqlPoint(x: 0.48115538465013064d, y: 0.7476914730696281d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5446109496074238d, y: 0.9844340214514927d), new NpgsqlTypes.NpgsqlPoint(x: 0.637071459643076d, y: 0.3737944759674142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774055501279854d, y: 0.8371057676600981d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7214558219624825d, y: 0.3975010081854474d), new NpgsqlTypes.NpgsqlPoint(x: 0.2737807068285071d, y: 0.542309582011844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236752441417032d, y: 0.6724447325577443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30041128658346017d, y: 0.6965903800980712d), new NpgsqlTypes.NpgsqlPoint(x: 0.3970046428352987d, y: 0.12440971504250009d), new NpgsqlTypes.NpgsqlPoint(x: 0.19332402572885476d, y: 0.49985667866906514d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8061699752494669d, y: 0.503226199936915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912871795279295d, y: 0.3746991765337483d), new NpgsqlTypes.NpgsqlPoint(x: 0.557080271008978d, y: 0.5555621462780178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.670138747499679d, y: 0.32518761042122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001576219515215d, y: 0.4652854266549842d), new NpgsqlTypes.NpgsqlPoint(x: 0.36002406916303953d, y: 0.6030782122378041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1032280069679512d, y: 0.43530398224886857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9361948065985709d, y: 0.19020529841857337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853451698547271d, y: 0.9018303412057352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39877667268778605d, y: 0.9922624536090561d), new NpgsqlTypes.NpgsqlPoint(x: 0.10945308244295704d, y: 0.9756983928558216d), new NpgsqlTypes.NpgsqlPoint(x: 0.35554520161840364d, y: 0.2680618640511381d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21656310665115674d, y: 0.4240650272362312d), new NpgsqlTypes.NpgsqlPoint(x: 0.12484448128612458d, y: 0.6757521594176998d), new NpgsqlTypes.NpgsqlPoint(x: 0.15966646898724302d, y: 0.3243609303820748d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8010257661757741d, y: 0.5420272041200436d), new NpgsqlTypes.NpgsqlPoint(x: 0.027944275334547353d, y: 0.9321802498991175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097603442740465d, y: 0.38143722448781003d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6902988793331758d, y: 0.47771269574083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018874139971621d, y: 0.4417813715824662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16521993309314031d, y: 0.2245759197133742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8086150657653409d, y: 0.32775676906051954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482492891134499d, y: 0.30312771917927606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4211059892484458d, y: 0.17141289830358264d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7266486701379274d, y: 0.5941030587712834d), new NpgsqlTypes.NpgsqlPoint(x: 0.41421991457177787d, y: 0.7082145828669462d), new NpgsqlTypes.NpgsqlPoint(x: 0.0527527603152228d, y: 0.8954663294465256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5551237625980963d, y: 0.8471969393090267d), new NpgsqlTypes.NpgsqlPoint(x: 0.536269833703203d, y: 0.7099799227119672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334556619710035d, y: 0.19641542095091635d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16916667134229568d, y: 0.2335576325382943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255021333460148d, y: 0.9724429019939385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915739179056837d, y: 0.39943835061147404d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5027203708429477d, y: 0.9797778650894425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757409139652134d, y: 0.23021088207026397d), new NpgsqlTypes.NpgsqlPoint(x: 0.03665100477528804d, y: 0.09564081259403379d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44445104258731816d, y: 0.5706190208022529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2955437308952087d, y: 0.682068864214903d), new NpgsqlTypes.NpgsqlPoint(x: 0.19474546577816787d, y: 0.4474161950967751d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47840254822126504d, y: 0.22077985713730608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4165430205105267d, y: 0.6803397610323414d), new NpgsqlTypes.NpgsqlPoint(x: 0.23658168421987247d, y: 0.9596800759159017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27818685789099495d, y: 0.08318697457829205d), new NpgsqlTypes.NpgsqlPoint(x: 0.46169000485847156d, y: 0.8963851631477605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415644637789885d, y: 0.5247554987967927d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6221839451415752d, y: 0.2354007822979508d), new NpgsqlTypes.NpgsqlPoint(x: 0.802789982905374d, y: 0.33290327593185765d), new NpgsqlTypes.NpgsqlPoint(x: 0.46871660061225695d, y: 0.6231868860525897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8800795167129855d, y: 0.11717871012657366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703585670559071d, y: 0.02525467199909448d), new NpgsqlTypes.NpgsqlPoint(x: 0.348073833874061d, y: 0.3130717533911408d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9959652733052767d, y: 0.6944457451775204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291121762889933d, y: 0.7343155058436267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681793012231134d, y: 0.02129387926934012d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3401573285310443d, y: 0.5592480303038456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217769768067403d, y: 0.8774312830943884d), new NpgsqlTypes.NpgsqlPoint(x: 0.859478850091816d, y: 0.01598646332235354d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9039126262470072d, y: 0.03715372240135406d), new NpgsqlTypes.NpgsqlPoint(x: 0.22152597841200072d, y: 0.7367714748930448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094803115476852d, y: 0.9460108271579052d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47259586545219934d, y: 0.9396142533746394d), new NpgsqlTypes.NpgsqlPoint(x: 0.15217526851243868d, y: 0.7638262783131246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159324012739939d, y: 0.39336857589678376d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48453419273649734d, y: 0.7083357467718239d), new NpgsqlTypes.NpgsqlPoint(x: 0.1260531767737335d, y: 0.9887437087346118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556526703490531d, y: 0.5577460294656587d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8013888185791681d, y: 0.5763073320132057d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364789459291098d, y: 0.590127135420878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796090220624778d, y: 0.9331506654646315d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9682004086801065d, y: 0.7916703486855939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377846763341873d, y: 0.5127931905823152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387532628084857d, y: 0.008873290613585882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3570422965825236d, y: 0.6698540944574013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079643735280176d, y: 0.35497936086647874d), new NpgsqlTypes.NpgsqlPoint(x: 0.769589704651499d, y: 0.500130991510733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.055718247126360865d, y: 0.7803575141441408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289763467384109d, y: 0.12525162170043858d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186346225645641d, y: 0.8061860476907781d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6588022050331346d, y: 0.33385500494633014d), new NpgsqlTypes.NpgsqlPoint(x: 0.822437514743039d, y: 0.013472267413610628d), new NpgsqlTypes.NpgsqlPoint(x: 0.877030331540027d, y: 0.16692336395796348d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4717318761903606d, y: 0.7920469319962965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367268697301392d, y: 0.6707089377464531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540323599407517d, y: 0.2500029635692711d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5897577804320049d, y: 0.36462047723816327d), new NpgsqlTypes.NpgsqlPoint(x: 0.17425819587920566d, y: 0.06940061692481836d), new NpgsqlTypes.NpgsqlPoint(x: 0.565151565895414d, y: 0.7755820236357117d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5961389916187988d, y: 0.30953524474852867d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382431169622053d, y: 0.7227847410643297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111473297207886d, y: 0.37567721485755d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9357049779698124d, y: 0.4711423465648946d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793048330981611d, y: 0.47990210403983724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197112569082833d, y: 0.5528404178008385d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2118439473114445d, y: 0.04187076584451077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376217436514295d, y: 0.30177684589222475d), new NpgsqlTypes.NpgsqlPoint(x: 0.3996531681445513d, y: 0.7707604203913334d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145173436535831d, y: 0.9235170603927589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7914067177677441d, y: 0.8227451815159823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9546189114010681d, y: 0.7409931895999051d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9272609448024142d, y: 0.07161965024422934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977483094107384d, y: 0.07797093086431228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173887042381965d, y: 0.2762587990962174d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17443565613147727d, y: 0.745394808316154d), new NpgsqlTypes.NpgsqlPoint(x: 0.1429059474693738d, y: 0.2712541419379626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928195894605163d, y: 0.15919727195129207d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5368193502207845d, y: 0.8418925625962577d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073816415019256d, y: 0.22900310903326426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5660357732480743d, y: 0.7050328221299242d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5692214958582175d, y: 0.3554003443765368d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295116994417837d, y: 0.5650763525675109d), new NpgsqlTypes.NpgsqlPoint(x: 0.1625201493057561d, y: 0.7090188087819215d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36696598791020774d, y: 0.7448350745400723d), new NpgsqlTypes.NpgsqlPoint(x: 0.43943857454606816d, y: 0.07352782566689064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819409376391839d, y: 0.19875055616485893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839648361069974d, y: 0.8669549682866905d), new NpgsqlTypes.NpgsqlPoint(x: 0.40902263239195447d, y: 0.5067885704486922d), new NpgsqlTypes.NpgsqlPoint(x: 0.12368419349914539d, y: 0.021284866350726572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052293697866730326d, y: 0.9558023690469973d), new NpgsqlTypes.NpgsqlPoint(x: 0.04241368864000694d, y: 0.5763383493213561d), new NpgsqlTypes.NpgsqlPoint(x: 0.38377689941085236d, y: 0.6702007351328273d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5177194529467295d, y: 0.16853714153527055d), new NpgsqlTypes.NpgsqlPoint(x: 0.10578446879352821d, y: 0.318286606609256d), new NpgsqlTypes.NpgsqlPoint(x: 0.776329286611397d, y: 0.5680156083713714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08130250894580582d, y: 0.1821052743882845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356878552931556d, y: 0.9368943660647674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132154235712976d, y: 0.3142720616486844d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18995650474939085d, y: 0.670950687548226d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019569093293369d, y: 0.48636328934856765d), new NpgsqlTypes.NpgsqlPoint(x: 0.2063356859618083d, y: 0.8946990008586572d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03922982026878519d, y: 0.9560298757156979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3989624241652947d, y: 0.001420384893736526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9522055563647993d, y: 0.5242046090869926d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8938334658518625d, y: 0.2181441580074508d), new NpgsqlTypes.NpgsqlPoint(x: 0.4221292255345127d, y: 0.004134084914699132d), new NpgsqlTypes.NpgsqlPoint(x: 0.26234683498627476d, y: 0.9985741653160844d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00513057384966864d, y: 0.279275216500405d), new NpgsqlTypes.NpgsqlPoint(x: 0.013069744269895489d, y: 0.24212237241872248d), new NpgsqlTypes.NpgsqlPoint(x: 0.0990006541708014d, y: 0.3928890738275237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2704777403024493d, y: 0.5848268369619907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034653490012808d, y: 0.1673824956622807d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597149201885034d, y: 0.5868526368891687d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7272856435482332d, y: 0.5420825898284144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274002000008541d, y: 0.3091337591319291d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535233989795569d, y: 0.6857893747745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3736726033519986d, y: 0.500501452805909d), new NpgsqlTypes.NpgsqlPoint(x: 0.12976759982430786d, y: 0.3696030237333445d), new NpgsqlTypes.NpgsqlPoint(x: 0.31512814960774216d, y: 0.6585872079180302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38330696745413695d, y: 0.21931746850364842d), new NpgsqlTypes.NpgsqlPoint(x: 0.06879567593343516d, y: 0.48939405550837334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287719306398815d, y: 0.09154744941383008d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7495738598676679d, y: 0.3664880480005195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179164468290308d, y: 0.31711946365857513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651787264606434d, y: 0.3434646148754844d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5306055590669452d, y: 0.34635826732284813d), new NpgsqlTypes.NpgsqlPoint(x: 0.1059671622284748d, y: 0.5396596466245924d), new NpgsqlTypes.NpgsqlPoint(x: 0.029188532840951686d, y: 0.4885688624542309d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413045817044531d, y: 0.8879933790782084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156131099438046d, y: 0.3564917618881367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050025900219228d, y: 0.2971066983450743d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8491883549600908d, y: 0.4393823086859602d), new NpgsqlTypes.NpgsqlPoint(x: 0.40162289912364635d, y: 0.08799337152816455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652439090271791d, y: 0.49366748571899577d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716132481885128d, y: 0.4545976778364119d), new NpgsqlTypes.NpgsqlPoint(x: 0.08347041824701906d, y: 0.4011958476337799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7452696509375304d, y: 0.9664510207730893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43079602510830295d, y: 0.3169791633205101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031713708851995d, y: 0.518247599394585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427978056191059d, y: 0.36825616175364173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4150113378083711d, y: 0.8308522173058334d), new NpgsqlTypes.NpgsqlPoint(x: 0.45527465042445325d, y: 0.42562316047007354d), new NpgsqlTypes.NpgsqlPoint(x: 0.16150024610044356d, y: 0.33289241966852656d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35381157725952483d, y: 0.7116907037162327d), new NpgsqlTypes.NpgsqlPoint(x: 0.2565677766705985d, y: 0.7229379072774291d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663495504408758d, y: 0.13691157631355866d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40044246835630937d, y: 0.585156742950244d), new NpgsqlTypes.NpgsqlPoint(x: 0.13793479905557626d, y: 0.2950707205668901d), new NpgsqlTypes.NpgsqlPoint(x: 0.05986247132175271d, y: 0.0026951658487137653d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49060075521814683d, y: 0.9215235217865411d), new NpgsqlTypes.NpgsqlPoint(x: 0.026921500224626138d, y: 0.26862624116945977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989897557107474d, y: 0.8683103814835552d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27844864225769417d, y: 0.3592360392511289d), new NpgsqlTypes.NpgsqlPoint(x: 0.27351704462679116d, y: 0.6779842423932854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668465551722865d, y: 0.26109399966681357d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5231896578164075d, y: 0.7562435702311727d), new NpgsqlTypes.NpgsqlPoint(x: 0.07900232478430314d, y: 0.09751758743221373d), new NpgsqlTypes.NpgsqlPoint(x: 0.10505274089862249d, y: 0.9434751580996789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3714816610538779d, y: 0.30258928467819235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117829819057499d, y: 0.20002231581593743d), new NpgsqlTypes.NpgsqlPoint(x: 0.02878863192991843d, y: 0.8887794789685893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030947727387351298d, y: 0.11141731305965785d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039484901752243d, y: 0.07692655532853665d), new NpgsqlTypes.NpgsqlPoint(x: 0.13249781872424737d, y: 0.8770417442111863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6919797342575916d, y: 0.6765328472765227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500986892594292d, y: 0.060305971818420234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032736128306314d, y: 0.34267966454945153d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.677029841998157d, y: 0.7749624725982904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4200052979314205d, y: 0.3046245091631219d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390430055270963d, y: 0.8199530449279351d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40591552658752383d, y: 0.684116525657489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611550279113549d, y: 0.9029261572756947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106502183046713d, y: 0.9655049920751256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.711402997773129d, y: 0.07926656903060314d), new NpgsqlTypes.NpgsqlPoint(x: 0.2384392256357193d, y: 0.42702905150241177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4516513339603956d, y: 0.5740845832268704d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6164788820798383d, y: 0.5844683877292801d), new NpgsqlTypes.NpgsqlPoint(x: 0.14783406459151527d, y: 0.9524022945662004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212982014247086d, y: 0.8063242004389989d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2499367383228125d, y: 0.3550580440798281d), new NpgsqlTypes.NpgsqlPoint(x: 0.33067417991387127d, y: 0.30143311366698256d), new NpgsqlTypes.NpgsqlPoint(x: 0.013639733398575271d, y: 0.474998365581238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37660755511758603d, y: 0.5338380498169181d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041523539368902d, y: 0.6522483030227249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459457589824156d, y: 0.8115106525643663d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9942605043765235d, y: 0.5498088028716506d), new NpgsqlTypes.NpgsqlPoint(x: 0.44953648249311584d, y: 0.47551248249397027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415464957240059d, y: 0.8337085306503174d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7506689370126356d, y: 0.6474723395575201d), new NpgsqlTypes.NpgsqlPoint(x: 0.763275382853401d, y: 0.18071090418065128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068816555309235d, y: 0.7881690100752038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43580666199170504d, y: 0.10788914650287729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496644609061708d, y: 0.8415877812243623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5802567864056202d, y: 0.44581026065760765d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05147018537669479d, y: 0.5960808252435945d), new NpgsqlTypes.NpgsqlPoint(x: 0.04202998186840401d, y: 0.13651513787545888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3132126052309966d, y: 0.009348555003368397d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3739283309642578d, y: 0.33540152246559074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114136442620777d, y: 0.03833133673712752d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547143503504406d, y: 0.6644391441033202d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8314854089601689d, y: 0.3023546833126579d), new NpgsqlTypes.NpgsqlPoint(x: 0.1213493802543456d, y: 0.6711281740127434d), new NpgsqlTypes.NpgsqlPoint(x: 0.10938130170291305d, y: 0.7945587770096825d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6289263072486195d, y: 0.6111340413936532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662793058662129d, y: 0.4465203475784244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584937308127024d, y: 0.4870856354813171d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9059212404174548d, y: 0.31186738278207005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9511034540103674d, y: 0.48518284651427035d), new NpgsqlTypes.NpgsqlPoint(x: 0.4233716803031531d, y: 0.6018304922539046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6211799802790141d, y: 0.9577157924610432d), new NpgsqlTypes.NpgsqlPoint(x: 0.353702048058095d, y: 0.9353833192614162d), new NpgsqlTypes.NpgsqlPoint(x: 0.45945261427048756d, y: 0.0584938908727024d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7876597800514052d, y: 0.1568462135824248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351709990883984d, y: 0.012558769648661094d), new NpgsqlTypes.NpgsqlPoint(x: 0.43927081627024134d, y: 0.2475883335918846d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18174450934410646d, y: 0.2913175599667681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528368424538528d, y: 0.06943874926086713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311085554474924d, y: 0.07005968283070563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2942374981878215d, y: 0.7268112454258797d), new NpgsqlTypes.NpgsqlPoint(x: 0.428954366609705d, y: 0.22435437829993543d), new NpgsqlTypes.NpgsqlPoint(x: 0.189266887511228d, y: 0.5271044345260988d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8039772574027152d, y: 0.5961287941606629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722724959622979d, y: 0.4028304240353765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112417072642174d, y: 0.21147996915177836d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8840239412939196d, y: 0.8548701008103937d), new NpgsqlTypes.NpgsqlPoint(x: 0.922086621325976d, y: 0.4456925842256074d), new NpgsqlTypes.NpgsqlPoint(x: 0.583956145418545d, y: 0.4823519476287186d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4396408802949473d, y: 0.11770485590540869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6158627905933294d, y: 0.8373802562073064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502757596902437d, y: 0.3877899938841538d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6921371389420732d, y: 0.22819675097777492d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045553792391568d, y: 0.24862650809194842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781520230869606d, y: 0.8511889187336648d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9112907137079774d, y: 0.860602541684751d), new NpgsqlTypes.NpgsqlPoint(x: 0.46785606636613264d, y: 0.4293151972986857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024845459804693d, y: 0.63492475149589d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9471669904877928d, y: 0.6686462492735804d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792952351374407d, y: 0.25038565509807453d), new NpgsqlTypes.NpgsqlPoint(x: 0.34370677072676226d, y: 0.4425423552460406d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2598518898520731d, y: 0.5164326567920651d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877471963859271d, y: 0.7014900247301222d), new NpgsqlTypes.NpgsqlPoint(x: 0.813940159031497d, y: 0.49419147412357534d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12795507992149813d, y: 0.4552997886586886d), new NpgsqlTypes.NpgsqlPoint(x: 0.822895795898164d, y: 0.15627448772429808d), new NpgsqlTypes.NpgsqlPoint(x: 0.47284691544219337d, y: 0.6988584895297543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9649471180271586d, y: 0.23687322682209733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752856667675503d, y: 0.8353194857272132d), new NpgsqlTypes.NpgsqlPoint(x: 0.01773381208442415d, y: 0.3792114733601387d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7632717798833978d, y: 0.9614460982863584d), new NpgsqlTypes.NpgsqlPoint(x: 0.20784174693553392d, y: 0.0010377013770741517d), new NpgsqlTypes.NpgsqlPoint(x: 0.21046145410632922d, y: 0.18507199179315692d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45633548270413704d, y: 0.7683693701005562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4766441797447034d, y: 0.0009432034440818304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8708185034995294d, y: 0.4288335775937503d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9053340316994195d, y: 0.27536211425165835d), new NpgsqlTypes.NpgsqlPoint(x: 0.33999819523790575d, y: 0.41999429186043447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552378082939305d, y: 0.6031795089215102d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7858234450761126d, y: 0.29422035939447355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013041460464557d, y: 0.2302665715370673d), new NpgsqlTypes.NpgsqlPoint(x: 0.43583547486601537d, y: 0.6073931408374486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4542410898251428d, y: 0.825663373407878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5011163225371223d, y: 0.16237297561149422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087522888799511d, y: 0.5934020170592016d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8967416133377204d, y: 0.9619379883594634d), new NpgsqlTypes.NpgsqlPoint(x: 0.4923033872707365d, y: 0.10038792897828508d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481668844859582d, y: 0.7208452724176772d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6179807229611535d, y: 0.661771230120819d), new NpgsqlTypes.NpgsqlPoint(x: 0.4592485940052846d, y: 0.9476097113959069d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931289098287548d, y: 0.26957396032674785d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5568276804467208d, y: 0.7424644818556374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3786064642541538d, y: 0.996953209710186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7402120043132138d, y: 0.45782784315575176d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36797024152596336d, y: 0.8222833627592883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590289262117877d, y: 0.3216069106935945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615697277679008d, y: 0.7700235033435248d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6872098407915794d, y: 0.07944592969000275d), new NpgsqlTypes.NpgsqlPoint(x: 0.21105166787519303d, y: 0.6808743003898436d), new NpgsqlTypes.NpgsqlPoint(x: 0.933106436624069d, y: 0.09105046235137038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2729634531045737d, y: 0.2487025767813873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068487015661826d, y: 0.32320418993004596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478528677051959d, y: 0.7395730536519232d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38173843504766314d, y: 0.32554338868214006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571893845174027d, y: 0.7268233282301176d), new NpgsqlTypes.NpgsqlPoint(x: 0.33902893853137084d, y: 0.6743031560454782d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167274677262752d, y: 0.4883509471505134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2300739386272711d, y: 0.13777938055277772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608384243434006d, y: 0.1306430243762231d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24969161783123472d, y: 0.5092685153649192d), new NpgsqlTypes.NpgsqlPoint(x: 0.2827946924120802d, y: 0.6067587401308169d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697026260758461d, y: 0.914794296492503d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9008665001425857d, y: 0.9960915545626263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859411564943963d, y: 0.30236747629033345d), new NpgsqlTypes.NpgsqlPoint(x: 0.23203911403569988d, y: 0.48529128216632433d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2845457585810912d, y: 0.9860608888526207d), new NpgsqlTypes.NpgsqlPoint(x: 0.753716052834043d, y: 0.929616228684331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553349375080306d, y: 0.30283725570275255d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8159410218479435d, y: 0.7504369062033541d), new NpgsqlTypes.NpgsqlPoint(x: 0.04596046072240312d, y: 0.4757406359250004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725081571560508d, y: 0.2797491425605849d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43353933308973336d, y: 0.9739587096627523d), new NpgsqlTypes.NpgsqlPoint(x: 0.34680412638604197d, y: 0.9783208075839973d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718063447402649d, y: 0.9528768677063824d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9698965788028955d, y: 0.6812020223978998d), new NpgsqlTypes.NpgsqlPoint(x: 0.701755459219695d, y: 0.6566489998452687d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785941432481823d, y: 0.8305883094922084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580757857610152d, y: 0.7146689997273505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910226927171053d, y: 0.8803338638479714d), new NpgsqlTypes.NpgsqlPoint(x: 0.03548058257249165d, y: 0.6199818545773799d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36289150210553356d, y: 0.7110159420540695d), new NpgsqlTypes.NpgsqlPoint(x: 0.41823191487470923d, y: 0.4174086024320337d), new NpgsqlTypes.NpgsqlPoint(x: 0.48692026448234516d, y: 0.18679033125004751d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3919182353277718d, y: 0.5430246483332613d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209543588584886d, y: 0.7237786202680181d), new NpgsqlTypes.NpgsqlPoint(x: 0.057883346570959726d, y: 0.09444992062619773d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8852980326285438d, y: 0.33531317281274775d), new NpgsqlTypes.NpgsqlPoint(x: 0.4551281860983514d, y: 0.23165537932529368d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183693294624354d, y: 0.9916489572237513d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8630193264489502d, y: 0.146839516534788d), new NpgsqlTypes.NpgsqlPoint(x: 0.221007306309575d, y: 0.5787740111345822d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614218320428657d, y: 0.2519131528467632d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.875449858793174d, y: 0.09456654677440868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237125670307528d, y: 0.15227497015706948d), new NpgsqlTypes.NpgsqlPoint(x: 0.04669334362361188d, y: 0.14359935920219002d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8144176452707114d, y: 0.5877129246082019d), new NpgsqlTypes.NpgsqlPoint(x: 0.39109471417402d, y: 0.7165708908947412d), new NpgsqlTypes.NpgsqlPoint(x: 0.48031685991457373d, y: 0.6681231089093843d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8493768250970356d, y: 0.4432295840714786d), new NpgsqlTypes.NpgsqlPoint(x: 0.33707290938245527d, y: 0.1982383666028671d), new NpgsqlTypes.NpgsqlPoint(x: 0.914027471610002d, y: 0.15759013258327415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30064540657065963d, y: 0.5859196480177423d), new NpgsqlTypes.NpgsqlPoint(x: 0.0361439575537168d, y: 0.40779855230402084d), new NpgsqlTypes.NpgsqlPoint(x: 0.05947943989248472d, y: 0.708734012612347d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6837387663696048d, y: 0.7337948194298386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536678579620587d, y: 0.3602334447103067d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845615342187148d, y: 0.547595970339615d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4664189221501729d, y: 0.28160412119644584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608942452283319d, y: 0.05165624008282077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129083401078669d, y: 0.9927053421192625d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6942977341970623d, y: 0.9497072809951808d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917440578018616d, y: 0.8682043319321068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457442134372017d, y: 0.5546513473379906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5297160522032226d, y: 0.8769731113920609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059369782124116d, y: 0.8096287973352656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666688837408415d, y: 0.2651737395572117d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7290176969335079d, y: 0.07326975546569015d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289367651688144d, y: 0.08096307090557353d), new NpgsqlTypes.NpgsqlPoint(x: 0.1439923570606777d, y: 0.7064609235872008d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6035578738197805d, y: 0.1592370733358921d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202049207994225d, y: 0.8145804272403626d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732563587139997d, y: 0.43717359489039453d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6337639678873926d, y: 0.10815099841177134d), new NpgsqlTypes.NpgsqlPoint(x: 0.28885569174215886d, y: 0.5756827869648689d), new NpgsqlTypes.NpgsqlPoint(x: 0.1392359383208186d, y: 0.8223506112534498d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45482016251729473d, y: 0.181851008450153d), new NpgsqlTypes.NpgsqlPoint(x: 0.33733872428693623d, y: 0.9866404758131675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728792655955686d, y: 0.8261234912854101d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46547581780048d, y: 0.3875319518973819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8954625211110891d, y: 0.4050337590409435d), new NpgsqlTypes.NpgsqlPoint(x: 0.14689087759674757d, y: 0.6157296639834741d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45062413937723766d, y: 0.9826529470935315d), new NpgsqlTypes.NpgsqlPoint(x: 0.42546593130174715d, y: 0.8756639387190994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6432786964205673d, y: 0.7361596518961008d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8483707967759164d, y: 0.17226923539430772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861950535337167d, y: 0.7900345059472674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272131244435863d, y: 0.5419311013943259d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7220788500235634d, y: 0.5594795495992823d), new NpgsqlTypes.NpgsqlPoint(x: 0.61988410644364d, y: 0.2560530397184555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862959781619123d, y: 0.3430820742998564d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9207534934416991d, y: 0.4598987300303581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145309247882369d, y: 0.20435835572745165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6056488273851734d, y: 0.5955389222987759d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15235021474087052d, y: 0.42391991742463486d), new NpgsqlTypes.NpgsqlPoint(x: 0.18305002318045738d, y: 0.18980324849641894d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688512030919564d, y: 0.3379224211343307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.325024196090249d, y: 0.01466040614509212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955267072459743d, y: 0.4013989397761264d), new NpgsqlTypes.NpgsqlPoint(x: 0.15781872863191926d, y: 0.26797528333951326d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3864840059326221d, y: 0.4519470555225774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556848963860314d, y: 0.6854549019115891d), new NpgsqlTypes.NpgsqlPoint(x: 0.41821096946654956d, y: 0.9888282349031147d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11788863363320445d, y: 0.8220283814814113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224502488378269d, y: 0.5247724664234724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1121467605107267d, y: 0.9904573424754135d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3234437658422412d, y: 0.30268190835656783d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415900382965008d, y: 0.6923608183406097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538290324835487d, y: 0.9255198296588869d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9396167622784347d, y: 0.7800908090226027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049350416280567d, y: 0.6900342610866647d), new NpgsqlTypes.NpgsqlPoint(x: 0.16060858675198852d, y: 0.28212937907753555d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7126029998999757d, y: 0.727482393523018d), new NpgsqlTypes.NpgsqlPoint(x: 0.07287592541553778d, y: 0.6759513207681638d), new NpgsqlTypes.NpgsqlPoint(x: 0.4228397057525556d, y: 0.5561508439468025d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5000093754862734d, y: 0.4510043467180327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081660659993714d, y: 0.062372129455571024d), new NpgsqlTypes.NpgsqlPoint(x: 0.22237971594523398d, y: 0.9030939030576218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1905842996052758d, y: 0.39209271487726405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097466299058673d, y: 0.7122275055148031d), new NpgsqlTypes.NpgsqlPoint(x: 0.8321935175854656d, y: 0.6780669535851963d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5524289100285242d, y: 0.6401163881276948d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390533716946804d, y: 0.7320113688372847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228349612194106d, y: 0.6613708128547168d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756341646527054d, y: 0.1314827310492246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830472063322371d, y: 0.619728248883175d), new NpgsqlTypes.NpgsqlPoint(x: 0.022636907500399595d, y: 0.8167618458982959d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3032603333506748d, y: 0.4675158946118253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971951850937424d, y: 0.07573038965771162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3657135795051357d, y: 0.6410359428488832d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3021756515724642d, y: 0.17785863439963168d), new NpgsqlTypes.NpgsqlPoint(x: 0.4439397323725307d, y: 0.31856496912961185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026473004532662d, y: 0.5039654007355454d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002250651305634288d, y: 0.44547633322901603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792312956168634d, y: 0.23953183257477995d), new NpgsqlTypes.NpgsqlPoint(x: 0.31057767906963496d, y: 0.6389090819728577d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9605251035711061d, y: 0.48806411821912354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3997748787253862d, y: 0.23250587289512614d), new NpgsqlTypes.NpgsqlPoint(x: 0.07181204661262552d, y: 0.09229309876769054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6463640829253269d, y: 0.8315157594803327d), new NpgsqlTypes.NpgsqlPoint(x: 0.44735722576321313d, y: 0.6854361802850972d), new NpgsqlTypes.NpgsqlPoint(x: 0.09256877953779685d, y: 0.14059577355502506d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7822997244458642d, y: 0.5251038822324703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992529399945907d, y: 0.8788650413962703d), new NpgsqlTypes.NpgsqlPoint(x: 0.09816414124847095d, y: 0.4236701583128144d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5311440226823514d, y: 0.10029458781564504d), new NpgsqlTypes.NpgsqlPoint(x: 0.23715332573441417d, y: 0.849584221803307d), new NpgsqlTypes.NpgsqlPoint(x: 0.023912962375118307d, y: 0.26015547887441315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6774161387729198d, y: 0.023570861974498314d), new NpgsqlTypes.NpgsqlPoint(x: 0.12124832908347871d, y: 0.8797937667303012d), new NpgsqlTypes.NpgsqlPoint(x: 0.40367242470770437d, y: 0.8881525990570817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09692354511544765d, y: 0.18295282972573268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411244755734343d, y: 0.6101175740864689d), new NpgsqlTypes.NpgsqlPoint(x: 0.3010252809734645d, y: 0.8776155724574993d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2553649851801869d, y: 0.7301363304270437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616204137401698d, y: 0.12739835732060467d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836143451411506d, y: 0.5996645655024659d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9265271617348262d, y: 0.4449683938731587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390753772539654d, y: 0.58607730916045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573140374150874d, y: 0.8300007407468696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4435985333816288d, y: 0.2627588939758658d), new NpgsqlTypes.NpgsqlPoint(x: 0.6487458283577073d, y: 0.5023856532979619d), new NpgsqlTypes.NpgsqlPoint(x: 0.20227358197066192d, y: 0.3823272521302328d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.511491255877165d, y: 0.16023480150543212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690068330848865d, y: 0.26876352638108314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380743211815988d, y: 0.8998127535760325d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3597326389805515d, y: 0.2053149269813902d), new NpgsqlTypes.NpgsqlPoint(x: 0.18093343257481886d, y: 0.9636989902719519d), new NpgsqlTypes.NpgsqlPoint(x: 0.08371109088748352d, y: 0.056215689586306294d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6457823781318497d, y: 0.933864558237431d), new NpgsqlTypes.NpgsqlPoint(x: 0.3288405242439717d, y: 0.2704940547131912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2861874159177754d, y: 0.977100684298623d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5555113162167469d, y: 0.36311296092650336d), new NpgsqlTypes.NpgsqlPoint(x: 0.29732427670445327d, y: 0.9639073380908512d), new NpgsqlTypes.NpgsqlPoint(x: 0.09023482381953607d, y: 0.010159165044793417d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42562417484844894d, y: 0.24218297901239982d), new NpgsqlTypes.NpgsqlPoint(x: 0.48663120713855035d, y: 0.6327723204008929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346020239920404d, y: 0.5779981085725003d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7385268564653487d, y: 0.31036751506382887d), new NpgsqlTypes.NpgsqlPoint(x: 0.10944727727982762d, y: 0.3786606794753651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3843986097270642d, y: 0.1113729805301833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4447220375012134d, y: 0.43218123508493655d), new NpgsqlTypes.NpgsqlPoint(x: 0.631673385188788d, y: 0.9458845947482434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403444545983931d, y: 0.7485349746824863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41978071750268475d, y: 0.8159132083165787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427850893701557d, y: 0.6757243030030382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909539127321464d, y: 0.407687029523798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9958845297478947d, y: 0.18415955737180956d), new NpgsqlTypes.NpgsqlPoint(x: 0.46625720746149535d, y: 0.3481117629471021d), new NpgsqlTypes.NpgsqlPoint(x: 0.16207702478719344d, y: 0.5124225128871164d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636890182477223d, y: 0.8550768315530705d), new NpgsqlTypes.NpgsqlPoint(x: 0.899177262136263d, y: 0.16228645804730835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685092778764355d, y: 0.3462598213834477d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16591717568235043d, y: 0.13730437506027304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086214851277426d, y: 0.8034660758647725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2869534451562199d, y: 0.7575012817392965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6340281929630585d, y: 0.5321449195986783d), new NpgsqlTypes.NpgsqlPoint(x: 0.46245640574529223d, y: 0.5641459799062821d), new NpgsqlTypes.NpgsqlPoint(x: 0.003446335794131894d, y: 0.906808546214979d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8117772245976583d, y: 0.18120713230810614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17660220214467104d, y: 0.7431211029086625d), new NpgsqlTypes.NpgsqlPoint(x: 0.206941068100167d, y: 0.7943471892682015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7663284950268935d, y: 0.28901088199245706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772758488585293d, y: 0.5286672769557311d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442063314718837d, y: 0.3555469814690221d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39557725001682287d, y: 0.07788122068655012d), new NpgsqlTypes.NpgsqlPoint(x: 0.34612277431958816d, y: 0.8892503844050706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7464394710371896d, y: 0.972893822971615d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15764353073973036d, y: 0.1947665474768504d), new NpgsqlTypes.NpgsqlPoint(x: 0.40908369333925343d, y: 0.5444789939791174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725192997842682d, y: 0.7404143529890939d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23833285913005908d, y: 0.548517999922706d), new NpgsqlTypes.NpgsqlPoint(x: 0.15616488352904445d, y: 0.40506574901688186d), new NpgsqlTypes.NpgsqlPoint(x: 0.49666980101621094d, y: 0.9839566174326222d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662477774594501d, y: 0.1196177934323821d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284976103447407d, y: 0.27113226158568393d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806683642132152d, y: 0.7775199119248382d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41283036568462983d, y: 0.2842162411691318d), new NpgsqlTypes.NpgsqlPoint(x: 0.12213614100641801d, y: 0.8453849137223642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8307312914179307d, y: 0.2729395904094908d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0150514279467443d, y: 0.0775398718696757d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754912796965082d, y: 0.42280911810919286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6780798728038347d, y: 0.21837708569500625d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20815297957638235d, y: 0.9428168583040842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4968376172610032d, y: 0.8097777261201502d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044389668403716d, y: 0.5896983019999178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5573941782654986d, y: 0.12905354169924887d), new NpgsqlTypes.NpgsqlPoint(x: 0.13470055485650467d, y: 0.9397834782924788d), new NpgsqlTypes.NpgsqlPoint(x: 0.722699100327201d, y: 0.7380563370465126d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4036387347717477d, y: 0.21844087498202724d), new NpgsqlTypes.NpgsqlPoint(x: 0.31312432053100836d, y: 0.8783819637593447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173184406588294d, y: 0.24237502575907066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3989970163666855d, y: 0.965226349359748d), new NpgsqlTypes.NpgsqlPoint(x: 0.567258516008496d, y: 0.9297850387289478d), new NpgsqlTypes.NpgsqlPoint(x: 0.08972315292693811d, y: 0.7460818170942275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.981944048140025d, y: 0.4159083189912779d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139689973720909d, y: 0.19863689198707024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409818797777218d, y: 0.8448745068734319d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6323128392054532d, y: 0.03266927377038353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445929824179048d, y: 0.18382422905811036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572881305784624d, y: 0.6178627823371721d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814706512602968d, y: 0.6989633466629136d), new NpgsqlTypes.NpgsqlPoint(x: 0.14058501548566305d, y: 0.29658913492054007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847316664307224d, y: 0.81285351086056d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3472187000111391d, y: 0.7376030273975455d), new NpgsqlTypes.NpgsqlPoint(x: 0.856191931433187d, y: 0.09736823671110961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606148801539442d, y: 0.564270457390668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4545417421125455d, y: 0.8280995148279041d), new NpgsqlTypes.NpgsqlPoint(x: 0.45303210451067555d, y: 0.05171035327153206d), new NpgsqlTypes.NpgsqlPoint(x: 0.04007486976974728d, y: 0.4576403055770615d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6285674140573946d, y: 0.4371860250429167d), new NpgsqlTypes.NpgsqlPoint(x: 0.302676661012938d, y: 0.9337053120145239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861352553799722d, y: 0.9547628540584643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06709743013338754d, y: 0.6762593211649328d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644736502418223d, y: 0.3802109757813211d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778235721948943d, y: 0.214931146633631d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6170165799399624d, y: 0.4198840569976955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291071298430044d, y: 0.6321694844325959d), new NpgsqlTypes.NpgsqlPoint(x: 0.0461891292735368d, y: 0.4559108158602261d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8350977149050607d, y: 0.32065242742365097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674746860289341d, y: 0.9069402325698329d), new NpgsqlTypes.NpgsqlPoint(x: 0.48945215500969963d, y: 0.6356623420586787d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4358316603488591d, y: 0.6245617488488173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335615822991862d, y: 0.6491820514526311d), new NpgsqlTypes.NpgsqlPoint(x: 0.2658908979623542d, y: 0.7447209838775414d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05896668200258759d, y: 0.6881589808060593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7754787535816294d, y: 0.7295320936404179d), new NpgsqlTypes.NpgsqlPoint(x: 0.062225316794267016d, y: 0.754319768951752d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23870166213177324d, y: 0.3514137371215551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234591018035076d, y: 0.7685460566486431d), new NpgsqlTypes.NpgsqlPoint(x: 0.45571209671687984d, y: 0.1684283869641222d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9471850739193887d, y: 0.8812398672681614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886520782676512d, y: 0.6665248166227171d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236880275984554d, y: 0.6535077553923687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11391638123380543d, y: 0.5268384382022812d), new NpgsqlTypes.NpgsqlPoint(x: 0.08783123829186446d, y: 0.6424334643696382d), new NpgsqlTypes.NpgsqlPoint(x: 0.1741522320647252d, y: 0.19342494887453954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5627809028047992d, y: 0.728249972244694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580373255856265d, y: 0.7090598840459996d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936983866584497d, y: 0.9006470157470707d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 195,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0973477366749852d, y: 0.6044050308851856d), new NpgsqlTypes.NpgsqlPoint(x: 0.36317829223739106d, y: 0.4654731893267636d), new NpgsqlTypes.NpgsqlPoint(x: 0.685988897023951d, y: 0.18936971923592028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04641128379162407d, y: 0.855229705385036d), new NpgsqlTypes.NpgsqlPoint(x: 0.005846227789686909d, y: 0.5746434665420509d), new NpgsqlTypes.NpgsqlPoint(x: 0.32070092699619d, y: 0.6408303058531726d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6329782376539558d, y: 0.010370729061443762d), new NpgsqlTypes.NpgsqlPoint(x: 0.35612961700906676d, y: 0.10090661997920058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444620893458726d, y: 0.8907987877325025d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572803658269094d, y: 0.958875014271726d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806955362164998d, y: 0.4107152338983402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724836258590073d, y: 0.19404711782741235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30978514283724723d, y: 0.4327035469962821d), new NpgsqlTypes.NpgsqlPoint(x: 0.3812028743893433d, y: 0.3118457106200395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993428781724721d, y: 0.2368869503013622d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7628566019356938d, y: 0.8437293448882531d), new NpgsqlTypes.NpgsqlPoint(x: 0.31727585196041685d, y: 0.9475537076290678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740519106671089d, y: 0.5024883819609388d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 204,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7480043502813343d, y: 0.5233139060317963d), new NpgsqlTypes.NpgsqlPoint(x: 0.11773006949539055d, y: 0.5414048725936466d), new NpgsqlTypes.NpgsqlPoint(x: 0.04091921652458197d, y: 0.8070879646320265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6435731664933791d, y: 0.9669469356650725d), new NpgsqlTypes.NpgsqlPoint(x: 0.35612007692745795d, y: 0.6758114429872413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779159803943793d, y: 0.988281271339997d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12626393969011773d, y: 0.9650979996118456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975992563462275d, y: 0.0028296250213393215d), new NpgsqlTypes.NpgsqlPoint(x: 0.19491699981772648d, y: 0.2602806911006379d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3114146149565824d, y: 0.8624745081980296d), new NpgsqlTypes.NpgsqlPoint(x: 0.22431677785445125d, y: 0.002390317861843183d), new NpgsqlTypes.NpgsqlPoint(x: 0.36256926730882655d, y: 0.26757403548444814d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7593048214071867d, y: 0.4657699006530045d), new NpgsqlTypes.NpgsqlPoint(x: 0.35986057009891825d, y: 0.3418039905529282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771448590248475d, y: 0.9943434308234237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4937981606179135d, y: 0.43546170007315577d), new NpgsqlTypes.NpgsqlPoint(x: 0.511400753148145d, y: 0.6442845539319848d), new NpgsqlTypes.NpgsqlPoint(x: 0.24473320727510572d, y: 0.5077435212501652d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12286779101120271d, y: 0.7882561981170694d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923784227142816d, y: 0.14666265214691188d), new NpgsqlTypes.NpgsqlPoint(x: 0.07997934923812089d, y: 0.8945123346858209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4871597018766577d, y: 0.7457243853604854d), new NpgsqlTypes.NpgsqlPoint(x: 0.18547059146282396d, y: 0.7840308981513275d), new NpgsqlTypes.NpgsqlPoint(x: 0.14387339194939386d, y: 0.324805423847201d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6745574297251209d, y: 0.050917563727014836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546270592528712d, y: 0.029395523239934995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089966043443588d, y: 0.4681949188672373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5434589568299026d, y: 0.5261287460360844d), new NpgsqlTypes.NpgsqlPoint(x: 0.13574119058674572d, y: 0.2774791469437865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530763033097895d, y: 0.5471464228867439d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3581028985832375d, y: 0.6444377282030367d), new NpgsqlTypes.NpgsqlPoint(x: 0.768360641188743d, y: 0.9649789745484204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144704283650364d, y: 0.3409027767586138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23517966442181903d, y: 0.9194971522877712d), new NpgsqlTypes.NpgsqlPoint(x: 0.535384195181519d, y: 0.1696058238890873d), new NpgsqlTypes.NpgsqlPoint(x: 0.4748983241586764d, y: 0.9990474079342225d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 209,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5327212551745054d, y: 0.821838382495593d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984836970934941d, y: 0.35119436221078293d), new NpgsqlTypes.NpgsqlPoint(x: 0.24392710724126687d, y: 0.35104577911383006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5516142583625694d, y: 0.3618132587941444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083164804803614d, y: 0.8407257763117809d), new NpgsqlTypes.NpgsqlPoint(x: 0.28869085322402444d, y: 0.19392876946742366d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4649543207349801d, y: 0.32448066845705337d), new NpgsqlTypes.NpgsqlPoint(x: 0.42788849717857247d, y: 0.4825678211321339d), new NpgsqlTypes.NpgsqlPoint(x: 0.0986729682109827d, y: 0.4320678224073762d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210893408534168d, y: 0.37422417938767594d), new NpgsqlTypes.NpgsqlPoint(x: 0.34430782469704335d, y: 0.8855264967285711d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100203132552725d, y: 0.8483498100709761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.822308310808342d, y: 0.8083293372705016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4835295447883706d, y: 0.8337709602525407d), new NpgsqlTypes.NpgsqlPoint(x: 0.11592686514451911d, y: 0.9176046371661235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8078406541893545d, y: 0.19029138108230426d), new NpgsqlTypes.NpgsqlPoint(x: 0.017074627930657837d, y: 0.8905354170433812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469356029089574d, y: 0.2657310960906767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.333996136293527d, y: 0.5245781998410983d), new NpgsqlTypes.NpgsqlPoint(x: 0.17433742402673702d, y: 0.15699984606664297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4821497867227159d, y: 0.5256939749399675d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024691012171226934d, y: 0.21749671290859007d), new NpgsqlTypes.NpgsqlPoint(x: 0.10627656720825018d, y: 0.4240754909322044d), new NpgsqlTypes.NpgsqlPoint(x: 0.42199873061815985d, y: 0.5191893932838895d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36426066887346d, y: 0.9819712475449167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784450809570579d, y: 0.7334031562965087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4152070804722815d, y: 0.4580503574374456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08610814219498508d, y: 7.997783215707432E-05d), new NpgsqlTypes.NpgsqlPoint(x: 0.39726055946565597d, y: 0.5491448953617819d), new NpgsqlTypes.NpgsqlPoint(x: 0.19509789811133882d, y: 0.6431639540204959d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8534709730924174d, y: 0.7544495030132418d), new NpgsqlTypes.NpgsqlPoint(x: 0.39389012819892677d, y: 0.9870068722444676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275050355305602d, y: 0.24730795288584828d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04124263428676389d, y: 0.41891000869230544d), new NpgsqlTypes.NpgsqlPoint(x: 0.23855118458459024d, y: 0.15929660839379445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370178935792283d, y: 0.7046444298875572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296541211719049d, y: 0.3027486874386893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805530207930806d, y: 0.33155330012191264d), new NpgsqlTypes.NpgsqlPoint(x: 0.09814185497021466d, y: 0.4371388421391713d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41431776946693444d, y: 0.7411513254031972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661322357630554d, y: 0.2830196107393731d), new NpgsqlTypes.NpgsqlPoint(x: 0.48631142499405555d, y: 0.8359917310634217d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8061699752494669d, y: 0.503226199936915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912871795279295d, y: 0.3746991765337483d), new NpgsqlTypes.NpgsqlPoint(x: 0.557080271008978d, y: 0.5555621462780178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.670138747499679d, y: 0.32518761042122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001576219515215d, y: 0.4652854266549842d), new NpgsqlTypes.NpgsqlPoint(x: 0.36002406916303953d, y: 0.6030782122378041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1032280069679512d, y: 0.43530398224886857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9361948065985709d, y: 0.19020529841857337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853451698547271d, y: 0.9018303412057352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39877667268778605d, y: 0.9922624536090561d), new NpgsqlTypes.NpgsqlPoint(x: 0.10945308244295704d, y: 0.9756983928558216d), new NpgsqlTypes.NpgsqlPoint(x: 0.35554520161840364d, y: 0.2680618640511381d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7266486701379274d, y: 0.5941030587712834d), new NpgsqlTypes.NpgsqlPoint(x: 0.41421991457177787d, y: 0.7082145828669462d), new NpgsqlTypes.NpgsqlPoint(x: 0.0527527603152228d, y: 0.8954663294465256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5551237625980963d, y: 0.8471969393090267d), new NpgsqlTypes.NpgsqlPoint(x: 0.536269833703203d, y: 0.7099799227119672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334556619710035d, y: 0.19641542095091635d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16916667134229568d, y: 0.2335576325382943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255021333460148d, y: 0.9724429019939385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915739179056837d, y: 0.39943835061147404d)),
}));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9682004086801065d, y: 0.7916703486855939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377846763341873d, y: 0.5127931905823152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387532628084857d, y: 0.008873290613585882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3570422965825236d, y: 0.6698540944574013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079643735280176d, y: 0.35497936086647874d), new NpgsqlTypes.NpgsqlPoint(x: 0.769589704651499d, y: 0.500130991510733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.055718247126360865d, y: 0.7803575141441408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289763467384109d, y: 0.12525162170043858d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186346225645641d, y: 0.8061860476907781d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36696598791020774d, y: 0.7448350745400723d), new NpgsqlTypes.NpgsqlPoint(x: 0.43943857454606816d, y: 0.07352782566689064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819409376391839d, y: 0.19875055616485893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839648361069974d, y: 0.8669549682866905d), new NpgsqlTypes.NpgsqlPoint(x: 0.40902263239195447d, y: 0.5067885704486922d), new NpgsqlTypes.NpgsqlPoint(x: 0.12368419349914539d, y: 0.021284866350726572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052293697866730326d, y: 0.9558023690469973d), new NpgsqlTypes.NpgsqlPoint(x: 0.04241368864000694d, y: 0.5763383493213561d), new NpgsqlTypes.NpgsqlPoint(x: 0.38377689941085236d, y: 0.6702007351328273d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 195;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 195;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 10, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 67, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 55, 176))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 76, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI), typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

