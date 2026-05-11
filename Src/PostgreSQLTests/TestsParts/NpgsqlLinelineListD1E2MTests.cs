

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7585611048063342d, b: 0.23858537598625973d, c: 0.03683326775203688d),

new NpgsqlTypes.NpgsqlLine(a: 0.6370145993176825d, b: 0.09306938140783538d, c: 0.6720446497552967d),

new NpgsqlTypes.NpgsqlLine(a: 0.5022572268741743d, b: 0.13189038551963372d, c: 0.9662182468192108d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5419457315536579d, b: 0.9898879460548013d, c: 0.4940649975543473d),

new NpgsqlTypes.NpgsqlLine(a: 0.29320451152794036d, b: 0.812773762072099d, c: 0.47090332907017673d),

new NpgsqlTypes.NpgsqlLine(a: 0.6203500162050412d, b: 0.004487721420224466d, c: 0.3444770030777292d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3042350075482223d, b: 0.8969447980757785d, c: 0.008801966709371167d),

new NpgsqlTypes.NpgsqlLine(a: 0.7589650376424352d, b: 0.9572752721619455d, c: 0.2248181501143034d),

new NpgsqlTypes.NpgsqlLine(a: 0.06387514085740109d, b: 0.8426485913572102d, c: 0.5196927724213418d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6826629591693723d, b: 0.89329080760417d, c: 0.6177231431857998d),

new NpgsqlTypes.NpgsqlLine(a: 0.3945216767303834d, b: 0.37869242748181076d, c: 0.6056539803907284d),

new NpgsqlTypes.NpgsqlLine(a: 0.05466773004215919d, b: 0.8248016017564743d, c: 0.6213382364060753d),

new NpgsqlTypes.NpgsqlLine(a: 0.2510325513012529d, b: 0.8545026602739664d, c: 0.5513407145341781d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06301350920551796d, b: 0.47715815493000346d, c: 0.5095368544586915d),

new NpgsqlTypes.NpgsqlLine(a: 0.19361951059525806d, b: 0.7780202553697686d, c: 0.9025593393375712d),

new NpgsqlTypes.NpgsqlLine(a: 0.960593363787837d, b: 0.17418672272163516d, c: 0.8795798792907967d),

new NpgsqlTypes.NpgsqlLine(a: 0.6617157688453733d, b: 0.8593338985700363d, c: 0.8437698786887122d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5671461763427883d, b: 0.37544737048654975d, c: 0.9505516694236557d),

new NpgsqlTypes.NpgsqlLine(a: 0.12771135218502438d, b: 0.49712979619345876d, c: 0.21166267944864725d),

new NpgsqlTypes.NpgsqlLine(a: 0.05556066448185515d, b: 0.8025155895189764d, c: 0.4090558883982257d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9032687252092635d, b: 0.8576104448685913d, c: 0.28082252485067627d),

new NpgsqlTypes.NpgsqlLine(a: 0.37345451253038786d, b: 0.06192086253572393d, c: 0.8809762887404848d),

new NpgsqlTypes.NpgsqlLine(a: 0.20084382029032533d, b: 0.6102344501166008d, c: 0.44275088280538955d),

new NpgsqlTypes.NpgsqlLine(a: 0.22489821561556245d, b: 0.8543245992423105d, c: 0.5689919382852453d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8647749869407234d, b: 0.8116816717810141d, c: 0.6040206660795137d),

new NpgsqlTypes.NpgsqlLine(a: 0.2629497755684531d, b: 0.12284960263595779d, c: 0.34943969138272957d),

new NpgsqlTypes.NpgsqlLine(a: 0.3458732355867017d, b: 0.6964362744812614d, c: 0.3884574873003721d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3160577276696437d, b: 0.145043018583786d, c: 0.509845158693651d),

new NpgsqlTypes.NpgsqlLine(a: 0.7540449323152333d, b: 0.36756116687041396d, c: 0.6418694050082943d),

new NpgsqlTypes.NpgsqlLine(a: 0.06897185189350419d, b: 0.8786008125478046d, c: 0.2924637123399928d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2700526298527248d, b: 0.925083781859664d, c: 0.2129112218885868d),

new NpgsqlTypes.NpgsqlLine(a: 0.8353924004590838d, b: 0.9956821258872611d, c: 0.4026010086480257d),

new NpgsqlTypes.NpgsqlLine(a: 0.7992444836779872d, b: 0.6619639664356083d, c: 0.09027521675466066d),

new NpgsqlTypes.NpgsqlLine(a: 0.16419417459114283d, b: 0.5221709739696335d, c: 0.80766294579443d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3998415790277442d, b: 0.023550864515945236d, c: 0.033678184231463515d),

