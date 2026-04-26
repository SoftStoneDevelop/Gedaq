

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8399006495599005d,right: 0.8785089343985792d,bottom: 0.00040981128138051215d,left: 0.5146868320565924d),

new NpgsqlTypes.NpgsqlBox(top: 0.4040877329453786d,right: 0.9537541169455436d,bottom: 0.23296988089026394d,left: 0.0062712832545720465d),

new NpgsqlTypes.NpgsqlBox(top: 0.2484671004886d,right: 0.9174558073534489d,bottom: 0.03919813209873946d,left: 0.6731179156045932d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49257574407015403d,right: 0.8842651073577721d,bottom: 0.3463278047996773d,left: 0.2777547054513333d),

new NpgsqlTypes.NpgsqlBox(top: 0.5908339021007257d,right: 0.08873629628273749d,bottom: 0.12709474551624778d,left: 0.07558233027713823d),

new NpgsqlTypes.NpgsqlBox(top: 0.6453368880570525d,right: 0.16700254731249864d,bottom: 0.2845958169328373d,left: 0.013351459214387296d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7334795620059377d,right: 0.8024867835756611d,bottom: 0.5778426827622074d,left: 0.31430401304097566d),

new NpgsqlTypes.NpgsqlBox(top: 0.29729638868500496d,right: 0.7572179862253909d,bottom: 0.06268561263379335d,left: 0.5695807281586196d),

new NpgsqlTypes.NpgsqlBox(top: 0.952681744210653d,right: 0.8902932222642247d,bottom: 0.8521924763551033d,left: 0.42991961974117876d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6666559428614612d,right: 0.9616791544335008d,bottom: 0.18797288492701225d,left: 0.10716710038081245d),

new NpgsqlTypes.NpgsqlBox(top: 0.9659807107741504d,right: 0.7392800370588655d,bottom: 0.10297348648089277d,left: 0.6601309345267871d),

new NpgsqlTypes.NpgsqlBox(top: 0.9126149325970023d,right: 0.12295634355060225d,bottom: 0.5833303562820386d,left: 0.009872520519163985d),

new NpgsqlTypes.NpgsqlBox(top: 0.2725510138110303d,right: 0.7410865600560052d,bottom: 0.17252279947752847d,left: 0.2218625747065326d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8165854417214756d,right: 0.9384035783368443d,bottom: 0.7623142829064637d,left: 0.39559710922918456d),

new NpgsqlTypes.NpgsqlBox(top: 0.26992031097798375d,right: 0.6685065199262878d,bottom: 0.25200922113366186d,left: 0.39398689206044946d),

new NpgsqlTypes.NpgsqlBox(top: 0.7569630504838236d,right: 0.9803510318660906d,bottom: 0.6368597322385773d,left: 0.13662878037733617d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7548671852659186d,right: 0.6318701981326955d,bottom: 0.6993613861345952d,left: 0.09750568268757731d),

new NpgsqlTypes.NpgsqlBox(top: 0.5994230267441444d,right: 0.9665554603594664d,bottom: 0.23152805866139448d,left: 0.613139868961417d),

new NpgsqlTypes.NpgsqlBox(top: 0.6114862703102533d,right: 0.7355641373665308d,bottom: 0.3840031350493446d,left: 0.5493411099029597d),

new NpgsqlTypes.NpgsqlBox(top: 0.718952083989866d,right: 0.8638724574235915d,bottom: 0.059245580166812695d,left: 0.16260360724720047d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44305947735374385d,right: 0.7859262174212587d,bottom: 0.3994825671708675d,left: 0.059537350955712776d),

new NpgsqlTypes.NpgsqlBox(top: 0.6786447362246192d,right: 0.4016811261284625d,bottom: 0.6094303999863434d,left: 0.3004736476497393d),

new NpgsqlTypes.NpgsqlBox(top: 0.958463600679605d,right: 0.7795785341061818d,bottom: 0.6503349041223248d,left: 0.595957654728246d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44370606925387435d,right: 0.32527549750400253d,bottom: 0.024247146055319746d,left: 0.02716275439259508d),

new NpgsqlTypes.NpgsqlBox(top: 0.9075861693676178d,right: 0.9414792142431851d,bottom: 0.17036090729349251d,left: 0.19437602141534294d),

new NpgsqlTypes.NpgsqlBox(top: 0.7882856709248702d,right: 0.2783547394465449d,bottom: 0.0028249007066727394d,left: 0.07594709871799976d),

new NpgsqlTypes.NpgsqlBox(top: 0.5818989991717649d,right: 0.3489705323797011d,bottom: 0.01617664030152699d,left: 0.1509263330643874d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.696328833737433d,right: 0.7643598054234767d,bottom: 0.09248393283293299d,left: 0.356915878068512d),

