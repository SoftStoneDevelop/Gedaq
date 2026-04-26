

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8338816367203697d,right: 0.6725671257030006d,bottom: 0.3621170796703611d,left: 0.4462735669446709d),
new NpgsqlTypes.NpgsqlBox(top: 0.9107984799725665d,right: 0.844268056873962d,bottom: 0.03934551320554991d,left: 0.08912967972268238d),
new NpgsqlTypes.NpgsqlBox(top: 0.6504418500523326d,right: 0.6188827639350997d,bottom: 0.21883665129287666d,left: 0.380210075996385d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6045062312138171d,right: 0.6526115230407813d,bottom: 0.5989286419056205d,left: 0.16488891704490716d),
new NpgsqlTypes.NpgsqlBox(top: 0.43691127981896305d,right: 0.4563542959643855d,bottom: 0.13025520250289913d,left: 0.05303846427098036d),
new NpgsqlTypes.NpgsqlBox(top: 0.13924853917110902d,right: 0.42036631049788264d,bottom: 0.08131270307578942d,left: 0.01611496248740807d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9184291798606777d,right: 0.7043604967007314d,bottom: 0.45744992952215224d,left: 0.3750021631106283d),
new NpgsqlTypes.NpgsqlBox(top: 0.8157805470240044d,right: 0.3889522167032706d,bottom: 0.14118042633289363d,left: 0.09276465751131013d),
new NpgsqlTypes.NpgsqlBox(top: 0.6446936839838446d,right: 0.7465130962898177d,bottom: 0.3416921400867736d,left: 0.4254481490393225d),
new NpgsqlTypes.NpgsqlBox(top: 0.9987355549468273d,right: 0.790126215147489d,bottom: 0.7669484846107193d,left: 0.013327488198607962d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.14344355839181788d,right: 0.7756144158379457d,bottom: 0.09887312706029605d,left: 0.5060481796637183d),
new NpgsqlTypes.NpgsqlBox(top: 0.3761485396550496d,right: 0.10103156065208252d,bottom: 0.27457611540944926d,left: 0.05038554378876725d),
new NpgsqlTypes.NpgsqlBox(top: 0.7999065840790613d,right: 0.7620601627306655d,bottom: 0.16690425075109017d,left: 0.12205936869192913d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5276046503523203d,right: 0.992564404625785d,bottom: 0.47775678900406215d,left: 0.8542110299433592d),
new NpgsqlTypes.NpgsqlBox(top: 0.45476455087863576d,right: 0.6315277047995204d,bottom: 0.10645928002251248d,left: 0.11166064816910659d),
new NpgsqlTypes.NpgsqlBox(top: 0.4859799539701771d,right: 0.5529519798047595d,bottom: 0.3311199015619032d,left: 0.008553171804020598d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6960534047154098d,right: 0.8866557176824268d,bottom: 0.36897498702328646d,left: 0.016426688374184928d),
new NpgsqlTypes.NpgsqlBox(top: 0.17601820503964694d,right: 0.9495536658186835d,bottom: 0.1465082961994263d,left: 0.5373691764374532d),
new NpgsqlTypes.NpgsqlBox(top: 0.5171933217247061d,right: 0.5256279941917574d,bottom: 0.1530440382852527d,left: 0.39299985511787294d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.09708126184065491d,right: 0.8208221022583942d,bottom: 0.011994209838995129d,left: 0.1885045496058394d),
new NpgsqlTypes.NpgsqlBox(top: 0.2806542912595975d,right: 0.7913997848900942d,bottom: 0.26597522569604226d,left: 0.01848363552124621d),
new NpgsqlTypes.NpgsqlBox(top: 0.22230709959123374d,right: 0.6776455512711154d,bottom: 0.08436695724011256d,left: 0.29838392187965734d),
new NpgsqlTypes.NpgsqlBox(top: 0.6381598817026236d,right: 0.37878571371103675d,bottom: 0.30960975922997813d,left: 0.1629440044446624d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44592314367856056d,right: 0.2785413248681933d,bottom: 0.30823172037171154d,left: 0.258339224291499d),
new NpgsqlTypes.NpgsqlBox(top: 0.3191289712565759d,right: 0.17035227524531282d,bottom: 0.08266499049226617d,left: 0.08049709944580297d),
new NpgsqlTypes.NpgsqlBox(top: 0.9040272633689019d,right: 0.8304318378625113d,bottom: 0.5069414984927867d,left: 0.2664424648574224d),
new NpgsqlTypes.NpgsqlBox(top: 0.9930750532267106d,right: 0.6443132951769623d,bottom: 0.782240113860335d,left: 0.5841250325255023d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32885596334843525d,right: 0.5844197356353931d,bottom: 0.283301186378371d,left: 0.5262658013519917d),
new NpgsqlTypes.NpgsqlBox(top: 0.7627708284904269d,right: 0.7560758543167309d,bottom: 0.3163357414112292d,left: 0.3596066333553979d),
new NpgsqlTypes.NpgsqlBox(top: 0.9670877170167719d,right: 0.8416582106325178d,bottom: 0.8194973723973312d,left: 0.4045312536351575d),
new NpgsqlTypes.NpgsqlBox(top: 0.8787317280459735d,right: 0.30660891031180404d,bottom: 0.4528398276850172d,left: 0.1664473888016057d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6402043147841703d,right: 0.4865135083580332d,bottom: 0.5812469898659907d,left: 0.016388407242060143d),
new NpgsqlTypes.NpgsqlBox(top: 0.8801645431027628d,right: 0.7042827993037538d,bottom: 0.04038232650065887d,left: 0.07091319342160707d),
new NpgsqlTypes.NpgsqlBox(top: 0.8398458112356867d,right: 0.8796656066611209d,bottom: 0.48571861220059076d,left: 0.5755409300830644d),
new NpgsqlTypes.NpgsqlBox(top: 0.950137486282507d,right: 0.9687936410279688d,bottom: 0.08165785376567947d,left: 0.15904196027343043d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19826569337263922d,right: 0.4292186984581432d,bottom: 0.004499398220898065d,left: 0.41030022488674d),
new NpgsqlTypes.NpgsqlBox(top: 0.57397448220255d,right: 0.46931564412026905d,bottom: 0.25487105375047114d,left: 0.28254671725362135d),
new NpgsqlTypes.NpgsqlBox(top: 0.6494116358709978d,right: 0.9906397412391096d,bottom: 0.5830699192865427d,left: 0.5999025062739234d),
new NpgsqlTypes.NpgsqlBox(top: 0.6439155774441521d,right: 0.3054021140178821d,bottom: 0.3058426385394748d,left: 0.12899613196767667d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6965550148031873d,right: 0.9761801745366301d,bottom: 0.590193124546863d,left: 0.3517160794753562d),
new NpgsqlTypes.NpgsqlBox(top: 0.958314419108237d,right: 0.8106692357897695d,bottom: 0.5833879485814835d,left: 0.6134301597438383d),
new NpgsqlTypes.NpgsqlBox(top: 0.35433222293143796d,right: 0.8579022285487579d,bottom: 0.04040710961496308d,left: 0.3438399208642112d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9995036284532661d,right: 0.6836524718903995d,bottom: 0.5720289376155444d,left: 0.15468335023577096d),
new NpgsqlTypes.NpgsqlBox(top: 0.71280273353296d,right: 0.5078011853046769d,bottom: 0.6329328775811561d,left: 0.2030025325445206d),
new NpgsqlTypes.NpgsqlBox(top: 0.7992027070862563d,right: 0.9389087378451424d,bottom: 0.4520628044350028d,left: 0.024520504237390384d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2966565496660263d,right: 0.9573444538712218d,bottom: 0.1984955557465241d,left: 0.27249058791814684d),
new NpgsqlTypes.NpgsqlBox(top: 0.7400402288942258d,right: 0.4313019146035224d,bottom: 0.14555884814127262d,left: 0.36922755480936476d),
new NpgsqlTypes.NpgsqlBox(top: 0.8961320979807966d,right: 0.7778241957087487d,bottom: 0.40555710342134554d,left: 0.2583137516384677d),
new NpgsqlTypes.NpgsqlBox(top: 0.6323698136382421d,right: 0.9934459715454614d,bottom: 0.43939402570561026d,left: 0.8398777079489733d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9932427052579578d,right: 0.5097778196294981d,bottom: 0.20586897057293985d,left: 0.25722417348665894d),
new NpgsqlTypes.NpgsqlBox(top: 0.9859360853992697d,right: 0.7816424898570721d,bottom: 0.9417043292626438d,left: 0.7298059239162393d),
new NpgsqlTypes.NpgsqlBox(top: 0.29024529052990544d,right: 0.437059984642972d,bottom: 0.26193922432805283d,left: 0.30103641718313634d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9022074531118751d,right: 0.8870332470735258d,bottom: 0.2304753364700578d,left: 0.13887460206401048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8736995934793239d,right: 0.433030893626945d,bottom: 0.2900437043974545d,left: 0.08095444545881003d),
new NpgsqlTypes.NpgsqlBox(top: 0.8849567674098262d,right: 0.6099465699530143d,bottom: 0.08831086615030292d,left: 0.35973851263890533d),
new NpgsqlTypes.NpgsqlBox(top: 0.6091038455930763d,right: 0.18248008384175407d,bottom: 0.22594651703079027d,left: 0.12762790742997843d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9798946674573655d,right: 0.8342808322779193d,bottom: 0.280447198119247d,left: 0.23032802647435657d),
new NpgsqlTypes.NpgsqlBox(top: 0.2207603499672317d,right: 0.15469857481548677d,bottom: 0.011977060188652078d,left: 0.14432135257468304d),
new NpgsqlTypes.NpgsqlBox(top: 0.7905417671755672d,right: 0.7349035011440094d,bottom: 0.36703687275030095d,left: 0.34261894469646215d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4769237989561338d,right: 0.9275252190936201d,bottom: 0.16018494795979354d,left: 0.7004041984289352d),
new NpgsqlTypes.NpgsqlBox(top: 0.6760591589626949d,right: 0.6600323911196834d,bottom: 0.32822248059319425d,left: 0.2323609194683478d),
new NpgsqlTypes.NpgsqlBox(top: 0.9579579486065228d,right: 0.6778414451411199d,bottom: 0.5651731146724235d,left: 0.5483794434216193d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8785300080801213d,right: 0.7433901124995053d,bottom: 0.11318423473942685d,left: 0.4687457425777326d),
new NpgsqlTypes.NpgsqlBox(top: 0.5782613098621608d,right: 0.6620860062025856d,bottom: 0.27930240954719265d,left: 0.6578535026865894d),
new NpgsqlTypes.NpgsqlBox(top: 0.7537482250428669d,right: 0.9088242182912671d,bottom: 0.4974241817967331d,left: 0.48502074739609213d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8133147498710975d,right: 0.7060534515334748d,bottom: 0.767978430930134d,left: 0.3541696457205381d),
new NpgsqlTypes.NpgsqlBox(top: 0.9672482693471166d,right: 0.8416628612081377d,bottom: 0.27688704934798347d,left: 0.2727794966635453d),
new NpgsqlTypes.NpgsqlBox(top: 0.37572323618283443d,right: 0.6404743256883829d,bottom: 0.29833561657892127d,left: 0.2769946883959601d),
new NpgsqlTypes.NpgsqlBox(top: 0.8942063324067715d,right: 0.16553550939092543d,bottom: 0.013195360832599201d,left: 0.14979959914208418d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5524053761193635d,right: 0.17811354428859838d,bottom: 0.4096107525079312d,left: 0.01838062661025308d),
new NpgsqlTypes.NpgsqlBox(top: 0.7389261164113115d,right: 0.823065053366897d,bottom: 0.03980615272610566d,left: 0.6814068765746251d),
new NpgsqlTypes.NpgsqlBox(top: 0.5099090971477905d,right: 0.4809792096197103d,bottom: 0.030053687989832767d,left: 0.2971903094892473d),
new NpgsqlTypes.NpgsqlBox(top: 0.5933181973526893d,right: 0.6075721760993449d,bottom: 0.5225105641675154d,left: 0.09660298353208108d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9096112505132037d,right: 0.5480084356100794d,bottom: 0.2636617374928598d,left: 0.07973715893708877d),
new NpgsqlTypes.NpgsqlBox(top: 0.8363736134831549d,right: 0.7004153223398396d,bottom: 0.09675369249120269d,left: 0.02076778612603869d),
new NpgsqlTypes.NpgsqlBox(top: 0.8611161171243884d,right: 0.8995427954322931d,bottom: 0.1818236396101789d,left: 0.1937400741914609d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6399107714083122d,right: 0.9451670198110028d,bottom: 0.2880281927289928d,left: 0.025659423791067115d),
new NpgsqlTypes.NpgsqlBox(top: 0.7913510055838221d,right: 0.9404306260550208d,bottom: 0.5453540511758136d,left: 0.13068480241619973d),
new NpgsqlTypes.NpgsqlBox(top: 0.9706700030752339d,right: 0.8079146538276606d,bottom: 0.7528659314105303d,left: 0.2517965413588906d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9325540076122572d,right: 0.5397676406584545d,bottom: 0.34243681951382243d,left: 0.4684241925558499d),
new NpgsqlTypes.NpgsqlBox(top: 0.9792181111492192d,right: 0.4669951175252578d,bottom: 0.4039925166062941d,left: 0.3863062843608389d),
new NpgsqlTypes.NpgsqlBox(top: 0.3337346965907815d,right: 0.8305069676221106d,bottom: 0.14293748424501462d,left: 0.048613468313910224d),
new NpgsqlTypes.NpgsqlBox(top: 0.8305582779957d,right: 0.7917584506698649d,bottom: 0.12385947869407066d,left: 0.1548671344143745d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7849548561040237d,right: 0.7863643990771202d,bottom: 0.23024653661243988d,left: 0.05252966737549214d),
new NpgsqlTypes.NpgsqlBox(top: 0.5219093897554196d,right: 0.25347456582451267d,bottom: 0.053499498910391186d,left: 0.24299336243748515d),
new NpgsqlTypes.NpgsqlBox(top: 0.8496755809757353d,right: 0.8599203979146973d,bottom: 0.24525500592310145d,left: 0.45918773546611136d),
new NpgsqlTypes.NpgsqlBox(top: 0.6497316719458146d,right: 0.43869721090434854d,bottom: 0.36547741873364814d,left: 0.3424632681934706d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9145246401164493d,right: 0.8394075152483467d,bottom: 0.7508665115595559d,left: 0.4528926997907219d),
new NpgsqlTypes.NpgsqlBox(top: 0.8760948181004008d,right: 0.25689801712256033d,bottom: 0.2676098749913033d,left: 0.0917160709644097d),
new NpgsqlTypes.NpgsqlBox(top: 0.8440769598250185d,right: 0.7531265020462109d,bottom: 0.4585217429863232d,left: 0.44094727252992516d),
new NpgsqlTypes.NpgsqlBox(top: 0.3055842236705646d,right: 0.962887898336742d,bottom: 0.13724958523589437d,left: 0.46411144738352694d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5788421332480855d,right: 0.6523581868960834d,bottom: 0.2516556672414999d,left: 0.2901432620747397d),
new NpgsqlTypes.NpgsqlBox(top: 0.7437719255315663d,right: 0.9625055108553786d,bottom: 0.5321650893538737d,left: 0.23972970556052953d),
new NpgsqlTypes.NpgsqlBox(top: 0.8190457746437689d,right: 0.8204728965499408d,bottom: 0.6400478368109799d,left: 0.6767628285543782d),
new NpgsqlTypes.NpgsqlBox(top: 0.447547436223768d,right: 0.5805483476232735d,bottom: 0.0691561352040776d,left: 0.1923263991032842d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.873464980451003d,right: 0.6981432390531225d,bottom: 0.08427245771684044d,left: 0.3762180002664429d),
new NpgsqlTypes.NpgsqlBox(top: 0.3099822031292415d,right: 0.7512013365498168d,bottom: 0.2688368933317582d,left: 0.7164498939018599d),
new NpgsqlTypes.NpgsqlBox(top: 0.37026010747654503d,right: 0.13844725706323513d,bottom: 0.13869640320300725d,left: 0.014989911714734183d),
new NpgsqlTypes.NpgsqlBox(top: 0.7535581483198827d,right: 0.6019025491609918d,bottom: 0.044474341133377115d,left: 0.25604861612987384d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7171694446413999d,right: 0.38002644303652544d,bottom: 0.4999275000304646d,left: 0.18074892740972737d),
new NpgsqlTypes.NpgsqlBox(top: 0.3035933149697433d,right: 0.5922494066024255d,bottom: 0.07198814577925627d,left: 0.4491028337241165d),
new NpgsqlTypes.NpgsqlBox(top: 0.43206375890576165d,right: 0.7920221423441769d,bottom: 0.34232933831599854d,left: 0.2489459741922061d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.798034378294847d,right: 0.6614292919800192d,bottom: 0.7564388319312341d,left: 0.20393325359637804d),
new NpgsqlTypes.NpgsqlBox(top: 0.57176690078185d,right: 0.7591856740707325d,bottom: 0.16398638724113057d,left: 0.43980621635841266d),
new NpgsqlTypes.NpgsqlBox(top: 0.6876538910290111d,right: 0.2703116743646139d,bottom: 0.4722936316713686d,left: 0.12717680901447836d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49061479022597276d,right: 0.8154524481160934d,bottom: 0.4353032425305501d,left: 0.24247069554929634d),
new NpgsqlTypes.NpgsqlBox(top: 0.7191233713408364d,right: 0.7413163035692811d,bottom: 0.28300380517261936d,left: 0.04011125279834726d),
new NpgsqlTypes.NpgsqlBox(top: 0.8179151371370803d,right: 0.17706254573030822d,bottom: 0.7549328031726688d,left: 0.05599573706520933d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5735187440677194d,right: 0.9421034063088527d,bottom: 0.04898130862323302d,left: 0.1556801219509374d),
new NpgsqlTypes.NpgsqlBox(top: 0.8975408834605287d,right: 0.6472060524999199d,bottom: 0.7201201290257336d,left: 0.4732001295924336d),
new NpgsqlTypes.NpgsqlBox(top: 0.7789103330641018d,right: 0.6312400350874057d,bottom: 0.1843353680099682d,left: 0.22401026952828762d),
new NpgsqlTypes.NpgsqlBox(top: 0.7923776735266843d,right: 0.9361444822058484d,bottom: 0.3285269768930674d,left: 0.72301060212339d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8214550559774416d,right: 0.815775653905116d,bottom: 0.2867102818091545d,left: 0.6112572698710739d),
new NpgsqlTypes.NpgsqlBox(top: 0.921823127578832d,right: 0.9003646275785573d,bottom: 0.43786725110290925d,left: 0.5287428486736898d),
new NpgsqlTypes.NpgsqlBox(top: 0.6281105563638926d,right: 0.887491940994824d,bottom: 0.08078282414934268d,left: 0.39739435467954065d),
new NpgsqlTypes.NpgsqlBox(top: 0.8875182466205036d,right: 0.7547686881051927d,bottom: 0.4455308500691817d,left: 0.4817970912995352d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9443291017920666d,right: 0.14764690010344517d,bottom: 0.8554316889288525d,left: 0.055464484630117994d),
new NpgsqlTypes.NpgsqlBox(top: 0.4383683944011405d,right: 0.7747046734492957d,bottom: 0.07609544059134299d,left: 0.08468063706741769d),
new NpgsqlTypes.NpgsqlBox(top: 0.581588566676415d,right: 0.7463592479603289d,bottom: 0.5509752261052145d,left: 0.2557291679889032d),
new NpgsqlTypes.NpgsqlBox(top: 0.7942176769878546d,right: 0.1853974150677734d,bottom: 0.07483971766721376d,left: 0.0359985658672185d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7013385330026651d,right: 0.8783109077445224d,bottom: 0.6781676493044088d,left: 0.31264306443707957d),
new NpgsqlTypes.NpgsqlBox(top: 0.15992675404928358d,right: 0.26056990403144653d,bottom: 0.10014292957802318d,left: 0.20873638421908802d),
new NpgsqlTypes.NpgsqlBox(top: 0.647668324023396d,right: 0.8085974711732693d,bottom: 0.21789980863891978d,left: 0.18745310998821751d),
new NpgsqlTypes.NpgsqlBox(top: 0.9651423416690232d,right: 0.5914500270398909d,bottom: 0.5889529042638023d,left: 0.5244780042640111d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.440798096321911d,right: 0.7642060697255711d,bottom: 0.3039070657073184d,left: 0.6770991919156573d),
new NpgsqlTypes.NpgsqlBox(top: 0.38186739475581755d,right: 0.9900118253284309d,bottom: 0.35316050931563003d,left: 0.20882846308095893d),
new NpgsqlTypes.NpgsqlBox(top: 0.7964071162734958d,right: 0.7867442834517223d,bottom: 0.5049697470276893d,left: 0.4060746648697632d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5526610996551681d,right: 0.374995988051384d,bottom: 0.09873361860779695d,left: 0.09611241001645454d),
new NpgsqlTypes.NpgsqlBox(top: 0.8167772587229537d,right: 0.6820509916664336d,bottom: 0.09493399464296248d,left: 0.35619046322352177d),
new NpgsqlTypes.NpgsqlBox(top: 0.9118388269311075d,right: 0.592627386659514d,bottom: 0.01894798916221596d,left: 0.497680949416322d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5819217216937339d,right: 0.7677142385498071d,bottom: 0.24045502308231215d,left: 0.3574138904241032d),
new NpgsqlTypes.NpgsqlBox(top: 0.43810366663116185d,right: 0.5005263966364181d,bottom: 0.14473008800464748d,left: 0.11646095055744698d),
new NpgsqlTypes.NpgsqlBox(top: 0.5905634333198387d,right: 0.786465968862244d,bottom: 0.3622879349854138d,left: 0.5456264105625018d),
new NpgsqlTypes.NpgsqlBox(top: 0.7661093640829554d,right: 0.7718672239426175d,bottom: 0.043368417141882554d,left: 0.7437596364604163d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.532892026185164d,right: 0.2798322783385391d,bottom: 0.3691849969777631d,left: 0.12621096724467873d),
new NpgsqlTypes.NpgsqlBox(top: 0.4954112764442792d,right: 0.777463998822225d,bottom: 0.10825479212169375d,left: 0.6602174368121714d),
new NpgsqlTypes.NpgsqlBox(top: 0.2693935771884346d,right: 0.917224719045994d,bottom: 0.21984800591175047d,left: 0.17469017830369116d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5952143441615411d,right: 0.9974531490236364d,bottom: 0.3514287424095478d,left: 0.21160413908086184d),
new NpgsqlTypes.NpgsqlBox(top: 0.6469358848442323d,right: 0.7627615677127565d,bottom: 0.5145778412496429d,left: 0.5980866030054923d),
new NpgsqlTypes.NpgsqlBox(top: 0.9645824962973327d,right: 0.6970031589693582d,bottom: 0.6242796247283438d,left: 0.3648167136629997d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23700501013065378d,right: 0.5483310453767392d,bottom: 0.12073793158835344d,left: 0.12555714318550515d),
new NpgsqlTypes.NpgsqlBox(top: 0.9075301745597893d,right: 0.2880210804511967d,bottom: 0.8254055669436143d,left: 0.13513174483741663d),
new NpgsqlTypes.NpgsqlBox(top: 0.07348035395387731d,right: 0.33658678342355297d,bottom: 0.06651335613450293d,left: 0.27055774108474906d),
new NpgsqlTypes.NpgsqlBox(top: 0.6190283482947124d,right: 0.9129435985966534d,bottom: 0.5636815541808216d,left: 0.13889342251653602d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8034705220170577d,right: 0.642169363365388d,bottom: 0.3166021271538043d,left: 0.5488714033931096d),
new NpgsqlTypes.NpgsqlBox(top: 0.9649101618477146d,right: 0.945604815908838d,bottom: 0.8558611092055816d,left: 0.895002438979308d),
new NpgsqlTypes.NpgsqlBox(top: 0.9745038830164388d,right: 0.8407596719028595d,bottom: 0.8081298716741405d,left: 0.7981296726321564d),
new NpgsqlTypes.NpgsqlBox(top: 0.756996854872695d,right: 0.9456161882422228d,bottom: 0.6628124175899511d,left: 0.8244757566094014d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6646422490740467d,right: 0.8986355628150416d,bottom: 0.3421638632864987d,left: 0.13131142571933996d),
new NpgsqlTypes.NpgsqlBox(top: 0.9226581374388825d,right: 0.43409097537454266d,bottom: 0.16048091503394768d,left: 0.07210656681151495d),
new NpgsqlTypes.NpgsqlBox(top: 0.9299460125841715d,right: 0.39608286236485346d,bottom: 0.5000343623461185d,left: 0.3471009783689636d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4641938383982198d,right: 0.7187616023548182d,bottom: 0.33896296846511853d,left: 0.5891618235416944d),
new NpgsqlTypes.NpgsqlBox(top: 0.4371420569468848d,right: 0.5790069453829363d,bottom: 0.35536981116610056d,left: 0.01983311526990783d),
new NpgsqlTypes.NpgsqlBox(top: 0.3972020899521672d,right: 0.3141201624781029d,bottom: 0.03372731125865436d,left: 0.04743313802358984d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9440099147013931d,right: 0.7898424674635961d,bottom: 0.035313936368759125d,left: 0.3909481898984166d),
new NpgsqlTypes.NpgsqlBox(top: 0.7618451314894182d,right: 0.9193873654066462d,bottom: 0.13917387358436117d,left: 0.7749182526788544d),
new NpgsqlTypes.NpgsqlBox(top: 0.9958212577118635d,right: 0.9128845960681313d,bottom: 0.1617709100390371d,left: 0.4665434178764719d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9210509943551161d,right: 0.3049724478893917d,bottom: 0.46056483252152325d,left: 0.02283362339022299d),
new NpgsqlTypes.NpgsqlBox(top: 0.6980073197085318d,right: 0.9677458078549642d,bottom: 0.33288495694100284d,left: 0.16325620451772294d),
new NpgsqlTypes.NpgsqlBox(top: 0.7851479993211222d,right: 0.9223655620904267d,bottom: 0.04056850483988983d,left: 0.41896583419896893d),
new NpgsqlTypes.NpgsqlBox(top: 0.5975231196998362d,right: 0.8132164150622703d,bottom: 0.11709221213341203d,left: 0.2174321078602348d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8195918609018925d,right: 0.34195300070818746d,bottom: 0.7087419428476003d,left: 0.04944483371598363d),
new NpgsqlTypes.NpgsqlBox(top: 0.4442408199483312d,right: 0.41740219759109887d,bottom: 0.22145183181618544d,left: 0.32745836306654863d),
new NpgsqlTypes.NpgsqlBox(top: 0.2582026443992038d,right: 0.21652234560970984d,bottom: 0.18678850362265176d,left: 0.11064055099834069d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4121990053438246d,right: 0.0895847716521484d,bottom: 0.30505550208990817d,left: 0.016212633467183934d),
new NpgsqlTypes.NpgsqlBox(top: 0.6379102889854501d,right: 0.4252767790039593d,bottom: 0.48532023645691846d,left: 0.09926665524847644d),
new NpgsqlTypes.NpgsqlBox(top: 0.9337098314249441d,right: 0.8178891782740217d,bottom: 0.3772721293723609d,left: 0.5731064316180685d),
new NpgsqlTypes.NpgsqlBox(top: 0.7813640868692684d,right: 0.936955371721842d,bottom: 0.16439590599892762d,left: 0.8699130256441241d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9194172392523904d,right: 0.6998562738063359d,bottom: 0.23277351571580018d,left: 0.031895618786137d),
new NpgsqlTypes.NpgsqlBox(top: 0.061514494346654236d,right: 0.9195759776662871d,bottom: 0.04636085273467361d,left: 0.6754285580242221d),
new NpgsqlTypes.NpgsqlBox(top: 0.6051998945544962d,right: 0.9584342446337267d,bottom: 0.5378916014428282d,left: 0.8137150950692701d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40185143334961626d,right: 0.800644081987257d,bottom: 0.07130351127075052d,left: 0.5655518859049219d),
new NpgsqlTypes.NpgsqlBox(top: 0.6580664202344095d,right: 0.36434198759259706d,bottom: 0.6437352977474835d,left: 0.219503654294827d),
new NpgsqlTypes.NpgsqlBox(top: 0.5011379108984461d,right: 0.8913052767251688d,bottom: 0.18857156185347101d,left: 0.2111579403758571d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9773453264375103d,right: 0.8443316215074849d,bottom: 0.09659692040995305d,left: 0.7680104000348333d),
new NpgsqlTypes.NpgsqlBox(top: 0.43315498475765946d,right: 0.8481491234900633d,bottom: 0.17943413384066542d,left: 0.4294776643221466d),
new NpgsqlTypes.NpgsqlBox(top: 0.6508264955135599d,right: 0.5555435550149747d,bottom: 0.2297565899795021d,left: 0.07299592669150079d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7217665243558894d,right: 0.2638993937854337d,bottom: 0.6306185341218825d,left: 0.06127609851828064d),
new NpgsqlTypes.NpgsqlBox(top: 0.8484738941689262d,right: 0.04852075057378469d,bottom: 0.5179074915437104d,left: 0.015395515531140824d),
new NpgsqlTypes.NpgsqlBox(top: 0.33289955747576105d,right: 0.5371814977246309d,bottom: 0.3254140587208503d,left: 0.1163897097666593d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7893537409477035d,right: 0.9708957367240008d,bottom: 0.6714824900794936d,left: 0.6462513599161648d),
new NpgsqlTypes.NpgsqlBox(top: 0.8747759906690301d,right: 0.8460067841731875d,bottom: 0.770583126718252d,left: 0.27427046477918926d),
new NpgsqlTypes.NpgsqlBox(top: 0.8668103853898471d,right: 0.8775023823076883d,bottom: 0.4698289800143548d,left: 0.7956642110622894d),
new NpgsqlTypes.NpgsqlBox(top: 0.6376062642895105d,right: 0.8543026658560415d,bottom: 0.26492686819341205d,left: 0.2843368357654533d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6729543389111087d,right: 0.6001232646441259d,bottom: 0.31234914603370445d,left: 0.3372868839102888d),
new NpgsqlTypes.NpgsqlBox(top: 0.9736089488773433d,right: 0.9168679902939809d,bottom: 0.11285923101824236d,left: 0.7334267206060273d),
new NpgsqlTypes.NpgsqlBox(top: 0.6188971203236068d,right: 0.43761934375633615d,bottom: 0.6093744760979806d,left: 0.18402414386831512d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30356847112465357d,right: 0.6998338659203366d,bottom: 0.12978450224459415d,left: 0.47143351585258286d),
new NpgsqlTypes.NpgsqlBox(top: 0.15459176534011965d,right: 0.7962082851469982d,bottom: 0.05164833310533912d,left: 0.11108795056768617d),
new NpgsqlTypes.NpgsqlBox(top: 0.35804908162365856d,right: 0.9292565303389894d,bottom: 0.21276213163590263d,left: 0.9048447490490743d),
new NpgsqlTypes.NpgsqlBox(top: 0.6260240188939337d,right: 0.37738369973334096d,bottom: 0.5688499763242111d,left: 0.2944361884008988d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8448628915988681d,right: 0.3746754098096492d,bottom: 0.25576013484249993d,left: 0.15487475234976367d),
new NpgsqlTypes.NpgsqlBox(top: 0.8163266367491723d,right: 0.7174446331526594d,bottom: 0.39004364860811136d,left: 0.048903666683344116d),
new NpgsqlTypes.NpgsqlBox(top: 0.42330235262111693d,right: 0.6362467659705326d,bottom: 0.15139395208565098d,left: 0.06278224504806162d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4321175695712899d,right: 0.9663986102808049d,bottom: 0.22081177912403238d,left: 0.6013173410772845d),
new NpgsqlTypes.NpgsqlBox(top: 0.9148642280591807d,right: 0.6621614010601826d,bottom: 0.7307648404445646d,left: 0.0369709287975345d),
new NpgsqlTypes.NpgsqlBox(top: 0.5013050567698261d,right: 0.9542693409065331d,bottom: 0.42049984407983254d,left: 0.5009690332539024d),
new NpgsqlTypes.NpgsqlBox(top: 0.683231516312168d,right: 0.7426367920500697d,bottom: 0.38065645094394285d,left: 0.2634316803469656d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8286408473651204d,right: 0.9623548391494471d,bottom: 0.7168529638169298d,left: 0.8833608217681763d),
new NpgsqlTypes.NpgsqlBox(top: 0.9077121069352818d,right: 0.7902586213860293d,bottom: 0.8670898844035642d,left: 0.13787681647258776d),
new NpgsqlTypes.NpgsqlBox(top: 0.6748341132827351d,right: 0.8854788885666287d,bottom: 0.33277494652950723d,left: 0.7165807053523339d),
new NpgsqlTypes.NpgsqlBox(top: 0.7120679241096237d,right: 0.4821704998781674d,bottom: 0.20258550788544205d,left: 0.19911572221245977d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9643781741765847d,right: 0.3397802834825183d,bottom: 0.573127094522209d,left: 0.17407166406069574d),
new NpgsqlTypes.NpgsqlBox(top: 0.8374787321595756d,right: 0.7869574941407282d,bottom: 0.32962918204555813d,left: 0.43957597939132154d),
new NpgsqlTypes.NpgsqlBox(top: 0.24541417369580487d,right: 0.556580398309006d,bottom: 0.013148172339806474d,left: 0.45403047329183377d),
new NpgsqlTypes.NpgsqlBox(top: 0.696632496115567d,right: 0.6645159996268823d,bottom: 0.3556985896535213d,left: 0.0605084162576599d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7785747733307765d,right: 0.7797021506480609d,bottom: 0.0532408104183687d,left: 0.19863955107455622d),
new NpgsqlTypes.NpgsqlBox(top: 0.4539576215155138d,right: 0.630422097277979d,bottom: 0.2360993985843708d,left: 0.18895415038290897d),
new NpgsqlTypes.NpgsqlBox(top: 0.648328488863823d,right: 0.5767917874686745d,bottom: 0.607684620903967d,left: 0.408752917554558d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9953180681377887d,right: 0.5760526468849008d,bottom: 0.5768443620235744d,left: 0.08156914725377318d),
new NpgsqlTypes.NpgsqlBox(top: 0.38881249614027713d,right: 0.9243558539340363d,bottom: 0.1797140307251387d,left: 0.11784677599685467d),
new NpgsqlTypes.NpgsqlBox(top: 0.9539960422560244d,right: 0.41054783575556675d,bottom: 0.2973779795521915d,left: 0.24832341559142912d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7260175644120572d,right: 0.5656934579604136d,bottom: 0.6243825068669183d,left: 0.04835624055297716d),
new NpgsqlTypes.NpgsqlBox(top: 0.6624920328542814d,right: 0.46962414800012076d,bottom: 0.00023065673116084984d,left: 0.3028505320725702d),
new NpgsqlTypes.NpgsqlBox(top: 0.8604176206946823d,right: 0.8219576956999634d,bottom: 0.6636065060826513d,left: 0.23386640128681246d),
new NpgsqlTypes.NpgsqlBox(top: 0.7386707856075237d,right: 0.801788590057509d,bottom: 0.567945410724736d,left: 0.32098247279034675d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3892470738187387d,right: 0.692402318640915d,bottom: 0.07766457056593301d,left: 0.5426171220692574d),
new NpgsqlTypes.NpgsqlBox(top: 0.8470683442068158d,right: 0.07770543776192507d,bottom: 0.2380101192871017d,left: 0.04615067367557335d),
new NpgsqlTypes.NpgsqlBox(top: 0.7942248988606877d,right: 0.9294898307164187d,bottom: 0.37012849762086864d,left: 0.15728917554919375d),
new NpgsqlTypes.NpgsqlBox(top: 0.5579868777846779d,right: 0.8648072915942482d,bottom: 0.2768059762361801d,left: 0.7870353173006055d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3040137760433229d,right: 0.8233686137532115d,bottom: 0.154100830385558d,left: 0.46519377020039077d),
new NpgsqlTypes.NpgsqlBox(top: 0.8251862757127174d,right: 0.6263717306921261d,bottom: 0.24201752227211348d,left: 0.39913005136462d),
new NpgsqlTypes.NpgsqlBox(top: 0.711001793701622d,right: 0.31205169499305685d,bottom: 0.5743249694683401d,left: 0.018482508351399973d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12064605771293546d,right: 0.6731703177534305d,bottom: 0.011789037680146608d,left: 0.19141062437407907d),
new NpgsqlTypes.NpgsqlBox(top: 0.7221520490062989d,right: 0.7431522200422767d,bottom: 0.3857505244062911d,left: 0.5581050259275883d),
new NpgsqlTypes.NpgsqlBox(top: 0.7018553904718449d,right: 0.9288019971090213d,bottom: 0.48630514804389946d,left: 0.6365770648806562d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38362843742494557d,right: 0.9653496558018297d,bottom: 0.2268294748326407d,left: 0.07574309166030069d),
new NpgsqlTypes.NpgsqlBox(top: 0.540727190450124d,right: 0.7761629496920012d,bottom: 0.12009748003449539d,left: 0.24314069356961443d),
new NpgsqlTypes.NpgsqlBox(top: 0.275027563696725d,right: 0.6395258455369535d,bottom: 0.004037586272710891d,left: 0.09502907881462797d),
new NpgsqlTypes.NpgsqlBox(top: 0.8680368387527966d,right: 0.23927163992959521d,bottom: 0.5197662413991607d,left: 0.005299708878744647d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8199844930250237d,right: 0.7242883101412255d,bottom: 0.6589722053582688d,left: 0.31730761133339913d),
new NpgsqlTypes.NpgsqlBox(top: 0.6639823740405076d,right: 0.9756320922444948d,bottom: 0.053544731962691605d,left: 0.2114645784801884d),
new NpgsqlTypes.NpgsqlBox(top: 0.2669660488468417d,right: 0.4889280084987283d,bottom: 0.0131320822746952d,left: 0.26728118796239686d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6965550148031873d,right: 0.9761801745366301d,bottom: 0.590193124546863d,left: 0.3517160794753562d),
new NpgsqlTypes.NpgsqlBox(top: 0.958314419108237d,right: 0.8106692357897695d,bottom: 0.5833879485814835d,left: 0.6134301597438383d),
new NpgsqlTypes.NpgsqlBox(top: 0.35433222293143796d,right: 0.8579022285487579d,bottom: 0.04040710961496308d,left: 0.3438399208642112d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9022074531118751d,right: 0.8870332470735258d,bottom: 0.2304753364700578d,left: 0.13887460206401048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8736995934793239d,right: 0.433030893626945d,bottom: 0.2900437043974545d,left: 0.08095444545881003d),
new NpgsqlTypes.NpgsqlBox(top: 0.8849567674098262d,right: 0.6099465699530143d,bottom: 0.08831086615030292d,left: 0.35973851263890533d),
new NpgsqlTypes.NpgsqlBox(top: 0.6091038455930763d,right: 0.18248008384175407d,bottom: 0.22594651703079027d,left: 0.12762790742997843d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8133147498710975d,right: 0.7060534515334748d,bottom: 0.767978430930134d,left: 0.3541696457205381d),
new NpgsqlTypes.NpgsqlBox(top: 0.9672482693471166d,right: 0.8416628612081377d,bottom: 0.27688704934798347d,left: 0.2727794966635453d),
new NpgsqlTypes.NpgsqlBox(top: 0.37572323618283443d,right: 0.6404743256883829d,bottom: 0.29833561657892127d,left: 0.2769946883959601d),
new NpgsqlTypes.NpgsqlBox(top: 0.8942063324067715d,right: 0.16553550939092543d,bottom: 0.013195360832599201d,left: 0.14979959914208418d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9096112505132037d,right: 0.5480084356100794d,bottom: 0.2636617374928598d,left: 0.07973715893708877d),
new NpgsqlTypes.NpgsqlBox(top: 0.8363736134831549d,right: 0.7004153223398396d,bottom: 0.09675369249120269d,left: 0.02076778612603869d),
new NpgsqlTypes.NpgsqlBox(top: 0.8611161171243884d,right: 0.8995427954322931d,bottom: 0.1818236396101789d,left: 0.1937400741914609d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
                parametr1.Value = 68;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 75, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 68, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 75, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 35, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