new NpgsqlTypes.NpgsqlLine(a: 0.3234804342791624d, b: 0.9029416712797077d, c: 0.7233779837246792d),

new NpgsqlTypes.NpgsqlLine(a: 0.9074450036205427d, b: 0.6511670911468903d, c: 0.1385419922046508d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48445396355354564d, b: 0.6924609176233125d, c: 0.44332537509160663d),

new NpgsqlTypes.NpgsqlLine(a: 0.7677399751579825d, b: 0.3721720977743028d, c: 0.8131452233013304d),

new NpgsqlTypes.NpgsqlLine(a: 0.35990075827490275d, b: 0.031258373050266575d, c: 0.8000883613959611d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.503495816111188d, b: 0.6267933784587396d, c: 0.17197526390355555d),

new NpgsqlTypes.NpgsqlLine(a: 0.29839961561762096d, b: 0.042782850637232195d, c: 0.9090973170939746d),

new NpgsqlTypes.NpgsqlLine(a: 0.6579264723476154d, b: 0.4059842646635716d, c: 0.380811164392596d),

new NpgsqlTypes.NpgsqlLine(a: 0.6638775384257144d, b: 0.9843266830902236d, c: 0.661185222511641d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7146589402856632d, b: 0.6215277145416395d, c: 0.06757487657564931d),

new NpgsqlTypes.NpgsqlLine(a: 0.614884053642947d, b: 0.1860646267326267d, c: 0.6109520847082202d),

new NpgsqlTypes.NpgsqlLine(a: 0.45911944202810684d, b: 0.34043025965325846d, c: 0.4420220942346593d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1676081075974335d, b: 0.47000377925790127d, c: 0.8388811632363554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9936956134011433d, b: 0.9781775679523997d, c: 0.4833734964407075d),

new NpgsqlTypes.NpgsqlLine(a: 0.9730545335259766d, b: 0.5017500954554228d, c: 0.052003678200323034d),

new NpgsqlTypes.NpgsqlLine(a: 0.42506899437092893d, b: 0.7890521055342198d, c: 0.0383266106767145d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1293510811491655d, b: 0.5618679964828566d, c: 0.8762010163027575d),

new NpgsqlTypes.NpgsqlLine(a: 0.32833137542442226d, b: 0.15409351604090415d, c: 0.015323087090156062d),

new NpgsqlTypes.NpgsqlLine(a: 0.11885154080893068d, b: 0.18568870827865758d, c: 0.570309655767399d),

new NpgsqlTypes.NpgsqlLine(a: 0.9991369317171297d, b: 0.40625308003288285d, c: 0.9763409087890818d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4990851599621633d, b: 0.4449995319802291d, c: 0.38980364616807883d),

new NpgsqlTypes.NpgsqlLine(a: 0.9677393465131818d, b: 0.9037454876861222d, c: 0.3836290263814286d),

new NpgsqlTypes.NpgsqlLine(a: 0.3624641023408465d, b: 0.5948715281940321d, c: 0.30427678441931405d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.027442183106096585d, b: 0.7558467988537423d, c: 0.6156957282158049d),

new NpgsqlTypes.NpgsqlLine(a: 0.6264537072975139d, b: 0.35196271703498616d, c: 0.8935757007349284d),

new NpgsqlTypes.NpgsqlLine(a: 0.5072291309298739d, b: 0.13542523167212017d, c: 0.3886033529962575d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5506614997488046d, b: 0.45588399984356587d, c: 0.4058226894977204d),

new NpgsqlTypes.NpgsqlLine(a: 0.6892777771399639d, b: 0.22998576412361815d, c: 0.14764049480894614d),

new NpgsqlTypes.NpgsqlLine(a: 0.8775264328873685d, b: 0.10441208491816223d, c: 0.8106594820761737d),

new NpgsqlTypes.NpgsqlLine(a: 0.3025532015986747d, b: 0.5599548431703036d, c: 0.7459552916767388d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1435342248544833d, b: 0.7352419775095281d, c: 0.36004830244874064d),

new NpgsqlTypes.NpgsqlLine(a: 0.6680713216612443d, b: 0.9454484596600258d, c: 0.20781355034458704d),

new NpgsqlTypes.NpgsqlLine(a: 0.06709862365310548d, b: 0.19104711397406515d, c: 0.19524839077906175d),

new NpgsqlTypes.NpgsqlLine(a: 0.38829639502815894d, b: 0.8989857229498555d, c: 0.5392705001918444d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2745905745639091d, b: 0.9111314924701017d, c: 0.20519460808488443d),

new NpgsqlTypes.NpgsqlLine(a: 0.14138398380057904d, b: 0.687563030777087d, c: 0.9751695491954365d),