new NpgsqlTypes.NpgsqlBox(top: 0.620723559055628d,right: 0.7675614930299066d,bottom: 0.3936986397319935d,left: 0.6712302487341062d),

new NpgsqlTypes.NpgsqlBox(top: 0.9705271501720855d,right: 0.5453858686487907d,bottom: 0.4846143319648112d,left: 0.2474633062658126d),

new NpgsqlTypes.NpgsqlBox(top: 0.7995625614363754d,right: 0.7985124750780914d,bottom: 0.2672209011266147d,left: 0.6846652520686995d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9564159445581994d,right: 0.756441453517502d,bottom: 0.29570903127757386d,left: 0.039121046312198815d),

new NpgsqlTypes.NpgsqlBox(top: 0.960857979201865d,right: 0.7740378169983406d,bottom: 0.0020319721829380466d,left: 0.5637116995818873d),

new NpgsqlTypes.NpgsqlBox(top: 0.5494379610860389d,right: 0.6013700642481519d,bottom: 0.3080655777919319d,left: 0.27659377582798506d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.841689265973865d,right: 0.20450811189496365d,bottom: 0.04324796936534048d,left: 0.15906769205272087d),

new NpgsqlTypes.NpgsqlBox(top: 0.7543191695751553d,right: 0.608400431435958d,bottom: 0.09345551402429297d,left: 0.09007094524193149d),

new NpgsqlTypes.NpgsqlBox(top: 0.9485407589522572d,right: 0.6807689676288654d,bottom: 0.11114238905455864d,left: 0.10234849701428583d),

new NpgsqlTypes.NpgsqlBox(top: 0.15169056091580624d,right: 0.26392888223846744d,bottom: 0.12925695573366758d,left: 0.030930686794493956d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5067767280833505d,right: 0.7768604058400218d,bottom: 0.10055148314476403d,left: 0.4380625143594482d),

new NpgsqlTypes.NpgsqlBox(top: 0.39985347903438107d,right: 0.7300971559142031d,bottom: 0.1854920822389522d,left: 0.08258711154874032d),

new NpgsqlTypes.NpgsqlBox(top: 0.8054206675997335d,right: 0.8903528495829126d,bottom: 0.3845854154481616d,left: 0.6265400201285712d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5134663024939272d,right: 0.8765137926321744d,bottom: 0.17244303324726296d,left: 0.11421786436846137d),

new NpgsqlTypes.NpgsqlBox(top: 0.788661330614152d,right: 0.9691295132416023d,bottom: 0.6886790324141397d,left: 0.2939211336401424d),

new NpgsqlTypes.NpgsqlBox(top: 0.8034682809104843d,right: 0.08296431032755025d,bottom: 0.5916588785357997d,left: 0.06742428984266402d),

new NpgsqlTypes.NpgsqlBox(top: 0.8505019121076571d,right: 0.7078862628417304d,bottom: 0.557978316959424d,left: 0.1645513968642559d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5232128969108824d,right: 0.7009649673049035d,bottom: 0.18148002249381956d,left: 0.37866352790588453d),

new NpgsqlTypes.NpgsqlBox(top: 0.5829636360341076d,right: 0.9043456894413537d,bottom: 0.04754410384044194d,left: 0.3816349905433919d),

new NpgsqlTypes.NpgsqlBox(top: 0.9894494342632754d,right: 0.21696718787348002d,bottom: 0.413629091421453d,left: 0.0025428237250259d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6307487180915784d,right: 0.6255051616825391d,bottom: 0.41110457507813736d,left: 0.618824627104782d),

new NpgsqlTypes.NpgsqlBox(top: 0.8895427789101517d,right: 0.8666088333661499d,bottom: 0.6180076342761602d,left: 0.1345308218128286d),

new NpgsqlTypes.NpgsqlBox(top: 0.9218506152233524d,right: 0.6307897407727552d,bottom: 0.8973282508919235d,left: 0.5647813547649192d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8963240079236665d,right: 0.4847730917266807d,bottom: 0.6097851737724592d,left: 0.3084392360139071d),

new NpgsqlTypes.NpgsqlBox(top: 0.6162148166546826d,right: 0.8806938002464378d,bottom: 0.21362372973540555d,left: 0.0025079219698745936d),

new NpgsqlTypes.NpgsqlBox(top: 0.3505920169395127d,right: 0.929412994625959d,bottom: 0.2070790246380877d,left: 0.019444539472356803d),

new NpgsqlTypes.NpgsqlBox(top: 0.9091501800827931d,right: 0.8509075741378896d,bottom: 0.7240789699925252d,left: 0.5171587617327993d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6740848405199857d,right: 0.5809610585332365d,bottom: 0.3516639871887445d,left: 0.23097711841946844d),

