

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2660270905934212d, b: 0.47750650817032747d, c: 0.3841062307587786d),

new NpgsqlTypes.NpgsqlLine(a: 0.9882406568818587d, b: 0.0621094715139866d, c: 0.4035720104714533d),

new NpgsqlTypes.NpgsqlLine(a: 0.4426315915954755d, b: 0.6991141438943157d, c: 0.3229273476844161d),

new NpgsqlTypes.NpgsqlLine(a: 0.15621158919529743d, b: 0.3784221995688274d, c: 0.7629690499737941d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8739037185524666d, b: 0.31962665533912304d, c: 0.06517067897228968d),

new NpgsqlTypes.NpgsqlLine(a: 0.512723608736468d, b: 0.3515186774425473d, c: 0.3087513642332519d),

new NpgsqlTypes.NpgsqlLine(a: 0.3479365218728956d, b: 0.8494772984993885d, c: 0.07570601166283808d),

new NpgsqlTypes.NpgsqlLine(a: 0.15012954428681957d, b: 0.049258289516774134d, c: 0.8129612821013638d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9998588569447108d, b: 0.4219134981951097d, c: 0.40369230036966286d),

new NpgsqlTypes.NpgsqlLine(a: 0.46506456917308825d, b: 0.8695049559463461d, c: 0.24519286614384772d),

new NpgsqlTypes.NpgsqlLine(a: 0.11726903386445187d, b: 0.13774684450015828d, c: 0.9441912971985177d),

new NpgsqlTypes.NpgsqlLine(a: 0.9239846390617458d, b: 0.05025331357543483d, c: 0.212693259078087d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4696107573871876d, b: 0.8230886759882704d, c: 0.01596776984021464d),

new NpgsqlTypes.NpgsqlLine(a: 0.6429803190988387d, b: 0.05828382212941685d, c: 0.06910789023594799d),

new NpgsqlTypes.NpgsqlLine(a: 0.6821539699277245d, b: 0.6719988345592508d, c: 0.6549627544569803d),

new NpgsqlTypes.NpgsqlLine(a: 0.5821453865482795d, b: 0.10837256715546995d, c: 0.8191495050420678d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.543962306680243d, b: 0.6132822639406218d, c: 0.6772464490052259d),

new NpgsqlTypes.NpgsqlLine(a: 0.8866474157093382d, b: 0.38253577040945086d, c: 0.32407105748587806d),

new NpgsqlTypes.NpgsqlLine(a: 0.4704703375901912d, b: 0.49247951754465824d, c: 0.7509964947835267d),

new NpgsqlTypes.NpgsqlLine(a: 0.941193578215191d, b: 0.4216834303893169d, c: 0.6874983288291475d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05217969540412959d, b: 0.3896028746420547d, c: 0.7281406818245288d),

new NpgsqlTypes.NpgsqlLine(a: 0.7084452255881746d, b: 0.8717946209971124d, c: 0.12734351930982435d),

new NpgsqlTypes.NpgsqlLine(a: 0.4731539843875291d, b: 0.2699746978088866d, c: 0.15209495090516956d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4749870884893642d, b: 0.1927226836144269d, c: 0.29018237617701703d),

new NpgsqlTypes.NpgsqlLine(a: 0.7377908208195948d, b: 0.8089288013686998d, c: 0.47354786284124284d),

new NpgsqlTypes.NpgsqlLine(a: 0.549747958022184d, b: 0.6874052219907337d, c: 0.09452698318275077d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8141831929864386d, b: 0.6038358365698113d, c: 0.8429163979156726d),

new NpgsqlTypes.NpgsqlLine(a: 0.15493665103241183d, b: 0.3963104921527991d, c: 0.626731939928861d),

new NpgsqlTypes.NpgsqlLine(a: 0.546133102940534d, b: 0.23585270105111733d, c: 0.28856382133573055d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18446640126044955d, b: 0.0188457593269602d, c: 0.9146811446838992d),

new NpgsqlTypes.NpgsqlLine(a: 0.15416421669450142d, b: 0.49810261476985895d, c: 0.5950760673470593d),

new NpgsqlTypes.NpgsqlLine(a: 0.4423174459220953d, b: 0.9850986097272428d, c: 0.8663031051286221d),

new NpgsqlTypes.NpgsqlLine(a: 0.4725352254305245d, b: 0.01633138027271741d, c: 0.1815251381570856d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7856416531770258d, b: 0.7919071664934126d, c: 0.5720709822894858d),