new NpgsqlTypes.NpgsqlLine(a: 0.3402844517109235d, b: 0.7030843565832692d, c: 0.9442981253187441d),

new NpgsqlTypes.NpgsqlLine(a: 0.7620298136618608d, b: 0.5904672631445019d, c: 0.8373922674447537d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4200169679624485d, b: 0.9347119422875593d, c: 0.9749856848437131d),

new NpgsqlTypes.NpgsqlLine(a: 0.26625631867189614d, b: 0.7425332397084483d, c: 0.11127091371582865d),

new NpgsqlTypes.NpgsqlLine(a: 0.11768546439786287d, b: 0.7123256891456649d, c: 0.31502713491050494d),

new NpgsqlTypes.NpgsqlLine(a: 0.3645048382986431d, b: 0.539018402304434d, c: 0.26169429427774893d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8021476698850667d, b: 0.15736378725776923d, c: 0.49574401849950744d),

new NpgsqlTypes.NpgsqlLine(a: 0.7743334184109042d, b: 0.8235512420510192d, c: 0.583127812606148d),

new NpgsqlTypes.NpgsqlLine(a: 0.9205684896075464d, b: 0.8370301114878865d, c: 0.062191595401207334d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41737378792296764d, b: 0.0056103175281048134d, c: 0.9399545916346468d),

new NpgsqlTypes.NpgsqlLine(a: 0.9165584257291798d, b: 0.37210699469887887d, c: 0.6976687743627572d),

new NpgsqlTypes.NpgsqlLine(a: 0.22595238042269894d, b: 0.8605689962847557d, c: 0.8945040406761255d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8947656240258506d, b: 0.4025265064629123d, c: 0.4505507983468665d),

new NpgsqlTypes.NpgsqlLine(a: 0.433866044188122d, b: 0.462357545264955d, c: 0.4483846166734663d),

new NpgsqlTypes.NpgsqlLine(a: 0.8551014409317303d, b: 0.8945802785125823d, c: 0.12627510876193104d),

new NpgsqlTypes.NpgsqlLine(a: 0.9783655460839098d, b: 0.8613097030353947d, c: 0.7385060214993491d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35259034076748264d, b: 0.2981507323235131d, c: 0.6460140153519751d),

new NpgsqlTypes.NpgsqlLine(a: 0.791331988627431d, b: 0.5118512282438389d, c: 0.10838717090884342d),

new NpgsqlTypes.NpgsqlLine(a: 0.3887576469211931d, b: 0.9862034788562131d, c: 0.6937686000606309d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7018441851931471d, b: 0.43295862957946585d, c: 0.1509805488857794d),

new NpgsqlTypes.NpgsqlLine(a: 0.5842964386186866d, b: 0.3584905477178224d, c: 0.3082569832916511d),

new NpgsqlTypes.NpgsqlLine(a: 0.7062015730715006d, b: 0.36617963192142566d, c: 0.704615219582533d),

new NpgsqlTypes.NpgsqlLine(a: 0.02073812097745653d, b: 0.7436944158936265d, c: 0.5562005511110635d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6556402396539784d, b: 0.7858056426385398d, c: 0.8475700508766361d),

new NpgsqlTypes.NpgsqlLine(a: 0.7544301303116884d, b: 0.0622342408931319d, c: 0.6639940482399916d),

new NpgsqlTypes.NpgsqlLine(a: 0.07028420534265634d, b: 0.4140672938281562d, c: 0.7507022354224295d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07610421134958623d, b: 0.37674975944073674d, c: 0.31247737756151306d),

new NpgsqlTypes.NpgsqlLine(a: 0.09969467015808209d, b: 0.27240919258354535d, c: 0.06565242117671855d),

new NpgsqlTypes.NpgsqlLine(a: 0.14321360170661868d, b: 0.15368548819740102d, c: 0.26352539904284d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09306718059119823d, b: 0.31171993939366494d, c: 0.7101484408864545d),

new NpgsqlTypes.NpgsqlLine(a: 0.48332276975050437d, b: 0.249325831870846d, c: 0.11637827572114223d),

new NpgsqlTypes.NpgsqlLine(a: 0.6825068261989131d, b: 0.9534831256724479d, c: 0.3775351502750772d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19568305429090682d, b: 0.17296758738619866d, c: 0.42645779988597987d),

new NpgsqlTypes.NpgsqlLine(a: 0.5524244602622486d, b: 0.8794467470519545d, c: 0.8097825401828844d),

new NpgsqlTypes.NpgsqlLine(a: 0.33404560847056375d, b: 0.28823306993864617d, c: 0.03413852007031415d),

new NpgsqlTypes.NpgsqlLine(a: 0.20078079871329102d, b: 0.8842738669556004d, c: 0.1042532250659276d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06515413440891527d, b: 0.9004947867821304d, c: 0.3741815894392063d),