new NpgsqlTypes.NpgsqlBox(top: 0.9088419685856028d,right: 0.8105245303601925d,bottom: 0.6470789998724166d,left: 0.3011479915884182d),

new NpgsqlTypes.NpgsqlBox(top: 0.3039684941846956d,right: 0.45760226599960097d,bottom: 0.11983163385022566d,left: 0.04523837275211351d),

new NpgsqlTypes.NpgsqlBox(top: 0.6278687869825677d,right: 0.5703134712512534d,bottom: 0.2827048838115389d,left: 0.21544769159745536d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.535551978505603d,right: 0.7640031041476547d,bottom: 0.01965768099989651d,left: 0.6514032156076836d),

new NpgsqlTypes.NpgsqlBox(top: 0.7884655378361443d,right: 0.9610502003670013d,bottom: 0.612948325079724d,left: 0.2795383127422858d),

new NpgsqlTypes.NpgsqlBox(top: 0.7103345063335554d,right: 0.6749192253511686d,bottom: 0.28608002962628054d,left: 0.5664632887612165d),

new NpgsqlTypes.NpgsqlBox(top: 0.5640372300926555d,right: 0.7206078273231421d,bottom: 0.1750811657306015d,left: 0.16319586794858576d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7913336088532091d,right: 0.9966531063855616d,bottom: 0.5675451796096751d,left: 0.17990160675592637d),

new NpgsqlTypes.NpgsqlBox(top: 0.732968233834462d,right: 0.7307074828935327d,bottom: 0.28419267066232057d,left: 0.3025758863310043d),

new NpgsqlTypes.NpgsqlBox(top: 0.43742146039350527d,right: 0.9864510866548867d,bottom: 0.3955941977841444d,left: 0.7053538852556457d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49803963153598296d,right: 0.9907518316598867d,bottom: 0.21106390355039828d,left: 0.653121584599267d),

new NpgsqlTypes.NpgsqlBox(top: 0.5246929583205112d,right: 0.3239829596604037d,bottom: 0.18336680752989887d,left: 0.013083942643697721d),

new NpgsqlTypes.NpgsqlBox(top: 0.8461979851182146d,right: 0.7210019702870683d,bottom: 0.44920168561809104d,left: 0.032347240271190514d),

new NpgsqlTypes.NpgsqlBox(top: 0.7032487157787723d,right: 0.23756912213942638d,bottom: 0.625652894130421d,left: 0.14014921059126817d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7900140590297311d,right: 0.4451786822147794d,bottom: 0.0784421424782269d,left: 0.05280659778557728d),

new NpgsqlTypes.NpgsqlBox(top: 0.6144883642919925d,right: 0.9187082684099178d,bottom: 0.5497281252317004d,left: 0.6640988171019602d),

new NpgsqlTypes.NpgsqlBox(top: 0.6833565177700859d,right: 0.6001456379243021d,bottom: 0.20215097678441551d,left: 0.5854506559181032d),

new NpgsqlTypes.NpgsqlBox(top: 0.9451456618664563d,right: 0.8831715853386175d,bottom: 0.08190201343621673d,left: 0.13783746734299707d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39739224568710085d,right: 0.8897534702466549d,bottom: 0.304420605257399d,left: 0.4698018235528555d),

new NpgsqlTypes.NpgsqlBox(top: 0.65570404251334d,right: 0.8242129201707139d,bottom: 0.30744599436728237d,left: 0.5049889859548974d),

new NpgsqlTypes.NpgsqlBox(top: 0.4532799673513841d,right: 0.650070294825381d,bottom: 0.013918346441621599d,left: 0.00398061374837011d),

new NpgsqlTypes.NpgsqlBox(top: 0.42175636245265236d,right: 0.7819149599086924d,bottom: 0.35285660248338024d,left: 0.02655667368493375d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9193980074525636d,right: 0.5248469739768764d,bottom: 0.002266917893337106d,left: 0.13924877256852086d),

new NpgsqlTypes.NpgsqlBox(top: 0.8631482671636279d,right: 0.5573596323130193d,bottom: 0.2285258093889765d,left: 0.42004873712601354d),

new NpgsqlTypes.NpgsqlBox(top: 0.5153093199460298d,right: 0.2927988430830921d,bottom: 0.019173126979566635d,left: 0.12153143417829526d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6703782989714299d,right: 0.9606149362169557d,bottom: 0.07790833430192401d,left: 0.5551507745598883d),

new NpgsqlTypes.NpgsqlBox(top: 0.4863568523186239d,right: 0.925261907218878d,bottom: 0.4457292176566213d,left: 0.29607342354696575d),