new NpgsqlTypes.NpgsqlLine(a: 0.2903775620125143d, b: 0.38282200435562397d, c: 0.07627175674450903d),

new NpgsqlTypes.NpgsqlLine(a: 0.5788060321423825d, b: 0.7877973230204488d, c: 0.33748415571280344d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3358080304265044d, b: 0.6901038407819291d, c: 0.17142593630453073d),

new NpgsqlTypes.NpgsqlLine(a: 0.36779852418473225d, b: 0.6102855968518689d, c: 0.44155706424057983d),

new NpgsqlTypes.NpgsqlLine(a: 0.2819182098442453d, b: 0.9329195478449029d, c: 0.1483251454143638d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5755616251139664d, b: 0.9504712109790839d, c: 0.13115314898751373d),

new NpgsqlTypes.NpgsqlLine(a: 0.3019547799274084d, b: 0.9122004271900955d, c: 0.35369287061994636d),

new NpgsqlTypes.NpgsqlLine(a: 0.039854781397639316d, b: 0.30518133693393057d, c: 0.8532427246335311d),

new NpgsqlTypes.NpgsqlLine(a: 0.3162164738741784d, b: 0.5728600914903147d, c: 0.25895282642939654d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9798496011460899d, b: 0.3873936109768077d, c: 0.4955736758376784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7114180774633624d, b: 0.9102828914011516d, c: 0.4142636792140224d),

new NpgsqlTypes.NpgsqlLine(a: 0.2836755210860914d, b: 0.3092319545727521d, c: 0.9589768901183133d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.772479086372578d, b: 0.6362183738903915d, c: 0.8239665356330261d),

new NpgsqlTypes.NpgsqlLine(a: 0.567603862273578d, b: 0.08288870616632671d, c: 0.7688088962014347d),

new NpgsqlTypes.NpgsqlLine(a: 0.5202795894048798d, b: 0.4305445492211888d, c: 0.5452392840124982d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8104941623994155d, b: 0.5672853773812081d, c: 0.23296419569195836d),

new NpgsqlTypes.NpgsqlLine(a: 0.1901036678938941d, b: 0.6106647201732279d, c: 0.9343624446499345d),

new NpgsqlTypes.NpgsqlLine(a: 0.22660860564198537d, b: 0.4586804606547892d, c: 0.14166700188368286d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.255169774395834d, b: 0.9084368141985065d, c: 0.1475790083696965d),

new NpgsqlTypes.NpgsqlLine(a: 0.07055520929218129d, b: 0.6356979249214032d, c: 0.3148612374216011d),

new NpgsqlTypes.NpgsqlLine(a: 0.43918983777351883d, b: 0.6070861119526212d, c: 0.5021687464653243d),

new NpgsqlTypes.NpgsqlLine(a: 0.6766164090944753d, b: 0.8108258253355035d, c: 0.012793410575774433d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5368229510256173d, b: 0.9098093389684183d, c: 0.87798354441194d),

new NpgsqlTypes.NpgsqlLine(a: 0.9477484630027033d, b: 0.9333952714247188d, c: 0.4492387956750026d),

new NpgsqlTypes.NpgsqlLine(a: 0.05705893139278073d, b: 0.4677709263694567d, c: 0.5742838171010106d),

new NpgsqlTypes.NpgsqlLine(a: 0.6206211047461884d, b: 0.953706345829615d, c: 0.45611607710003743d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8375504541405024d, b: 0.858180154088011d, c: 0.6885606620708974d),

new NpgsqlTypes.NpgsqlLine(a: 0.3335651187424993d, b: 0.8243200287467349d, c: 0.9397729753630703d),

new NpgsqlTypes.NpgsqlLine(a: 0.4404871551493271d, b: 0.7721209477102293d, c: 0.5030760615998274d),

new NpgsqlTypes.NpgsqlLine(a: 0.1603845675364478d, b: 0.07444268324534442d, c: 0.22117316794400776d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7492828010360324d, b: 0.5222843615101851d, c: 0.19142798018176888d),

new NpgsqlTypes.NpgsqlLine(a: 0.8593832890298939d, b: 0.5279397832518614d, c: 0.10874069176487644d),

new NpgsqlTypes.NpgsqlLine(a: 0.6779738130732924d, b: 0.8527477190071839d, c: 0.9384438931284104d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5248490839434957d, b: 0.30637477254672496d, c: 0.9087917937486667d),