new NpgsqlTypes.NpgsqlLine(a: 0.84802578195328d, b: 0.4497199391675749d, c: 0.061870295761893845d),

new NpgsqlTypes.NpgsqlLine(a: 0.7811834884145832d, b: 0.8059467796767917d, c: 0.5006814743119663d),

new NpgsqlTypes.NpgsqlLine(a: 0.8857551658683236d, b: 0.9668043493209938d, c: 0.5836273448836823d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.036075251810943065d, b: 0.19261299815836364d, c: 0.9595253719196637d),

new NpgsqlTypes.NpgsqlLine(a: 0.48941748577799915d, b: 0.6975267891887196d, c: 0.9230556496574247d),

new NpgsqlTypes.NpgsqlLine(a: 0.7027146171589888d, b: 0.1652779928163891d, c: 0.22212090652703786d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3191048910608322d, b: 0.24094381221170447d, c: 0.516776012656983d),

new NpgsqlTypes.NpgsqlLine(a: 0.3886342716161407d, b: 0.45597893559069635d, c: 0.3350603940714896d),

new NpgsqlTypes.NpgsqlLine(a: 0.08755832535591701d, b: 0.39819034733563574d, c: 0.04177972574409694d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6965459151563255d, b: 0.8946416134873859d, c: 0.3534372642100094d),

new NpgsqlTypes.NpgsqlLine(a: 0.09862419145512247d, b: 0.6193179864119102d, c: 0.9751745913958748d),

new NpgsqlTypes.NpgsqlLine(a: 0.20333671427965905d, b: 0.44525222179322277d, c: 0.9212018649081843d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6629681870610179d, b: 0.8827807908980445d, c: 0.1914287616740724d),

new NpgsqlTypes.NpgsqlLine(a: 0.496836620516927d, b: 0.5899254802763191d, c: 0.5309243330652645d),

new NpgsqlTypes.NpgsqlLine(a: 0.5859281103243734d, b: 0.19152603580751926d, c: 0.9854612328007462d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4871670941429489d, b: 0.037211604201041526d, c: 0.9382013764846686d),

new NpgsqlTypes.NpgsqlLine(a: 0.48785354241114165d, b: 0.3500876186975883d, c: 0.2303816639636339d),

new NpgsqlTypes.NpgsqlLine(a: 0.8963864497439513d, b: 0.142665153909328d, c: 0.6436843934440616d),

new NpgsqlTypes.NpgsqlLine(a: 0.08028162057585075d, b: 0.03195254347043308d, c: 0.4000633772309298d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22541962891559308d, b: 0.9813370785035539d, c: 0.23795609577135668d),

new NpgsqlTypes.NpgsqlLine(a: 0.44687041104071434d, b: 0.49261013800707876d, c: 0.6878240699018647d),

new NpgsqlTypes.NpgsqlLine(a: 0.8655464784177255d, b: 0.8487524197641272d, c: 0.2998264313991422d),

new NpgsqlTypes.NpgsqlLine(a: 0.09906410417385447d, b: 0.7207443250296529d, c: 0.5350955938346366d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3401234999251358d, b: 0.5962174761138521d, c: 0.35045125586117687d),

new NpgsqlTypes.NpgsqlLine(a: 0.2043507712202014d, b: 0.8778605560610042d, c: 0.8836798020109092d),

new NpgsqlTypes.NpgsqlLine(a: 0.34506597004261486d, b: 0.956572649895307d, c: 0.2281845262054174d),

new NpgsqlTypes.NpgsqlLine(a: 0.3935266849290132d, b: 0.46716135861827024d, c: 0.403964151384675d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8617643174131325d, b: 0.8877426518371132d, c: 0.8864193357312177d),

new NpgsqlTypes.NpgsqlLine(a: 0.9783894091576146d, b: 0.5850461849698863d, c: 0.18314821042505336d),

new NpgsqlTypes.NpgsqlLine(a: 0.09101563796561196d, b: 0.6209371156650251d, c: 0.3075557769878233d),

new NpgsqlTypes.NpgsqlLine(a: 0.7872653794323797d, b: 0.18177221571925006d, c: 0.05474768631250648d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4632940107873126d, b: 0.8390301804784848d, c: 0.1507195410211093d),

new NpgsqlTypes.NpgsqlLine(a: 0.07833259721285413d, b: 0.23556799605271117d, c: 0.09703763835442558d),

new NpgsqlTypes.NpgsqlLine(a: 0.4426520931869704d, b: 0.974146242820054d, c: 0.9088451714421925d),