new NpgsqlTypes.NpgsqlBox(top: 0.6580611904364384d,right: 0.5985470589395531d,bottom: 0.2155693697140414d,left: 0.3987780679041594d),

new NpgsqlTypes.NpgsqlBox(top: 0.7601236066611067d,right: 0.6597629499627782d,bottom: 0.6385174915519678d,left: 0.5879389696676759d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4262935112272721d,right: 0.17198131159544505d,bottom: 0.08115674449458454d,left: 0.1686353403786538d),

new NpgsqlTypes.NpgsqlBox(top: 0.7749201570157597d,right: 0.4378259006022831d,bottom: 0.34790573153221493d,left: 0.19590694342437698d),

new NpgsqlTypes.NpgsqlBox(top: 0.8457961664797355d,right: 0.9254028317002084d,bottom: 0.5119337005690735d,left: 0.33091569202274385d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.715340054173559d,right: 0.4210655694633052d,bottom: 0.22054119188505594d,left: 0.312397486002819d),

new NpgsqlTypes.NpgsqlBox(top: 0.7833714756242098d,right: 0.7044803092092133d,bottom: 0.02150449053548209d,left: 0.21209123121007456d),

new NpgsqlTypes.NpgsqlBox(top: 0.6150518593532043d,right: 0.8122535519179683d,bottom: 0.18530474612087955d,left: 0.6013588341159909d),

new NpgsqlTypes.NpgsqlBox(top: 0.9393319473827172d,right: 0.9587467599486139d,bottom: 0.6737274630703299d,left: 0.157198962362875d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36836702624447937d,right: 0.5176960961996737d,bottom: 0.06677254175109104d,left: 0.4212009004171696d),

new NpgsqlTypes.NpgsqlBox(top: 0.6870228978837511d,right: 0.8755282062848344d,bottom: 0.13049877076501215d,left: 0.6799334815982527d),

new NpgsqlTypes.NpgsqlBox(top: 0.510484851651512d,right: 0.6959901443077141d,bottom: 0.19857040333006704d,left: 0.23280323050817198d),

new NpgsqlTypes.NpgsqlBox(top: 0.6515655263518684d,right: 0.28393499921847676d,bottom: 0.09139112920940529d,left: 0.12113606993854242d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6368400311342848d,right: 0.9786456551657066d,bottom: 0.13517738420263203d,left: 0.1262034139797178d),

new NpgsqlTypes.NpgsqlBox(top: 0.35718209554445d,right: 0.7162024250108572d,bottom: 0.17205626982410593d,left: 0.5436880524606601d),

new NpgsqlTypes.NpgsqlBox(top: 0.5244743358213525d,right: 0.8678161367218462d,bottom: 0.2929035507940616d,left: 0.8319599964172085d),

new NpgsqlTypes.NpgsqlBox(top: 0.9201816044851003d,right: 0.0902503282366034d,bottom: 0.5895582397954439d,left: 0.08064246978469536d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9499004849777344d,right: 0.5257098477233654d,bottom: 0.8821634936731644d,left: 0.2059910488400889d),

new NpgsqlTypes.NpgsqlBox(top: 0.678773171851455d,right: 0.23459118276974533d,bottom: 0.6664230553056439d,left: 0.12353063578005263d),

new NpgsqlTypes.NpgsqlBox(top: 0.6388421516831551d,right: 0.8157394916651851d,bottom: 0.12510412696804718d,left: 0.653420517084389d),

new NpgsqlTypes.NpgsqlBox(top: 0.9683973189992255d,right: 0.19286682141071054d,bottom: 0.4300428659104102d,left: 0.03980603042675801d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.24851756263414815d,right: 0.9530664160987365d,bottom: 0.05658522707918012d,left: 0.1906128599862994d),

new NpgsqlTypes.NpgsqlBox(top: 0.5668187144766001d,right: 0.424209975163921d,bottom: 0.23212896959462037d,left: 0.3756665916332057d),

new NpgsqlTypes.NpgsqlBox(top: 0.5046021976228282d,right: 0.23580413980398784d,bottom: 0.2521587081225143d,left: 0.19675722977974297d),

new NpgsqlTypes.NpgsqlBox(top: 0.3143535193795505d,right: 0.5262057911206454d,bottom: 0.21388580062919926d,left: 0.4955984088233282d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3942399466213947d,right: 0.17771403959700238d,bottom: 0.28755735968785956d,left: 0.03108118233375179d),

new NpgsqlTypes.NpgsqlBox(top: 0.8566718672634059d,right: 0.5914538275355679d,bottom: 0.6259322251124085d,left: 0.2581567563017072d),