new NpgsqlTypes.NpgsqlLine(a: 0.7563354362676662d, b: 0.4319404890331986d, c: 0.8218338593666985d),

new NpgsqlTypes.NpgsqlLine(a: 0.6099178202040871d, b: 0.4217051874942802d, c: 0.916529396906671d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6446009060216276d, b: 0.37069017833030193d, c: 0.8175705578945692d),

new NpgsqlTypes.NpgsqlLine(a: 0.23111345499592817d, b: 0.8583538189492218d, c: 0.5268356684225789d),

new NpgsqlTypes.NpgsqlLine(a: 0.2284421617752006d, b: 0.4487765916050632d, c: 0.07713445219711024d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6162315521725966d, b: 0.3073422270392121d, c: 0.8451061081181404d),

new NpgsqlTypes.NpgsqlLine(a: 0.5091149823205274d, b: 0.9248723388589802d, c: 0.8123426768025505d),

new NpgsqlTypes.NpgsqlLine(a: 0.6153597511508899d, b: 0.08006881727067594d, c: 0.8515055572557791d),

new NpgsqlTypes.NpgsqlLine(a: 0.2855182018027218d, b: 0.27899853370564676d, c: 0.8846254934363343d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34073610068920424d, b: 0.1278038562570577d, c: 0.7546280265438904d),

new NpgsqlTypes.NpgsqlLine(a: 0.9554668847551385d, b: 0.11956392009175265d, c: 0.209600455547453d),

new NpgsqlTypes.NpgsqlLine(a: 0.9987076877863068d, b: 0.4215911581441626d, c: 0.35327845872025154d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.871299328451411d, b: 0.5373195465950769d, c: 0.6935408508856198d),

new NpgsqlTypes.NpgsqlLine(a: 0.09152746631816921d, b: 0.5133688926084633d, c: 0.5974379230267586d),

new NpgsqlTypes.NpgsqlLine(a: 0.8522633868217335d, b: 0.05659129746889113d, c: 0.03088502801283821d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19529179528983787d, b: 0.09601329673123571d, c: 0.4804489286454682d),

new NpgsqlTypes.NpgsqlLine(a: 0.5482999515144767d, b: 0.3930135482701791d, c: 0.1517266980409142d),

new NpgsqlTypes.NpgsqlLine(a: 0.3349038039611043d, b: 0.18265667049359036d, c: 0.6485587485996972d),

new NpgsqlTypes.NpgsqlLine(a: 0.5554686321458715d, b: 0.8820951766615761d, c: 0.9930030297582583d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05772505407806716d, b: 0.04743871105585162d, c: 0.8682606074683924d),

new NpgsqlTypes.NpgsqlLine(a: 0.39777175869169634d, b: 0.60380920123003d, c: 0.9998888394782691d),

new NpgsqlTypes.NpgsqlLine(a: 0.09330410617517859d, b: 0.7756960949909739d, c: 0.3690367461007299d),

new NpgsqlTypes.NpgsqlLine(a: 0.5936961395711554d, b: 0.24704754550413976d, c: 0.862223728648836d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8681993064892629d, b: 0.386726357860505d, c: 0.18552989846815815d),

new NpgsqlTypes.NpgsqlLine(a: 0.3912488633499437d, b: 0.005316334174799597d, c: 0.3031118195383248d),

new NpgsqlTypes.NpgsqlLine(a: 0.42793056629412596d, b: 0.9529587059014692d, c: 0.5434249099813092d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3334852031505158d, b: 0.0930157521580145d, c: 0.3279971551584009d),

new NpgsqlTypes.NpgsqlLine(a: 0.20960162819918837d, b: 0.29413677507278d, c: 0.18210677268757325d),

new NpgsqlTypes.NpgsqlLine(a: 0.7113965607103485d, b: 0.34084525633463114d, c: 0.3275528372245926d),

new NpgsqlTypes.NpgsqlLine(a: 0.7602018198791727d, b: 0.5137390761146717d, c: 0.8559677900398139d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11863690322708753d, b: 0.591618442314117d, c: 0.2523310724621354d),

new NpgsqlTypes.NpgsqlLine(a: 0.9523255688080837d, b: 0.514741665934711d, c: 0.5932395871350787d),

new NpgsqlTypes.NpgsqlLine(a: 0.11257301057694025d, b: 0.9821232797602046d, c: 0.9948256485594923d),