new NpgsqlTypes.NpgsqlLine(a: 0.2590527565976789d, b: 0.3178445522751342d, c: 0.8001425734126326d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8588806059136166d, b: 0.018713794566103337d, c: 0.158848701387022d),

new NpgsqlTypes.NpgsqlLine(a: 0.40142303812693814d, b: 0.034055316455384066d, c: 0.21041992267932774d),

new NpgsqlTypes.NpgsqlLine(a: 0.056638216110698525d, b: 0.6370866106080961d, c: 0.8861984395727895d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8016078448572661d, b: 0.15294881266916172d, c: 0.8075052775624979d),

new NpgsqlTypes.NpgsqlLine(a: 0.12938785488153415d, b: 0.7355563105141585d, c: 0.42979508449979d),

new NpgsqlTypes.NpgsqlLine(a: 0.38480725312606356d, b: 0.7447783402721276d, c: 0.8315188985252692d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5532884555544918d, b: 0.7902683661192877d, c: 0.4613117696267237d),

new NpgsqlTypes.NpgsqlLine(a: 0.5317607032832031d, b: 0.5250488963676846d, c: 0.3707941542702238d),

new NpgsqlTypes.NpgsqlLine(a: 0.20709789494448383d, b: 0.3700384305951635d, c: 0.31827613568339364d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8791765509598961d, b: 0.8401062687654415d, c: 0.12233841834017589d),

new NpgsqlTypes.NpgsqlLine(a: 0.27798174176192014d, b: 0.8104860831633515d, c: 0.5462678558266544d),

new NpgsqlTypes.NpgsqlLine(a: 0.6415403755595254d, b: 0.605094028673209d, c: 0.12260973129869912d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7931335120684703d, b: 0.8369143144922113d, c: 0.9948386166406856d),

new NpgsqlTypes.NpgsqlLine(a: 0.3152128509581187d, b: 0.23065297362132708d, c: 0.8055328442215549d),

new NpgsqlTypes.NpgsqlLine(a: 0.7621754911268086d, b: 0.2234749367740414d, c: 0.42726305639548046d),

new NpgsqlTypes.NpgsqlLine(a: 0.10355365881511092d, b: 0.33777750241082305d, c: 0.43139841069161244d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6444988681365154d, b: 0.8004841368082349d, c: 0.47992907446173594d),

new NpgsqlTypes.NpgsqlLine(a: 0.7494595175473262d, b: 0.4967754798759626d, c: 0.40038152820263295d),

new NpgsqlTypes.NpgsqlLine(a: 0.6431584530568499d, b: 0.3478243448439019d, c: 0.5882214671234335d),

new NpgsqlTypes.NpgsqlLine(a: 0.5429977369463699d, b: 0.10208602479738926d, c: 0.7904703905263487d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1396416911972812d, b: 0.49963253237437355d, c: 0.32006719987778853d),

new NpgsqlTypes.NpgsqlLine(a: 0.3853926333772225d, b: 0.712515401698803d, c: 0.8958612928256975d),

new NpgsqlTypes.NpgsqlLine(a: 0.4699315302192204d, b: 0.09317933800782419d, c: 0.5737133797094882d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07635326040020518d, b: 0.9895889512808289d, c: 0.36220147557723004d),

new NpgsqlTypes.NpgsqlLine(a: 0.624816287699311d, b: 0.7936724186112315d, c: 0.3567836925353187d),

new NpgsqlTypes.NpgsqlLine(a: 0.47629756283008806d, b: 0.23915144916972986d, c: 0.05056614955684291d),

new NpgsqlTypes.NpgsqlLine(a: 0.28621590899103466d, b: 0.12611130539950688d, c: 0.329547389607172d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23805437530346785d, b: 0.697302877289671d, c: 0.4262873977728344d),

new NpgsqlTypes.NpgsqlLine(a: 0.5257130450374919d, b: 0.7036829377709901d, c: 0.050909066428541316d),

new NpgsqlTypes.NpgsqlLine(a: 0.36123099838585937d, b: 0.5184329298887219d, c: 0.9271305731003667d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9647316175404511d, b: 0.1988307341723825d, c: 0.23910733471566925d),

new NpgsqlTypes.NpgsqlLine(a: 0.08808245572951812d, b: 0.1622858905631802d, c: 0.396102768393078d),

new NpgsqlTypes.NpgsqlLine(a: 0.965262763859773d, b: 0.5948547712526437d, c: 0.5041110022248353d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18618395691396528d, b: 0.5765211473406197d, c: 0.1346695971226164d),

new NpgsqlTypes.NpgsqlLine(a: 0.2714876349262194d, b: 0.009762450331178507d, c: 0.0006815615671537101d),

new NpgsqlTypes.NpgsqlLine(a: 0.6539105480111257d, b: 0.22756971180781438d, c: 0.5137267524662874d),