new NpgsqlTypes.NpgsqlBox(top: 0.517674546226067d,right: 0.7647991919139705d,bottom: 0.14736072329957295d,left: 0.6831382750980804d),

new NpgsqlTypes.NpgsqlBox(top: 0.8185501089654204d,right: 0.6822040823331902d,bottom: 0.405839188092181d,left: 0.5975279170848067d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9169943321354356d,right: 0.8579892902390104d,bottom: 0.21320768545664714d,left: 0.5012298103185606d),

new NpgsqlTypes.NpgsqlBox(top: 0.764294196065247d,right: 0.9805285274759233d,bottom: 0.45126632429758096d,left: 0.6863934104673929d),

new NpgsqlTypes.NpgsqlBox(top: 0.6987413562975826d,right: 0.9067151113132986d,bottom: 0.6450742647789871d,left: 0.48601444279199213d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6233877426092049d,right: 0.9458268783978178d,bottom: 0.3919053270989602d,left: 0.2994845392397705d),

new NpgsqlTypes.NpgsqlBox(top: 0.8560965093007267d,right: 0.8451309881214949d,bottom: 0.3812526529791709d,left: 0.26797636515933476d),

new NpgsqlTypes.NpgsqlBox(top: 0.581568774205688d,right: 0.6307966403013552d,bottom: 0.10935962980613134d,left: 0.4245739246584491d),

new NpgsqlTypes.NpgsqlBox(top: 0.7938344168404883d,right: 0.999252075699008d,bottom: 0.34764368352277464d,left: 0.856845685076742d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1930564829241116d,right: 0.41413706037758236d,bottom: 0.08403968046350208d,left: 0.12281137174982626d),

new NpgsqlTypes.NpgsqlBox(top: 0.9464523235860138d,right: 0.107432632059691d,bottom: 0.3247763440075375d,left: 0.012349842239309572d),

new NpgsqlTypes.NpgsqlBox(top: 0.8025040485144408d,right: 0.6458515764909424d,bottom: 0.1302009387688603d,left: 0.5836985418243278d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7078318373091463d,right: 0.8395112645588989d,bottom: 0.612360578477192d,left: 0.37405302705295085d),

new NpgsqlTypes.NpgsqlBox(top: 0.2672583028491743d,right: 0.23365991125375507d,bottom: 0.029332301186529408d,left: 0.17440968077048524d),

new NpgsqlTypes.NpgsqlBox(top: 0.44239924742849845d,right: 0.6822558337710769d,bottom: 0.06161968679721386d,left: 0.16998812282080855d),

new NpgsqlTypes.NpgsqlBox(top: 0.9287438188504289d,right: 0.7054334443371129d,bottom: 0.7273481272257362d,left: 0.07614645916803242d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9463994420725156d,right: 0.9845742228461362d,bottom: 0.15325428344586156d,left: 0.6122992899243518d),

new NpgsqlTypes.NpgsqlBox(top: 0.5116607791657031d,right: 0.8951447310937298d,bottom: 0.012493630442346748d,left: 0.0030096513208729414d),

new NpgsqlTypes.NpgsqlBox(top: 0.6351624391131043d,right: 0.6865813911769311d,bottom: 0.5074901293310883d,left: 0.3767562393217927d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8229441858510863d,right: 0.7538737393492038d,bottom: 0.04188540410272856d,left: 0.05996026163181012d),

new NpgsqlTypes.NpgsqlBox(top: 0.8954117209756218d,right: 0.5663382987080134d,bottom: 0.7393831942110273d,left: 0.12662165752342736d),

new NpgsqlTypes.NpgsqlBox(top: 0.4792561653622791d,right: 0.4466543912469877d,bottom: 0.17613937862659335d,left: 0.24719556175979973d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49900843499596625d,right: 0.5743917704019262d,bottom: 0.006327511420112786d,left: 0.48879910631310863d),

new NpgsqlTypes.NpgsqlBox(top: 0.9168092766501434d,right: 0.32304369848755277d,bottom: 0.49538528587809827d,left: 0.2086911801151593d),

new NpgsqlTypes.NpgsqlBox(top: 0.8752226265894464d,right: 0.6368958643757384d,bottom: 0.23478971829874107d,left: 0.5029751988374496d),

new NpgsqlTypes.NpgsqlBox(top: 0.9307311241872781d,right: 0.30646690555232226d,bottom: 0.6154171154642338d,left: 0.09353423359621205d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7279028476783904d,right: 0.5159963460389542d,bottom: 0.18246145315125606d,left: 0.22974399330718154d),

new NpgsqlTypes.NpgsqlBox(top: 0.8535522198788646d,right: 0.619121709156409d,bottom: 0.015104876532068712d,left: 0.2864170844510907d),