new NpgsqlTypes.NpgsqlLine(a: 0.42389912970610266d, b: 0.9681426906269383d, c: 0.5785938810992194d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4088572468325573d, b: 0.21522964005114142d, c: 0.390757975797274d),

new NpgsqlTypes.NpgsqlLine(a: 0.2943085971567305d, b: 0.015782515419334397d, c: 0.9460837564216686d),

new NpgsqlTypes.NpgsqlLine(a: 0.29244282895971796d, b: 0.32824377076656297d, c: 0.8266418140227131d),

new NpgsqlTypes.NpgsqlLine(a: 0.2121528743300416d, b: 0.07717663516588524d, c: 0.8746840201776221d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1439231272590319d, b: 0.27359340466524884d, c: 0.3770717681517316d),

new NpgsqlTypes.NpgsqlLine(a: 0.5267982492448071d, b: 0.14183755478810145d, c: 0.1459266157820449d),

new NpgsqlTypes.NpgsqlLine(a: 0.9747493869074692d, b: 0.22618251551026347d, c: 0.7519857234888025d),

new NpgsqlTypes.NpgsqlLine(a: 0.5575754238782736d, b: 0.4864150209278515d, c: 0.5994509163354316d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7398617072256838d, b: 0.19336892145492435d, c: 0.9154924999738246d),

new NpgsqlTypes.NpgsqlLine(a: 0.39568642697984524d, b: 0.6852311498877508d, c: 0.5409134824100428d),

new NpgsqlTypes.NpgsqlLine(a: 0.9166183985541223d, b: 0.8716892401429565d, c: 0.19613949848748524d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03049873383791002d, b: 0.8035861497205082d, c: 0.6766704151917212d),

new NpgsqlTypes.NpgsqlLine(a: 0.3432758856111163d, b: 0.8434963312486213d, c: 0.10496404605344545d),

new NpgsqlTypes.NpgsqlLine(a: 0.9797001782629233d, b: 0.0020093695104017595d, c: 0.6482502701271592d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4230737473663394d, b: 0.3324493269064783d, c: 0.10694594101216082d),

new NpgsqlTypes.NpgsqlLine(a: 0.020637303479674518d, b: 0.8298865065968801d, c: 0.11631643085202137d),

new NpgsqlTypes.NpgsqlLine(a: 0.7275398335841683d, b: 0.5944831487165034d, c: 0.6919947998628436d),

new NpgsqlTypes.NpgsqlLine(a: 0.04846545192619156d, b: 0.35184325609529343d, c: 0.2655660390638569d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6527275271135472d, b: 0.2637956822743952d, c: 0.37366001705681107d),

new NpgsqlTypes.NpgsqlLine(a: 0.9976547514674445d, b: 0.010018925384318034d, c: 0.47982379256769603d),

new NpgsqlTypes.NpgsqlLine(a: 0.9464589641018384d, b: 0.5208986094250824d, c: 0.5483278857765401d),

new NpgsqlTypes.NpgsqlLine(a: 0.9068610992414234d, b: 0.2197497847093547d, c: 0.4715714690418942d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6742199622163814d, b: 0.47258036899031264d, c: 0.5836140398407328d),

new NpgsqlTypes.NpgsqlLine(a: 0.771055011282507d, b: 0.5833144431179083d, c: 0.513506926256694d),

new NpgsqlTypes.NpgsqlLine(a: 0.18411836633413092d, b: 0.8112242698837712d, c: 0.11142591094328846d),

new NpgsqlTypes.NpgsqlLine(a: 0.5839988400777376d, b: 0.336300267972373d, c: 0.08350232028673987d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29948438119165877d, b: 0.8500825806067227d, c: 0.9492890322937848d),

new NpgsqlTypes.NpgsqlLine(a: 0.457184986014339d, b: 0.06129679170781488d, c: 0.5609364878047234d),

new NpgsqlTypes.NpgsqlLine(a: 0.8855896045767103d, b: 0.10085245677326049d, c: 0.5230520313815262d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.600446468667675d, b: 0.3375891016692555d, c: 0.36264440637356743d),

new NpgsqlTypes.NpgsqlLine(a: 0.27761779788038465d, b: 0.11731519328256312d, c: 0.4074170706389104d),

new NpgsqlTypes.NpgsqlLine(a: 0.490008055205304d, b: 0.5922480638155098d, c: 0.98776224847391d),