new NpgsqlTypes.NpgsqlLine(a: 0.025459689697658883d, b: 0.4143068994061676d, c: 0.8303400741340785d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9211415433863362d, b: 0.27488613289811425d, c: 0.5624223853937893d),

new NpgsqlTypes.NpgsqlLine(a: 0.8463811059136562d, b: 0.16522524260921756d, c: 0.9705297821655552d),

new NpgsqlTypes.NpgsqlLine(a: 0.7615094881811043d, b: 0.6856266671372206d, c: 0.14623615820493774d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1067563688974098d, b: 0.4706178166717686d, c: 0.45745523092338813d),

new NpgsqlTypes.NpgsqlLine(a: 0.2692984204882166d, b: 0.18709925778183212d, c: 0.6608132497262995d),

new NpgsqlTypes.NpgsqlLine(a: 0.7552275870560509d, b: 0.556429065155587d, c: 0.636330363092087d),

new NpgsqlTypes.NpgsqlLine(a: 0.49031750449859424d, b: 0.4022709229177325d, c: 0.9715420395816102d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5800409622720407d, b: 0.3474498490782517d, c: 0.5814002047344667d),

new NpgsqlTypes.NpgsqlLine(a: 0.07471942939690746d, b: 0.029655720600150537d, c: 0.9445027784436179d),

new NpgsqlTypes.NpgsqlLine(a: 0.34650595714242405d, b: 0.23987183154462d, c: 0.32068000059981216d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7834780269648672d, b: 0.12888029305958415d, c: 0.8696636095172141d),

new NpgsqlTypes.NpgsqlLine(a: 0.4437807715173083d, b: 0.8345532957065281d, c: 0.8011249916486765d),

new NpgsqlTypes.NpgsqlLine(a: 0.6461374617657443d, b: 0.3244894418781884d, c: 0.330359263326666d),

new NpgsqlTypes.NpgsqlLine(a: 0.7982417059378332d, b: 0.09550600936579501d, c: 0.8386428707829725d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07503115003238858d, b: 0.1770876408658898d, c: 0.6200144711300507d),

new NpgsqlTypes.NpgsqlLine(a: 0.42246668000760745d, b: 0.6756144236344913d, c: 0.3572009021095587d),

new NpgsqlTypes.NpgsqlLine(a: 0.2522898020936084d, b: 0.9622014658480492d, c: 0.9367770946072814d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0688670132484801d, b: 0.8186658222502003d, c: 0.775095168962222d),

new NpgsqlTypes.NpgsqlLine(a: 0.9113204921109743d, b: 0.30550618527008955d, c: 0.17228623958237288d),

new NpgsqlTypes.NpgsqlLine(a: 0.6158420917663096d, b: 0.7407958987846365d, c: 0.2464462950768176d),

new NpgsqlTypes.NpgsqlLine(a: 0.7947345939528307d, b: 0.1093264121319607d, c: 0.7496791197623992d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6423499582047459d, b: 0.4823433124553541d, c: 0.922741606382543d),

new NpgsqlTypes.NpgsqlLine(a: 0.8451489634511925d, b: 0.5688729570713854d, c: 0.4468053984692373d),

new NpgsqlTypes.NpgsqlLine(a: 0.40809773487345646d, b: 0.9809285703383691d, c: 0.948248753916172d),

new NpgsqlTypes.NpgsqlLine(a: 0.4333828654577858d, b: 0.9974413940746095d, c: 0.36734838524074165d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3967771281064847d, b: 0.35074626041463874d, c: 0.9030377856461569d),

new NpgsqlTypes.NpgsqlLine(a: 0.4584134273217071d, b: 0.782509038190477d, c: 0.45544741311327075d),

new NpgsqlTypes.NpgsqlLine(a: 0.7477244419104586d, b: 0.9893465737492171d, c: 0.10706333114059019d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5550364881356172d, b: 0.9224660229057695d, c: 0.06789716544386304d),

new NpgsqlTypes.NpgsqlLine(a: 0.9256305070073977d, b: 0.18366068672293479d, c: 0.5905992430853192d),

new NpgsqlTypes.NpgsqlLine(a: 0.27038402795308514d, b: 0.7070841692986848d, c: 0.9175205751890205d),

new NpgsqlTypes.NpgsqlLine(a: 0.28822584935527984d, b: 0.8476096013946185d, c: 0.4689295159451279d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8799056054471385d, b: 0.022300840895540297d, c: 0.14607657725850132d),

new NpgsqlTypes.NpgsqlLine(a: 0.6778020317157196d, b: 0.6598690556439788d, c: 0.4182688375988931d),