new NpgsqlTypes.NpgsqlBox(top: 0.48781117400714535d,right: 0.7314816134264434d,bottom: 0.10758710771038782d,left: 0.2469889093661517d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9829160965146506d,right: 0.5637728901569115d,bottom: 0.29324503821004144d,left: 0.2770303365792691d),

new NpgsqlTypes.NpgsqlBox(top: 0.23426664762108196d,right: 0.6482229521316674d,bottom: 0.06291985800305189d,left: 0.22388072613466248d),

new NpgsqlTypes.NpgsqlBox(top: 0.4851736959374253d,right: 0.4031142904846262d,bottom: 0.034766433681564735d,left: 0.19457040427283567d),

new NpgsqlTypes.NpgsqlBox(top: 0.7540023089553206d,right: 0.6740033801186772d,bottom: 0.07816499169184954d,left: 0.3802040399037917d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8861645969345505d,right: 0.8815552827662496d,bottom: 0.2000856035571702d,left: 0.38553937972888863d),

new NpgsqlTypes.NpgsqlBox(top: 0.1227264018423132d,right: 0.7900738761629568d,bottom: 0.11400478182232399d,left: 0.44763664550496096d),

new NpgsqlTypes.NpgsqlBox(top: 0.8616510188070802d,right: 0.348770056970811d,bottom: 0.0924141659422959d,left: 0.22628038293629638d),

new NpgsqlTypes.NpgsqlBox(top: 0.8150145942534456d,right: 0.872116310459432d,bottom: 0.48380145188125545d,left: 0.8570613926198839d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8093936519379663d,right: 0.13727508336001837d,bottom: 0.06666645937709703d,left: 0.06636868358273007d),

new NpgsqlTypes.NpgsqlBox(top: 0.9110834493289455d,right: 0.7095647015862319d,bottom: 0.2935236953829701d,left: 0.40464334945138614d),

new NpgsqlTypes.NpgsqlBox(top: 0.808143144899793d,right: 0.7915741375346971d,bottom: 0.46995350245927225d,left: 0.061177490837267645d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9960116599166144d,right: 0.3593909202596658d,bottom: 0.41438725905174456d,left: 0.22486143444174456d),

new NpgsqlTypes.NpgsqlBox(top: 0.9303598423870181d,right: 0.7542882824016474d,bottom: 0.37559596287813246d,left: 0.6486572652601217d),

new NpgsqlTypes.NpgsqlBox(top: 0.3082990254718463d,right: 0.6868155976235042d,bottom: 0.09083193924037791d,left: 0.5769968723672868d),

new NpgsqlTypes.NpgsqlBox(top: 0.8563676451896154d,right: 0.5060017161172524d,bottom: 0.3118827950343547d,left: 0.3202070562221361d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37810670655780443d,right: 0.23948958685623511d,bottom: 0.19004050623496993d,left: 0.210722053629663d),

new NpgsqlTypes.NpgsqlBox(top: 0.5711084509877683d,right: 0.3791579365249099d,bottom: 0.5335557083666876d,left: 0.3459819872043073d),

new NpgsqlTypes.NpgsqlBox(top: 0.8764290432071604d,right: 0.9423488967209983d,bottom: 0.40006216860563915d,left: 0.8253050399695797d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.969641071332423d,right: 0.5859716257022073d,bottom: 0.5655411970006493d,left: 0.228415647578883d),

new NpgsqlTypes.NpgsqlBox(top: 0.9058429750299782d,right: 0.3400866410645593d,bottom: 0.6800881761663609d,left: 0.2648052471643052d),

new NpgsqlTypes.NpgsqlBox(top: 0.3101844994689764d,right: 0.7347244991999488d,bottom: 0.18566102446107235d,left: 0.0009646651937704753d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3589085044364203d,right: 0.6866049739541086d,bottom: 0.34051896080409105d,left: 0.15651761019155785d),

new NpgsqlTypes.NpgsqlBox(top: 0.6682703372734641d,right: 0.7834892034668945d,bottom: 0.2214353521597615d,left: 0.6263373066555776d),

new NpgsqlTypes.NpgsqlBox(top: 0.821786781521584d,right: 0.23511812706380908d,bottom: 0.5059031322351942d,left: 0.22144280773283276d),

new NpgsqlTypes.NpgsqlBox(top: 0.13275558201978432d,right: 0.659476963080819d,bottom: 0.0517134183268434d,left: 0.4943246189722821d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20117286074769392d,right: 0.8000288711424111d,bottom: 0.11906190185292409d,left: 0.15399395885081502d),