new NpgsqlTypes.NpgsqlLine(a: 0.8419979438061144d, b: 0.2474857323067824d, c: 0.9450668328658889d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45076031507976566d, b: 0.5998886067124621d, c: 0.6526547673946133d),

new NpgsqlTypes.NpgsqlLine(a: 0.49664705836223133d, b: 0.4476303679944543d, c: 0.1605587600671342d),

new NpgsqlTypes.NpgsqlLine(a: 0.6036484241930081d, b: 0.7781696370995349d, c: 0.6554115107430423d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9998275021539245d, b: 0.7508136711925454d, c: 0.01865684599281947d),

new NpgsqlTypes.NpgsqlLine(a: 0.6959629897498731d, b: 0.4132945289204827d, c: 0.9914870216228416d),

new NpgsqlTypes.NpgsqlLine(a: 0.810168813763761d, b: 0.6472988369968392d, c: 0.2701507958205701d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44362159511234067d, b: 0.9960521034432881d, c: 0.9779316457872557d),

new NpgsqlTypes.NpgsqlLine(a: 0.9553491105983308d, b: 0.71981937973525d, c: 0.9302896455613705d),

new NpgsqlTypes.NpgsqlLine(a: 0.9867574814654739d, b: 0.6458770910260309d, c: 0.3056761634915921d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5782075553064353d, b: 0.5068630752888968d, c: 0.6735413832353137d),

new NpgsqlTypes.NpgsqlLine(a: 0.9833932153778453d, b: 0.15275625705820517d, c: 0.29020751593808647d),

new NpgsqlTypes.NpgsqlLine(a: 0.898988371609395d, b: 0.505847874329319d, c: 0.5859682154211351d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02925403149931205d, b: 0.8768863870010715d, c: 0.25334485389710926d),

new NpgsqlTypes.NpgsqlLine(a: 0.956110060605515d, b: 0.7759911131989436d, c: 0.28900950374675527d),

new NpgsqlTypes.NpgsqlLine(a: 0.6304362989805438d, b: 0.5973124152186722d, c: 0.9542715979154963d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16974006476292314d, b: 0.1926950612650138d, c: 0.15569526607708806d),

new NpgsqlTypes.NpgsqlLine(a: 0.9028730558897506d, b: 0.8304336278677024d, c: 0.45788615209456374d),

new NpgsqlTypes.NpgsqlLine(a: 0.5825004029381992d, b: 0.28948632533950625d, c: 0.03208061092406955d),

new NpgsqlTypes.NpgsqlLine(a: 0.5657557097180856d, b: 0.4338886395785849d, c: 0.5741113448715269d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09712066648569917d, b: 0.4659728974812839d, c: 0.9835986883689964d),

new NpgsqlTypes.NpgsqlLine(a: 0.6315491654517055d, b: 0.6226378093755401d, c: 0.34193784843993347d),

new NpgsqlTypes.NpgsqlLine(a: 0.5719013295261853d, b: 0.922709715229576d, c: 0.6021347734493708d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48661008076323453d, b: 0.9068604692581766d, c: 0.3583296814461234d),

new NpgsqlTypes.NpgsqlLine(a: 0.7819925376589322d, b: 0.8801406637473767d, c: 0.8917503600542557d),

new NpgsqlTypes.NpgsqlLine(a: 0.25567810858799456d, b: 0.8564086230358422d, c: 0.5269560254388876d),

new NpgsqlTypes.NpgsqlLine(a: 0.7954052040759209d, b: 0.9340568275978548d, c: 0.840960731541085d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7013897494093603d, b: 0.6047395434089877d, c: 0.007841356114589804d),

new NpgsqlTypes.NpgsqlLine(a: 0.40225944987505136d, b: 0.48175903316072644d, c: 0.05859631480203298d),

new NpgsqlTypes.NpgsqlLine(a: 0.05500066472508858d, b: 0.25220893129104405d, c: 0.10103287714890041d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03910304431735556d, b: 0.976708589386837d, c: 0.4886728149477151d),

new NpgsqlTypes.NpgsqlLine(a: 0.8823151405431112d, b: 0.8275963894310948d, c: 0.12262939501438463d),

new NpgsqlTypes.NpgsqlLine(a: 0.6097050998285491d, b: 0.18960743736904928d, c: 0.6215986055258889d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.723588696618132d, b: 0.11629183709619006d, c: 0.4760825230102014d),