new NpgsqlTypes.NpgsqlLine(a: 0.7200534341177941d, b: 0.5426580357292919d, c: 0.6262722196550998d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3160515652834681d, b: 0.6529775831016148d, c: 0.8663270625489363d),

new NpgsqlTypes.NpgsqlLine(a: 0.18463430891699983d, b: 0.5414565745826647d, c: 0.6549418621430105d),

new NpgsqlTypes.NpgsqlLine(a: 0.6197974029835895d, b: 0.056317933652635266d, c: 0.6642866314611383d),

new NpgsqlTypes.NpgsqlLine(a: 0.012190069270550885d, b: 0.18327754604489022d, c: 0.4285149365055855d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35978508120141983d, b: 0.7537540325089408d, c: 0.2944824168010787d),

new NpgsqlTypes.NpgsqlLine(a: 0.560100133364559d, b: 0.14736886806129457d, c: 0.40897011894496726d),

new NpgsqlTypes.NpgsqlLine(a: 0.6091257387955529d, b: 0.6790001561236578d, c: 0.8146181137404392d),

new NpgsqlTypes.NpgsqlLine(a: 0.7803325181593107d, b: 0.35664099688979045d, c: 0.8085810895232625d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16020847912143554d, b: 0.7637715002357223d, c: 0.31973324553525195d),

new NpgsqlTypes.NpgsqlLine(a: 0.27727512636732154d, b: 0.03371988604514187d, c: 0.1645755755757745d),

new NpgsqlTypes.NpgsqlLine(a: 0.17944479769273336d, b: 0.499475674676932d, c: 0.5726189515274592d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13727199897375753d, b: 0.09644838979071324d, c: 0.10397868081731576d),

new NpgsqlTypes.NpgsqlLine(a: 0.44612681820589917d, b: 0.9956364764578578d, c: 0.0006362606615006872d),

new NpgsqlTypes.NpgsqlLine(a: 0.20396138516225704d, b: 0.4569224172328218d, c: 0.49465706327894976d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9630727606389934d, b: 0.3678619696900841d, c: 0.07012590425501974d),

new NpgsqlTypes.NpgsqlLine(a: 0.9512959012818849d, b: 0.20925561494144518d, c: 0.9052310264414274d),

new NpgsqlTypes.NpgsqlLine(a: 0.7239015409704239d, b: 0.7906296144413512d, c: 0.7307425966976888d),

new NpgsqlTypes.NpgsqlLine(a: 0.15920360567744218d, b: 0.4575414784347229d, c: 0.5363128307369324d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22046507438298613d, b: 0.22269112713760053d, c: 0.06703591734613878d),

new NpgsqlTypes.NpgsqlLine(a: 0.9892996477884812d, b: 0.09424867387158842d, c: 0.6693161808697065d),

new NpgsqlTypes.NpgsqlLine(a: 0.5676208988729332d, b: 0.5630260831516193d, c: 0.6920129697751689d),

new NpgsqlTypes.NpgsqlLine(a: 0.6063333937829d, b: 0.6243151986516823d, c: 0.7834112424226142d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3983051552368557d, b: 0.6341378618693031d, c: 0.7071901952388652d),

new NpgsqlTypes.NpgsqlLine(a: 0.8626528742864602d, b: 0.6767968239362684d, c: 0.9895518334852338d),

new NpgsqlTypes.NpgsqlLine(a: 0.3449641586186971d, b: 0.9553816974441823d, c: 0.25231051056490006d),

new NpgsqlTypes.NpgsqlLine(a: 0.8136740259540284d, b: 0.3439384550968917d, c: 0.7050935721262392d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3501420927481752d, b: 0.28325367465645d, c: 0.1458378445159929d),

new NpgsqlTypes.NpgsqlLine(a: 0.15595971016513133d, b: 0.7292665944282705d, c: 0.0536486880825211d),

new NpgsqlTypes.NpgsqlLine(a: 0.6188375742548506d, b: 0.0396725397571871d, c: 0.40100040297637873d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9895465470257919d, b: 0.33091901282745484d, c: 0.864173715032003d),

new NpgsqlTypes.NpgsqlLine(a: 0.2902893013554674d, b: 0.6908557980466856d, c: 0.7035502655516302d),

new NpgsqlTypes.NpgsqlLine(a: 0.06539855647499149d, b: 0.8770522716987189d, c: 0.6986161909665717d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49848587726652727d, b: 0.839433921932996d, c: 0.8398150730761692d),

new NpgsqlTypes.NpgsqlLine(a: 0.38073139686390356d, b: 0.38429447345698753d, c: 0.675925222881714d),

new NpgsqlTypes.NpgsqlLine(a: 0.9462532716970172d, b: 0.35943547417255894d, c: 0.5759331467962271d),