new NpgsqlTypes.NpgsqlBox(top: 0.7463217507445125d,right: 0.7800800202291034d,bottom: 0.0983787363816907d,left: 0.3733355787666238d),

new NpgsqlTypes.NpgsqlBox(top: 0.875267653099466d,right: 0.6496282766465277d,bottom: 0.7839846507351995d,left: 0.18047020176963324d),

new NpgsqlTypes.NpgsqlBox(top: 0.4190123035665605d,right: 0.5545302094175247d,bottom: 0.0516224384034204d,left: 0.19627843395992162d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7258755055776529d,right: 0.7140889997727354d,bottom: 0.4618122360393474d,left: 0.11534142341485121d),

new NpgsqlTypes.NpgsqlBox(top: 0.2307440486422503d,right: 0.7261913153725711d,bottom: 0.22805612536819264d,left: 0.6361336005787446d),

new NpgsqlTypes.NpgsqlBox(top: 0.5495538798988341d,right: 0.6721132121763714d,bottom: 0.5306186456133297d,left: 0.2241016122302798d),

new NpgsqlTypes.NpgsqlBox(top: 0.8269416209633285d,right: 0.7540974820426133d,bottom: 0.4350792756517854d,left: 0.5875049528209312d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8878887725528328d,right: 0.21428176940831567d,bottom: 0.06856204813032818d,left: 0.14242780728752602d),

new NpgsqlTypes.NpgsqlBox(top: 0.13276419716466958d,right: 0.9273038235240956d,bottom: 0.08084385381066928d,left: 0.043590661785379514d),

new NpgsqlTypes.NpgsqlBox(top: 0.7329521967996828d,right: 0.9008587577505627d,bottom: 0.4208835029490121d,left: 0.25664694729491055d),

new NpgsqlTypes.NpgsqlBox(top: 0.21834930125505347d,right: 0.9875178793388028d,bottom: 0.1568532172401924d,left: 0.6591001135363642d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41178939903953204d,right: 0.9314204522587302d,bottom: 0.19376502693761533d,left: 0.1991128361570189d),

new NpgsqlTypes.NpgsqlBox(top: 0.45163412532479696d,right: 0.8234984425034862d,bottom: 0.3382673666033976d,left: 0.2612303882453786d),

new NpgsqlTypes.NpgsqlBox(top: 0.43062505135077933d,right: 0.6766450397624973d,bottom: 0.3991664459761366d,left: 0.08828165530957244d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3997747563835984d,right: 0.4000911953201174d,bottom: 0.146593698012094d,left: 0.24505650579103821d),

new NpgsqlTypes.NpgsqlBox(top: 0.3841508666489425d,right: 0.7295175375814479d,bottom: 0.37011224192426406d,left: 0.6427175832759967d),

new NpgsqlTypes.NpgsqlBox(top: 0.9868202871126185d,right: 0.6472315244172854d,bottom: 0.7617200629585467d,left: 0.02611033218720349d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.27943556696780014d,right: 0.33430918289711764d,bottom: 0.11351342540339127d,left: 0.2557380024042365d),

new NpgsqlTypes.NpgsqlBox(top: 0.8336048202511281d,right: 0.6886842948702183d,bottom: 0.1405394019083116d,left: 0.2547506966714912d),

new NpgsqlTypes.NpgsqlBox(top: 0.7273487002750588d,right: 0.6183736913442329d,bottom: 0.3766662083273399d,left: 0.0068053941896397685d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22160107625654457d,right: 0.824888247966393d,bottom: 0.2215874328379237d,left: 0.764155274280417d),

new NpgsqlTypes.NpgsqlBox(top: 0.9273476069744693d,right: 0.9943967087923443d,bottom: 0.602861094180509d,left: 0.6022424779546764d),

new NpgsqlTypes.NpgsqlBox(top: 0.6529439078890897d,right: 0.7278145970050067d,bottom: 0.07630060528466498d,left: 0.2014584582468114d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8950435027475578d,right: 0.7424642124693972d,bottom: 0.6827495889817032d,left: 0.6561678254226051d),

new NpgsqlTypes.NpgsqlBox(top: 0.9804186074807755d,right: 0.7285212123552874d,bottom: 0.5526079299410994d,left: 0.38383785299369133d),

new NpgsqlTypes.NpgsqlBox(top: 0.44180460474962235d,right: 0.5793124048954503d,bottom: 0.14159096207672928d,left: 0.15631093864049816d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7083003632612958d,right: 0.6545250240314386d,bottom: 0.33228385886673706d,left: 0.01758045835417854d),

new NpgsqlTypes.NpgsqlBox(top: 0.15407769085536538d,right: 0.4460450763677245d,bottom: 0.15196409241157682d,left: 0.42445183669543807d),