new NpgsqlTypes.NpgsqlLine(a: 0.34234267356620807d, b: 0.8941576600845884d, c: 0.3975240455649972d),

new NpgsqlTypes.NpgsqlLine(a: 0.9814223592610921d, b: 0.8764999342241354d, c: 0.44380537093293815d),

new NpgsqlTypes.NpgsqlLine(a: 0.7256541444166309d, b: 0.3644179331638132d, c: 0.2946132435042208d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14459334187208106d, b: 0.0773280651415732d, c: 0.2160140682019548d),

new NpgsqlTypes.NpgsqlLine(a: 0.634177279835452d, b: 0.3562021252215489d, c: 0.09881159500355119d),

new NpgsqlTypes.NpgsqlLine(a: 0.14879093276114486d, b: 0.0036333714007742435d, c: 0.1569715437950583d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7681190759409275d, b: 0.6302850953538065d, c: 0.07432707563339824d),

new NpgsqlTypes.NpgsqlLine(a: 0.15868634638275791d, b: 0.7307324305109012d, c: 0.4649870738634443d),

new NpgsqlTypes.NpgsqlLine(a: 0.3237065444186594d, b: 0.9928276184858777d, c: 0.6689178178142006d),

new NpgsqlTypes.NpgsqlLine(a: 0.6960883212697646d, b: 0.05195588293147435d, c: 0.0885116966471764d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34524854424176576d, b: 0.004299506455320512d, c: 0.30617136714668025d),

new NpgsqlTypes.NpgsqlLine(a: 0.8125035855655324d, b: 0.26255620385858336d, c: 0.6727510797722571d),

new NpgsqlTypes.NpgsqlLine(a: 0.6122610971710708d, b: 0.43453309797050366d, c: 0.1285418456566545d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3421318576187298d, b: 0.37197882625003487d, c: 0.9150246549625081d),

new NpgsqlTypes.NpgsqlLine(a: 0.0280775563593455d, b: 0.7875583796620476d, c: 0.17850109038192974d),

new NpgsqlTypes.NpgsqlLine(a: 0.902068166994754d, b: 0.17512713019413217d, c: 0.5578497270572829d),

new NpgsqlTypes.NpgsqlLine(a: 0.305448583409506d, b: 0.7342238388493822d, c: 0.21390661799460842d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7360495877510432d, b: 0.1818488731456669d, c: 0.32520375497388054d),

new NpgsqlTypes.NpgsqlLine(a: 0.5832526273703579d, b: 0.5484807146821759d, c: 0.8671113824136849d),

new NpgsqlTypes.NpgsqlLine(a: 0.3835860812237244d, b: 0.3853683963755905d, c: 0.9700886052555202d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9403973415759719d, b: 0.1688850952922165d, c: 0.24536995656127014d),

new NpgsqlTypes.NpgsqlLine(a: 0.30776674457303577d, b: 0.44734891818875233d, c: 0.32811282018448584d),

new NpgsqlTypes.NpgsqlLine(a: 0.5487048100273823d, b: 0.22221086905051013d, c: 0.8692531933701578d),

new NpgsqlTypes.NpgsqlLine(a: 0.056370322464112776d, b: 0.6137899306140833d, c: 0.7469383242717815d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4901785126564806d, b: 0.06310278817434578d, c: 0.07725554287419423d),

new NpgsqlTypes.NpgsqlLine(a: 0.6249706195802063d, b: 0.8467131235388599d, c: 0.9821541957433841d),

new NpgsqlTypes.NpgsqlLine(a: 0.1561835158223418d, b: 0.05549490892632658d, c: 0.3377099911967921d),

new NpgsqlTypes.NpgsqlLine(a: 0.3813909720413369d, b: 0.5087633434985809d, c: 0.24572219444733412d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3263572009542508d, b: 0.7604982921837823d, c: 0.9451793994013132d),

new NpgsqlTypes.NpgsqlLine(a: 0.6935137469112267d, b: 0.11360881603391115d, c: 0.8620182622141639d),

new NpgsqlTypes.NpgsqlLine(a: 0.5955815443390488d, b: 0.8546423426226178d, c: 0.7660635400590858d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4501525009048568d, b: 0.9329426138795498d, c: 0.6082677204516906d),

new NpgsqlTypes.NpgsqlLine(a: 0.3914372558132575d, b: 0.7843494592316967d, c: 0.5868575291095336d),