new NpgsqlTypes.NpgsqlLine(a: 0.0915777820044229d, b: 0.2546698625350521d, c: 0.6404100213423871d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3875157132127396d, b: 0.8851945360276303d, c: 0.998092036695224d),

new NpgsqlTypes.NpgsqlLine(a: 0.6784759076879207d, b: 0.7726554323618735d, c: 0.6749362679287252d),

new NpgsqlTypes.NpgsqlLine(a: 0.12094601674574534d, b: 0.9009582482912908d, c: 0.4016163902316666d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6190345892703226d, b: 0.2369439186125113d, c: 0.8307993005277319d),

new NpgsqlTypes.NpgsqlLine(a: 0.6283031486941997d, b: 0.6574020526160007d, c: 0.3339512965121223d),

new NpgsqlTypes.NpgsqlLine(a: 0.6445134368062398d, b: 0.8240589540580615d, c: 0.28599948494992544d),

new NpgsqlTypes.NpgsqlLine(a: 0.24537139957120757d, b: 0.2724503982845249d, c: 0.1477922005729334d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45890973989939454d, b: 0.2297894258753641d, c: 0.2370794430837071d),

new NpgsqlTypes.NpgsqlLine(a: 0.9708293607315036d, b: 0.4405648430525141d, c: 0.5925669002736826d),

new NpgsqlTypes.NpgsqlLine(a: 0.27147662280205775d, b: 0.7533401624178699d, c: 0.8389694787920388d),

new NpgsqlTypes.NpgsqlLine(a: 0.7755057213959612d, b: 0.8800543164965615d, c: 0.8629651670087697d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.020417080484783412d, b: 0.1657846079621601d, c: 0.10642578760560406d),

new NpgsqlTypes.NpgsqlLine(a: 0.13379481524928027d, b: 0.6016650146574053d, c: 0.7793803154663125d),

new NpgsqlTypes.NpgsqlLine(a: 0.4386905099460906d, b: 0.054780148081694624d, c: 0.10307886321023185d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4486926196703861d, b: 0.3646033586857159d, c: 0.9017129129443359d),

new NpgsqlTypes.NpgsqlLine(a: 0.19094875058866434d, b: 0.22435358089593238d, c: 0.518719313736148d),

new NpgsqlTypes.NpgsqlLine(a: 0.9834730728551166d, b: 0.06765742175849732d, c: 0.847806706957202d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10206652192232168d, b: 0.1258097115081268d, c: 0.3563772747828948d),

new NpgsqlTypes.NpgsqlLine(a: 0.29835417618825544d, b: 0.652700324845021d, c: 0.42665844629355987d),

new NpgsqlTypes.NpgsqlLine(a: 0.3447901379521585d, b: 0.5057227932595453d, c: 0.5187724459819479d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.712515942184761d, b: 0.24219796160314466d, c: 0.4326023444503989d),

new NpgsqlTypes.NpgsqlLine(a: 0.4210638922856126d, b: 0.8540130690873993d, c: 0.9683291646364158d),

new NpgsqlTypes.NpgsqlLine(a: 0.9120069471876477d, b: 0.4364228084624939d, c: 0.8115495163398015d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1575550349439645d, b: 0.8998597650017955d, c: 0.9891099754781002d),

new NpgsqlTypes.NpgsqlLine(a: 0.7568028929942722d, b: 0.6418856009386262d, c: 0.623580634200866d),

new NpgsqlTypes.NpgsqlLine(a: 0.8783873270262377d, b: 0.7696416999996915d, c: 0.8632939969574349d),

new NpgsqlTypes.NpgsqlLine(a: 0.36111838528993256d, b: 0.39634249148668144d, c: 0.7605626299275625d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10457074291520774d, b: 0.07963133505000175d, c: 0.4310875158061317d),

new NpgsqlTypes.NpgsqlLine(a: 0.9933911231578281d, b: 0.2873494263494789d, c: 0.38706293185907115d),

new NpgsqlTypes.NpgsqlLine(a: 0.6638833347247839d, b: 0.4186504525681106d, c: 0.9205297834654436d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7466418009809255d, b: 0.6324581424143645d, c: 0.6343625662482691d),

new NpgsqlTypes.NpgsqlLine(a: 0.9462916998249236d, b: 0.4853193449008276d, c: 0.8780913186805382d),

new NpgsqlTypes.NpgsqlLine(a: 0.5827822150480861d, b: 0.17626566056512338d, c: 0.3675028157938711d),

new NpgsqlTypes.NpgsqlLine(a: 0.7654550855011991d, b: 0.49893382156135646d, c: 0.27146212101491973d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr2.Value = 143;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 39, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 24, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[5], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[6], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[7], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[8], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[9], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[10], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[11], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 163);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