new NpgsqlTypes.NpgsqlBox(top: 0.7507157117836178d,right: 0.16482167932592084d,bottom: 0.44554371637065104d,left: 0.09919949958776741d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7297994220527035d,right: 0.5446006675134794d,bottom: 0.4682523635586542d,left: 0.2446430895351539d),

new NpgsqlTypes.NpgsqlBox(top: 0.9245232792054915d,right: 0.12708947763795186d,bottom: 0.06217261758515191d,left: 0.06723847859113163d),

new NpgsqlTypes.NpgsqlBox(top: 0.43825499461694317d,right: 0.6248203444039256d,bottom: 0.32701600853025914d,left: 0.20092171334417075d),

new NpgsqlTypes.NpgsqlBox(top: 0.5764218671964239d,right: 0.9123354790452605d,bottom: 0.4792043062139788d,left: 0.5317489781829354d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6621850540160599d,right: 0.9640478085491373d,bottom: 0.6334728153571703d,left: 0.4043410031616832d),

new NpgsqlTypes.NpgsqlBox(top: 0.856761537356536d,right: 0.9632448596274547d,bottom: 0.2765496430525397d,left: 0.053708201969084324d),

new NpgsqlTypes.NpgsqlBox(top: 0.27229535503644475d,right: 0.9625916353488656d,bottom: 0.058888308201015205d,left: 0.3015320469752557d),

new NpgsqlTypes.NpgsqlBox(top: 0.7606566471787217d,right: 0.9303100136918889d,bottom: 0.4208578185550511d,left: 0.18081909661791584d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7866257798179092d,right: 0.8366515279534494d,bottom: 0.2547748079441652d,left: 0.548639572650324d),

new NpgsqlTypes.NpgsqlBox(top: 0.614911029641785d,right: 0.9956306586666348d,bottom: 0.30949405159373045d,left: 0.8647192087511244d),

new NpgsqlTypes.NpgsqlBox(top: 0.983960615842193d,right: 0.7293310955624419d,bottom: 0.621580394997566d,left: 0.4069616177657299d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.451547021481584d,right: 0.37027083439507635d,bottom: 0.30781379428953715d,left: 0.23191898763811447d),

new NpgsqlTypes.NpgsqlBox(top: 0.06126530783906359d,right: 0.6173855772202245d,bottom: 0.05348761783995537d,left: 0.586802208989154d),

new NpgsqlTypes.NpgsqlBox(top: 0.3301424956002753d,right: 0.7639965486847601d,bottom: 0.28127669096865593d,left: 0.015712695941384025d),

new NpgsqlTypes.NpgsqlBox(top: 0.4560951048732437d,right: 0.7657220226172791d,bottom: 0.3828374367631875d,left: 0.14965336399091744d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9931327971097463d,right: 0.5872697614023487d,bottom: 0.336424783997598d,left: 0.3557170437550595d),

new NpgsqlTypes.NpgsqlBox(top: 0.9355852861468179d,right: 0.6309438309185017d,bottom: 0.8892189396371453d,left: 0.11615835058023372d),

new NpgsqlTypes.NpgsqlBox(top: 0.9291526567949596d,right: 0.4285351221685112d,bottom: 0.9255772208140979d,left: 0.3807250123567524d),

new NpgsqlTypes.NpgsqlBox(top: 0.9120180393192705d,right: 0.5148509252508425d,bottom: 0.5349036770529613d,left: 0.44380578336447674d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8505954089033743d,right: 0.5037184528202814d,bottom: 0.4288522067759959d,left: 0.36527380616573d),

new NpgsqlTypes.NpgsqlBox(top: 0.8316481269658771d,right: 0.07067581351676033d,bottom: 0.5781875534508252d,left: 0.06963680181358722d),

new NpgsqlTypes.NpgsqlBox(top: 0.6999994030455303d,right: 0.3783939082640231d,bottom: 0.08772162104504411d,left: 0.11960471056350463d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9216718735428865d,right: 0.2167751037554213d,bottom: 0.2551609413052395d,left: 0.08911927728518976d),

new NpgsqlTypes.NpgsqlBox(top: 0.7571554009309838d,right: 0.5710551033411196d,bottom: 0.1597286415214585d,left: 0.4425688106257528d),

new NpgsqlTypes.NpgsqlBox(top: 0.6692127420994514d,right: 0.7419596404216425d,bottom: 0.48109015864605276d,left: 0.5644964386633065d),

new NpgsqlTypes.NpgsqlBox(top: 0.9972356992337151d,right: 0.11455532328680573d,bottom: 0.0011937198005405047d,left: 0.04651602912198116d),

},
},
    NullableValue = null,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 102, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 143, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 112, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