new NpgsqlTypes.NpgsqlLine(a: 0.334426764573887d, b: 0.0684675932320652d, c: 0.06654680240643529d),

new NpgsqlTypes.NpgsqlLine(a: 0.04147760090783048d, b: 0.06997279130008893d, c: 0.485202335606963d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9728566654775177d, b: 0.8200353222424327d, c: 0.1426731941457563d),

new NpgsqlTypes.NpgsqlLine(a: 0.3114744821720421d, b: 0.21263148023972045d, c: 0.8199489473055932d),

new NpgsqlTypes.NpgsqlLine(a: 0.6765403363788439d, b: 0.6003121652101415d, c: 0.054334083851397486d),

new NpgsqlTypes.NpgsqlLine(a: 0.6972698361144628d, b: 0.2755826450498251d, c: 0.7337609499976762d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.01943091018172416d, b: 0.5202501945107536d, c: 0.06750583019261835d),

new NpgsqlTypes.NpgsqlLine(a: 0.4250563794034862d, b: 0.6388884384072635d, c: 0.6846439378655603d),

new NpgsqlTypes.NpgsqlLine(a: 0.06189693747588754d, b: 0.8886919960903829d, c: 0.8152070856604061d),

new NpgsqlTypes.NpgsqlLine(a: 0.19114272090193518d, b: 0.9410343881147409d, c: 0.4795153641401563d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20939337568845962d, b: 0.42518643837721104d, c: 0.7338195772830907d),

new NpgsqlTypes.NpgsqlLine(a: 0.07729209831510864d, b: 0.8481526488396095d, c: 0.6945171836862671d),

new NpgsqlTypes.NpgsqlLine(a: 0.02030406298608578d, b: 0.5812272703761364d, c: 0.23859177427398204d),

new NpgsqlTypes.NpgsqlLine(a: 0.377098837470383d, b: 0.25067552659198744d, c: 0.38092697765173955d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9987855782419711d, b: 0.31476276484589016d, c: 0.18108414602348277d),

new NpgsqlTypes.NpgsqlLine(a: 0.2853719786461666d, b: 0.008682656525480614d, c: 0.8211938693200181d),

new NpgsqlTypes.NpgsqlLine(a: 0.654922737580274d, b: 0.17889619303926663d, c: 0.5212869460345911d),

new NpgsqlTypes.NpgsqlLine(a: 0.6703926234139999d, b: 0.2944500784531142d, c: 0.49800828380243856d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6143902799765935d, b: 0.007787713711538191d, c: 0.8421692868828263d),

new NpgsqlTypes.NpgsqlLine(a: 0.7357705425206179d, b: 0.23021104470010278d, c: 0.5640315373724274d),

new NpgsqlTypes.NpgsqlLine(a: 0.8265706382943682d, b: 0.5817208563530039d, c: 0.018634862819435716d),

new NpgsqlTypes.NpgsqlLine(a: 0.11832195453940775d, b: 0.2594582503806053d, c: 0.6927328906145356d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4753539647385141d, b: 0.6626698677599024d, c: 0.8701068831964777d),

new NpgsqlTypes.NpgsqlLine(a: 0.9883557346715152d, b: 0.026205888008445366d, c: 0.5243628654598469d),

new NpgsqlTypes.NpgsqlLine(a: 0.20984638803325284d, b: 0.04956705847840581d, c: 0.38682149668402255d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15704621793669082d, b: 0.01577068851648844d, c: 0.8710175881681553d),

new NpgsqlTypes.NpgsqlLine(a: 0.30418648852675045d, b: 0.514014759382774d, c: 0.2250483943132855d),

new NpgsqlTypes.NpgsqlLine(a: 0.19053326977673546d, b: 0.7919387247481223d, c: 0.25330798124122d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3115663879046482d, b: 0.1841290493325849d, c: 0.5929051146851004d),

new NpgsqlTypes.NpgsqlLine(a: 0.17144014554222153d, b: 0.01830084941445609d, c: 0.6068710752898143d),

new NpgsqlTypes.NpgsqlLine(a: 0.962512298137554d, b: 0.860581690753569d, c: 0.8200677989032359d),

new NpgsqlTypes.NpgsqlLine(a: 0.21708449492591908d, b: 0.4944682218111204d, c: 0.6725937945837513d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7316311004028805d, b: 0.8417959714718846d, c: 0.6202876696589664d),

new NpgsqlTypes.NpgsqlLine(a: 0.9858313387570994d, b: 0.8705191139598144d, c: 0.020309663846934667d),

new NpgsqlTypes.NpgsqlLine(a: 0.4146444318249275d, b: 0.29822127950144606d, c: 0.5838721173087075d),

new NpgsqlTypes.NpgsqlLine(a: 0.5036508880876923d, b: 0.5902845961026155d, c: 0.5168294701376029d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7126263068770058d, b: 0.3514604177691194d, c: 0.03913848630216743d),

new NpgsqlTypes.NpgsqlLine(a: 0.6619881542021206d, b: 0.9877632392541587d, c: 0.021637091175126466d),

new NpgsqlTypes.NpgsqlLine(a: 0.4954129615367162d, b: 0.013242509853206075d, c: 0.784253288121456d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7234821011524687d, b: 0.882384474718273d, c: 0.11437479252417748d),

new NpgsqlTypes.NpgsqlLine(a: 0.7005746520500881d, b: 0.03581396330871889d, c: 0.061487730233739324d),

new NpgsqlTypes.NpgsqlLine(a: 0.16196858019853866d, b: 0.6629823320781861d, c: 0.8073424737494851d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7728946205455386d, b: 0.5834921913049499d, c: 0.9306357227370358d),

new NpgsqlTypes.NpgsqlLine(a: 0.5477782001472754d, b: 0.8401518296543515d, c: 0.12359019343966138d),

new NpgsqlTypes.NpgsqlLine(a: 0.7229817291514323d, b: 0.6894082613484522d, c: 0.8309798107120717d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3959146326959071d, b: 0.15767446868412682d, c: 0.843631712456417d),

new NpgsqlTypes.NpgsqlLine(a: 0.21645265974351646d, b: 0.6743427315033377d, c: 0.39335851319635606d),

new NpgsqlTypes.NpgsqlLine(a: 0.9146169868462196d, b: 0.015434209427292123d, c: 0.08647001063314685d),

new NpgsqlTypes.NpgsqlLine(a: 0.10032352493397845d, b: 0.8737502793977244d, c: 0.486304536149609d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3971210283972981d, b: 0.4489756489816267d, c: 0.6657911736176899d),

new NpgsqlTypes.NpgsqlLine(a: 0.8023767204519993d, b: 0.6057119165152796d, c: 0.15963346939101497d),

new NpgsqlTypes.NpgsqlLine(a: 0.4321653952478778d, b: 0.8580966404730259d, c: 0.8865358129649504d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04566769892917222d, b: 0.09588032541561375d, c: 0.7157713988862482d),

new NpgsqlTypes.NpgsqlLine(a: 0.9719227338289531d, b: 0.17112637448898427d, c: 0.9492021704169614d),

new NpgsqlTypes.NpgsqlLine(a: 0.7080008223134521d, b: 0.48529985910938733d, c: 0.6801391300123869d),

new NpgsqlTypes.NpgsqlLine(a: 0.16838214428021225d, b: 0.6445844603093038d, c: 0.27781763835028905d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8169305399499266d, b: 0.8771731757237684d, c: 0.11498762844084132d),

new NpgsqlTypes.NpgsqlLine(a: 0.19525296663361003d, b: 0.9558703783205258d, c: 0.46179214019379344d),

new NpgsqlTypes.NpgsqlLine(a: 0.5228822763891074d, b: 0.5846651872690036d, c: 0.8681534412742112d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7522941603394911d, b: 0.3748132516778572d, c: 0.057775072283008155d),

new NpgsqlTypes.NpgsqlLine(a: 0.1205841529652375d, b: 0.027983211135514385d, c: 0.02428730395180745d),

new NpgsqlTypes.NpgsqlLine(a: 0.4535898878629707d, b: 0.6243819604319324d, c: 0.44367112474794645d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8865056578001619d, b: 0.23224241546158508d, c: 0.6756569486875357d),

new NpgsqlTypes.NpgsqlLine(a: 0.7937445045362537d, b: 0.8496947476172384d, c: 0.2739805410248909d),

new NpgsqlTypes.NpgsqlLine(a: 0.8486276805811765d, b: 0.4398630809131562d, c: 0.3109908120888849d),

new NpgsqlTypes.NpgsqlLine(a: 0.4851111657703161d, b: 0.855006900302773d, c: 0.6172681198108907d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 153, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 15, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 21, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 76, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 34, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

