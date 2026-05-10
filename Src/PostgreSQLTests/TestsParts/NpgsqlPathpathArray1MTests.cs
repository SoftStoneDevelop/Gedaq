

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7925754260685951d, y: 0.7209541124491478d), new NpgsqlTypes.NpgsqlPoint(x: 0.31282695229362845d, y: 0.18495544185417023d), new NpgsqlTypes.NpgsqlPoint(x: 0.58733044542099d, y: 0.6933648276335801d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6415180234277889d, y: 0.15921316600659008d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790361088622107d, y: 0.19698953703855837d), new NpgsqlTypes.NpgsqlPoint(x: 0.3036005719636805d, y: 0.9592536736813896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7533371914690666d, y: 0.9460355601543831d), new NpgsqlTypes.NpgsqlPoint(x: 0.20770086695379975d, y: 0.8346551032488515d), new NpgsqlTypes.NpgsqlPoint(x: 0.057018998514304586d, y: 0.20504917202463657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7375737372423672d, y: 0.10668747004999524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6590375576919009d, y: 0.0545593196910612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1337044139224991d, y: 0.7550711046114001d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5955399163461973d, y: 0.3994005695063584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320499883391664d, y: 0.7963443514401202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585687026958954d, y: 0.8982380362872313d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15397852295413084d, y: 0.09788123509493052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087186069399428d, y: 0.13423483113183055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869962898927317d, y: 0.09642147997275585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5594559106861301d, y: 0.4292673267120789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358847761193277d, y: 0.537124258401678d), new NpgsqlTypes.NpgsqlPoint(x: 0.0026242823390805192d, y: 0.2682893310656448d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3364810475233989d, y: 0.8509506920001859d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805172935507076d, y: 0.6208443687362067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271081726773754d, y: 0.4078342126407547d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2982434027357641d, y: 0.6330585085576885d), new NpgsqlTypes.NpgsqlPoint(x: 0.508977068359606d, y: 0.27005561901494035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583237895676935d, y: 0.7008411632984239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46095997713119774d, y: 0.32532848433356676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145508772019208d, y: 0.8962018307003055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920358896570314d, y: 0.5226749914538316d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4957470365534763d, y: 0.9309047699773023d), new NpgsqlTypes.NpgsqlPoint(x: 0.217949000955884d, y: 0.2615993040946202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3649077580700044d, y: 0.5629908307968224d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16212048058976247d, y: 0.7287737157818689d), new NpgsqlTypes.NpgsqlPoint(x: 0.635304950276208d, y: 0.9022511811729489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726165109192399d, y: 0.9080300488783901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.898295874024705d, y: 0.10899816461218403d), new NpgsqlTypes.NpgsqlPoint(x: 0.08563860402791224d, y: 0.8431424334682139d), new NpgsqlTypes.NpgsqlPoint(x: 0.31621693243807747d, y: 0.3142474783077658d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09496855972765594d, y: 0.10573934074725566d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667587274577877d, y: 0.36551318149881085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230480278280785d, y: 0.02691905589949961d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9567152883519935d, y: 0.9945609535400559d), new NpgsqlTypes.NpgsqlPoint(x: 0.2268539448671093d, y: 0.9546453589421956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4593813802375618d, y: 0.49274881580739416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7354409465329024d, y: 0.8776431649850671d), new NpgsqlTypes.NpgsqlPoint(x: 0.32241526067823867d, y: 0.055306274195893845d), new NpgsqlTypes.NpgsqlPoint(x: 0.34715775722062625d, y: 0.45051511717333337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8024279351565708d, y: 0.3521777445732055d), new NpgsqlTypes.NpgsqlPoint(x: 0.011671984481204656d, y: 0.04252477221225037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729499987891606d, y: 0.14807652525978487d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24815079082724611d, y: 0.4284641082795221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7452540521414573d, y: 0.17699494560259654d), new NpgsqlTypes.NpgsqlPoint(x: 0.26508539432094214d, y: 0.7327293846781288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38434286899587333d, y: 0.6964084125326044d), new NpgsqlTypes.NpgsqlPoint(x: 0.03856438607798074d, y: 0.8657946525267778d), new NpgsqlTypes.NpgsqlPoint(x: 0.40385098199648406d, y: 0.4038948989744098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5664020401896308d, y: 0.07418205160875069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5216462518453057d, y: 0.6218816072405059d), new NpgsqlTypes.NpgsqlPoint(x: 0.9841580273940298d, y: 0.5343487129448814d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14650136722655194d, y: 0.3275930246524198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969900338921372d, y: 0.2798067065699146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5498050824207791d, y: 0.3342454872854631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1747645984321069d, y: 0.6355493467012177d), new NpgsqlTypes.NpgsqlPoint(x: 0.41738534766531965d, y: 0.062379686139179324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841063101935422d, y: 0.08520487719595071d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17846789388436302d, y: 0.3311213576438128d), new NpgsqlTypes.NpgsqlPoint(x: 0.18104620600641907d, y: 0.47698260104566925d), new NpgsqlTypes.NpgsqlPoint(x: 0.013545907270973045d, y: 0.760726610921338d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9671444693772392d, y: 0.40791950237366104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9734089243012599d, y: 0.9595611856325437d), new NpgsqlTypes.NpgsqlPoint(x: 0.679852903608358d, y: 0.14397619658046512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7352597079941142d, y: 0.23826731752450359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915339017676644d, y: 0.1486194058959709d), new NpgsqlTypes.NpgsqlPoint(x: 0.7320262697190593d, y: 0.35626854353079496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5912889123171218d, y: 0.3726216028011743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663500080421135d, y: 0.6898059708123571d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901063032815564d, y: 0.07772726175434241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8860066594727921d, y: 0.27889794927046385d), new NpgsqlTypes.NpgsqlPoint(x: 0.12486231212315724d, y: 0.681882844215274d), new NpgsqlTypes.NpgsqlPoint(x: 0.04689565830915521d, y: 0.2668706924324682d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28814245414137063d, y: 0.947793097125699d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296396404043903d, y: 0.9900450818493473d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634356707022749d, y: 0.38231896736364557d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7057915373406103d, y: 0.7101063507102471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500908469747873d, y: 0.4963876030879727d), new NpgsqlTypes.NpgsqlPoint(x: 0.93347467501886d, y: 0.12319946786292357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4915086305896763d, y: 0.5148088287094469d), new NpgsqlTypes.NpgsqlPoint(x: 0.2232568701519415d, y: 0.6954041878979051d), new NpgsqlTypes.NpgsqlPoint(x: 0.4976897844515916d, y: 0.5535053483636979d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15940768783584114d, y: 0.018530546055625208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217303780703435d, y: 0.49075162231446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204948825571019d, y: 0.8998476497559516d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38452732353740005d, y: 0.5700265125981944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087265961830344d, y: 0.9240324273274727d), new NpgsqlTypes.NpgsqlPoint(x: 0.4188462695368098d, y: 0.5755489033933832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12592331165652249d, y: 0.6073146155068773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807187061291953d, y: 0.8465941681433042d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600768688082071d, y: 0.5225569696568757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3215467611282711d, y: 0.08852630087127711d), new NpgsqlTypes.NpgsqlPoint(x: 0.37442865910433765d, y: 0.05395859316182583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158089682836951d, y: 0.45495075529558615d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.624570332575999d, y: 0.22960575180242826d), new NpgsqlTypes.NpgsqlPoint(x: 0.21226558440355325d, y: 0.027647573141720394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425140958546906d, y: 0.07397237301425152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45826614737529325d, y: 0.9582959606706982d), new NpgsqlTypes.NpgsqlPoint(x: 0.13167176875212572d, y: 0.9256357167657334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116164761639396d, y: 0.4608420625050157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6350055609611311d, y: 0.485050817866054d), new NpgsqlTypes.NpgsqlPoint(x: 0.07033680060039216d, y: 0.49095334392389745d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072224647003681d, y: 0.5808209704015099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1694079130169851d, y: 0.9459122114507341d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360427129391035d, y: 0.34082219648198553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651170140192153d, y: 0.8517649249803204d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3411132236017186d, y: 0.9207723464583899d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533485127493816d, y: 0.20052533369224224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6448198268688694d, y: 0.2422541521449697d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004836200337376972d, y: 0.4774698745660587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3161264718749771d, y: 0.7110674783844463d), new NpgsqlTypes.NpgsqlPoint(x: 0.03124971623488937d, y: 0.6953425147549467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.517153218528531d, y: 0.8724239954765589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5432109542489421d, y: 0.9409144986731554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19834459578729835d, y: 0.46801982014937227d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07354810053684557d, y: 0.05914348891296206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6079681944196255d, y: 0.18460428053702094d), new NpgsqlTypes.NpgsqlPoint(x: 0.14461609152136234d, y: 0.598843195871036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9336037801412441d, y: 0.23078079300968912d), new NpgsqlTypes.NpgsqlPoint(x: 0.0646202277197343d, y: 0.6350437675392289d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095933731950728d, y: 0.7034633114537191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.383232872100422d, y: 0.7454316690204382d), new NpgsqlTypes.NpgsqlPoint(x: 0.0431855790826039d, y: 0.09364829098785765d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008772628297669671d, y: 0.669954492093965d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8836543485200138d, y: 0.3799357002646071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299643204042829d, y: 0.21335069470411505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9283353403427815d, y: 0.34310771767544823d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6011027270977857d, y: 0.26082637120776075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544218975767808d, y: 0.5098607509607518d), new NpgsqlTypes.NpgsqlPoint(x: 0.18821348382779957d, y: 0.27427621444555217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550779384689989d, y: 0.9158929627380983d), new NpgsqlTypes.NpgsqlPoint(x: 0.23124413285001433d, y: 0.5973093771575668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406902642751104d, y: 0.8275717547427724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.636876413570595d, y: 0.6549192999608874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8186636467109217d, y: 0.5968787101967831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439347828552223d, y: 0.7983893940058634d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6888847083327432d, y: 0.24930565172956842d), new NpgsqlTypes.NpgsqlPoint(x: 0.01823536116917457d, y: 0.8030848538940868d), new NpgsqlTypes.NpgsqlPoint(x: 0.1055277154374753d, y: 0.28121219718500867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3199421966613052d, y: 0.672556899341523d), new NpgsqlTypes.NpgsqlPoint(x: 0.845738739281228d, y: 0.6397757897730457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189614976519989d, y: 0.3690054039920989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42013970422723745d, y: 0.8319829570832687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472275075368887d, y: 0.03496523418803965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658838168075033d, y: 0.602150274185236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5387612584457642d, y: 0.1774200120628413d), new NpgsqlTypes.NpgsqlPoint(x: 0.35660028584672754d, y: 0.39926381165781644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750812943850954d, y: 0.4019274542658783d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.615412224458347d, y: 0.8285213202188818d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594689165153595d, y: 0.7559113515243435d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512600774797704d, y: 0.6429091349861238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9140768991413764d, y: 0.6178371333828266d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256869026068407d, y: 0.7774822569662367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699296890605018d, y: 0.5617882895986517d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3772284560185615d, y: 0.7755410653355103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015980264316583d, y: 0.236836890915049d), new NpgsqlTypes.NpgsqlPoint(x: 0.07679384639093567d, y: 0.32627173112690966d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06832114723891192d, y: 0.513805072626107d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422917515354129d, y: 0.03525856349407397d), new NpgsqlTypes.NpgsqlPoint(x: 0.32933390930564077d, y: 0.7307308407191783d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6140664311075583d, y: 0.2561808035521609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022597120205727d, y: 0.5181304278086907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480082885439298d, y: 0.5535714362039962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8743760006860095d, y: 0.13513356910578067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211472134674586d, y: 0.20197015010571828d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370994851254388d, y: 0.0747024374569395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9438308702263657d, y: 0.6611735699535558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914491403492237d, y: 0.11420092146863647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823234502340996d, y: 0.09696034077366633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5373964219535643d, y: 0.7319233410884514d), new NpgsqlTypes.NpgsqlPoint(x: 0.19427451334778945d, y: 0.8023347758110493d), new NpgsqlTypes.NpgsqlPoint(x: 0.07157719717662014d, y: 0.724916187599407d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3145285202488505d, y: 0.027281304486442504d), new NpgsqlTypes.NpgsqlPoint(x: 0.47507560615321376d, y: 0.4562489016517426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846734825641659d, y: 0.3387216688288056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13930595304437654d, y: 0.13696166177648017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082161387148828d, y: 0.8313859006599822d), new NpgsqlTypes.NpgsqlPoint(x: 0.576753922531809d, y: 0.12278039545847874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9641840789762289d, y: 0.8716309340273848d), new NpgsqlTypes.NpgsqlPoint(x: 0.21463992275525967d, y: 0.8286547009556542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681967788945337d, y: 0.1733870101873607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1991736773202285d, y: 0.1258151398215196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416083133972393d, y: 0.05871764932954682d), new NpgsqlTypes.NpgsqlPoint(x: 0.032998821701131d, y: 0.7867115468069137d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9431403361936395d, y: 0.35310610229583617d), new NpgsqlTypes.NpgsqlPoint(x: 0.16679968337389162d, y: 0.5801102297272476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7509755425550233d, y: 0.9781067755869318d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42409528775177907d, y: 0.6143121293820668d), new NpgsqlTypes.NpgsqlPoint(x: 0.02134153395594307d, y: 0.1926835284063082d), new NpgsqlTypes.NpgsqlPoint(x: 0.794707706356152d, y: 0.34173493772163555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2465882374604238d, y: 0.23448424073301066d), new NpgsqlTypes.NpgsqlPoint(x: 0.13240124334295078d, y: 0.0702772026237517d), new NpgsqlTypes.NpgsqlPoint(x: 0.13980606821149577d, y: 0.3806537430523801d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054035906054731186d, y: 0.5215607067693078d), new NpgsqlTypes.NpgsqlPoint(x: 0.46699603571254944d, y: 0.41199667494109693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176918120839458d, y: 0.11592681930065896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0996274193198019d, y: 0.4359042723413977d), new NpgsqlTypes.NpgsqlPoint(x: 0.09650507822979237d, y: 0.2921644244454009d), new NpgsqlTypes.NpgsqlPoint(x: 0.44393370633835005d, y: 0.4174213178339772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5454905395967995d, y: 0.3205769543781428d), new NpgsqlTypes.NpgsqlPoint(x: 0.17843190927066999d, y: 0.6205646016508143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556367123772398d, y: 0.9541357188697526d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622100838413926d, y: 0.5245235008972859d), new NpgsqlTypes.NpgsqlPoint(x: 0.27373984649716887d, y: 0.8318634548920651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949808326534385d, y: 0.04806528794460363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6145041141557179d, y: 0.7347314338884331d), new NpgsqlTypes.NpgsqlPoint(x: 0.37519797935086774d, y: 0.18351828217827837d), new NpgsqlTypes.NpgsqlPoint(x: 0.20639810443743412d, y: 0.03880375343951048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.561811049563025d, y: 0.9975158974722034d), new NpgsqlTypes.NpgsqlPoint(x: 0.45177201183245874d, y: 0.2660323964098281d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630722221919969d, y: 0.2602156844104565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4297132238758068d, y: 0.4714700665626632d), new NpgsqlTypes.NpgsqlPoint(x: 0.15853720991264653d, y: 0.0037569045292077385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6546888520493827d, y: 0.19300233896065067d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.760952607509902d, y: 0.8157113060593787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9108745189359734d, y: 0.8673868533062492d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935385746297085d, y: 0.38094649615115705d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.62071769630099d, y: 0.9620615926492657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486727695636824d, y: 0.24225513439268276d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553094217218011d, y: 0.8029634509128536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8167142549937809d, y: 0.5915667757596258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6297012513178637d, y: 0.1675776444722834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928092320223399d, y: 0.57596652330193d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47388527453021545d, y: 0.9729442294018193d), new NpgsqlTypes.NpgsqlPoint(x: 0.48887303446736874d, y: 0.9099559507205343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707641117414905d, y: 0.9435751994211297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26508228450957616d, y: 0.5261886726973446d), new NpgsqlTypes.NpgsqlPoint(x: 0.930511797910458d, y: 0.9282167271315734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927236936587408d, y: 0.08881107679001765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7523036895107522d, y: 0.8292023483205893d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605897505264213d, y: 0.4520073181317702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305232936648857d, y: 0.035068604591650177d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8368209726203544d, y: 0.7557004253135149d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068108900376626d, y: 0.6072556021110641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684568228721643d, y: 0.8984809195725428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732748387061267d, y: 0.9699356134147756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634270780135736d, y: 0.6802077013764379d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802417040869083d, y: 0.7290444034364862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.552383357964633d, y: 0.32958390985715436d), new NpgsqlTypes.NpgsqlPoint(x: 0.25662245828795793d, y: 0.42896318896749286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518116868726204d, y: 0.167344879897793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35389812073697524d, y: 0.27584692560551893d), new NpgsqlTypes.NpgsqlPoint(x: 0.1390626608733334d, y: 0.5039177631416268d), new NpgsqlTypes.NpgsqlPoint(x: 0.49374547725195683d, y: 0.5638966417544538d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0795844387226089d, y: 0.8547094923292337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243056904791259d, y: 0.6139098825548713d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258955405145997d, y: 0.463778998816632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42170654389160533d, y: 0.5157276772508095d), new NpgsqlTypes.NpgsqlPoint(x: 0.28976981103859645d, y: 0.1458695691531322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3064642443273473d, y: 0.7240001787305709d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19450014842195051d, y: 0.5814499076169171d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025088591335728d, y: 0.256227795375516d), new NpgsqlTypes.NpgsqlPoint(x: 0.0723344356970459d, y: 0.7199573198230004d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011420046068769452d, y: 0.6827060988344396d), new NpgsqlTypes.NpgsqlPoint(x: 0.711454824162869d, y: 0.1788037551124093d), new NpgsqlTypes.NpgsqlPoint(x: 0.015701015115034966d, y: 0.11165140177311783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9327094791883476d, y: 0.9297619024478972d), new NpgsqlTypes.NpgsqlPoint(x: 0.28220983215059503d, y: 0.38873687158878845d), new NpgsqlTypes.NpgsqlPoint(x: 0.019472927462627188d, y: 0.19042995385692396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007421967773818761d, y: 0.6302669628677138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808319745132417d, y: 0.7314118906826667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489252650367548d, y: 0.7246629691600821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38071291287134745d, y: 0.8317232343451404d), new NpgsqlTypes.NpgsqlPoint(x: 0.920134866946243d, y: 0.9302128968476147d), new NpgsqlTypes.NpgsqlPoint(x: 0.12841504138577509d, y: 0.9935154702722527d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16046782251516267d, y: 0.6862570465572422d), new NpgsqlTypes.NpgsqlPoint(x: 0.22817176279949558d, y: 0.8875753535048093d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384158033101647d, y: 0.9635822483053949d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236656637173366d, y: 0.3130582632511395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2789195217894348d, y: 0.2602125024475255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341522159670874d, y: 0.7656570518559955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03830584014069138d, y: 0.8821838207827597d), new NpgsqlTypes.NpgsqlPoint(x: 0.17998407814458317d, y: 0.3110494124480342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827017484513016d, y: 0.7042145815953105d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6516332870794016d, y: 0.448773450640084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225102474419311d, y: 0.6902287928255794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129684933086877d, y: 0.05023377277077101d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07906307510933097d, y: 0.07955638710292368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183264990838925d, y: 0.6531916301621401d), new NpgsqlTypes.NpgsqlPoint(x: 0.629346259916531d, y: 0.9893750297680131d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2480382220791032d, y: 0.48641814150927454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107788840316417d, y: 0.49933072813834933d), new NpgsqlTypes.NpgsqlPoint(x: 0.28510494191914615d, y: 0.9071171618061321d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5997203678070009d, y: 0.5679819460472564d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842707057903442d, y: 0.7628205335028398d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938885242162247d, y: 0.22492408852030799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8755122076862285d, y: 0.8403260484560464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105946966961099d, y: 0.5746314838838128d), new NpgsqlTypes.NpgsqlPoint(x: 0.21933506728040764d, y: 0.687700972781826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1682191040849218d, y: 0.3827501264471267d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984275159261589d, y: 0.12768238405700238d), new NpgsqlTypes.NpgsqlPoint(x: 0.4043983091273218d, y: 0.7311314688600163d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793688370263196d, y: 0.2348891597633428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370144011643733d, y: 0.17182357701835094d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716757575558019d, y: 0.3752638511209102d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6399165750541183d, y: 0.8363287602115481d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252708478300685d, y: 0.06343839658707395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6199979585641413d, y: 0.8471957133686303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4866962579873949d, y: 0.4224466369720544d), new NpgsqlTypes.NpgsqlPoint(x: 0.29166007140158656d, y: 0.765622634294759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471554141532771d, y: 0.17607258385918967d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8495963271291795d, y: 0.9391641235240102d), new NpgsqlTypes.NpgsqlPoint(x: 0.586772982746709d, y: 0.47726275863210477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513525278659513d, y: 0.7324058515403608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9566717375563136d, y: 0.0185770803524139d), new NpgsqlTypes.NpgsqlPoint(x: 0.30608274966455185d, y: 0.0321421236380417d), new NpgsqlTypes.NpgsqlPoint(x: 0.2461054697536772d, y: 0.7000496702744642d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7618516576988037d, y: 0.9637062305134344d), new NpgsqlTypes.NpgsqlPoint(x: 0.34135578136019784d, y: 0.5247241680373882d), new NpgsqlTypes.NpgsqlPoint(x: 0.19076821266477428d, y: 0.6128091380166413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7537754751618344d, y: 0.8527740815459193d), new NpgsqlTypes.NpgsqlPoint(x: 0.1813356931986425d, y: 0.24229213470604227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9825109595191185d, y: 0.9735967204555042d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7931848036483646d, y: 0.8460289221671209d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678481769842972d, y: 0.8584619689189867d), new NpgsqlTypes.NpgsqlPoint(x: 0.569989347274205d, y: 0.47382294972179706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.918920270966081d, y: 0.23043299645251958d), new NpgsqlTypes.NpgsqlPoint(x: 0.0028648000779044613d, y: 0.9853069858255057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5456080950951003d, y: 0.8988097355280316d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7640472983164651d, y: 0.9420391881994779d), new NpgsqlTypes.NpgsqlPoint(x: 0.10851223901800877d, y: 0.9270239105102104d), new NpgsqlTypes.NpgsqlPoint(x: 0.15929278223005505d, y: 0.7256465559449462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11877108889302401d, y: 0.7926494401977743d), new NpgsqlTypes.NpgsqlPoint(x: 0.04747811685961523d, y: 0.9470987440770352d), new NpgsqlTypes.NpgsqlPoint(x: 0.729090075900009d, y: 0.2597720701049039d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01200961205730211d, y: 0.9930721526846132d), new NpgsqlTypes.NpgsqlPoint(x: 0.16048853821653786d, y: 0.014541692256128558d), new NpgsqlTypes.NpgsqlPoint(x: 0.06226200656397107d, y: 0.016958447519814346d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9330058342365167d, y: 0.44787911067318187d), new NpgsqlTypes.NpgsqlPoint(x: 0.20386620896405372d, y: 0.8099220218782679d), new NpgsqlTypes.NpgsqlPoint(x: 0.784832410620352d, y: 0.42067797266596985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41171542145231776d, y: 0.6778259228121707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339826039845218d, y: 0.5305953289328347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763942277772629d, y: 0.9059974458656974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12505773892582184d, y: 0.7937540561536044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187646906610627d, y: 0.6169123543583591d), new NpgsqlTypes.NpgsqlPoint(x: 0.16891946907647404d, y: 0.4976479234771809d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5290657471594788d, y: 0.6632084551499093d), new NpgsqlTypes.NpgsqlPoint(x: 0.15375732373162698d, y: 0.11836372994241329d), new NpgsqlTypes.NpgsqlPoint(x: 0.019923384259201815d, y: 0.84985118892425d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3857832624984069d, y: 0.2830213216401991d), new NpgsqlTypes.NpgsqlPoint(x: 0.037612526017650416d, y: 0.8493459116865879d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017463179572748677d, y: 0.8136022101320327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5077957872782249d, y: 0.33144667031452624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7540118085083334d, y: 0.5727094924238366d), new NpgsqlTypes.NpgsqlPoint(x: 0.748634618860651d, y: 0.4311674756362808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7222311258137581d, y: 0.9626576530516239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647688900369094d, y: 0.37962597578794555d), new NpgsqlTypes.NpgsqlPoint(x: 0.31589137536558587d, y: 0.17665477184810763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9663252589491638d, y: 0.8488296010116004d), new NpgsqlTypes.NpgsqlPoint(x: 0.41777678173892485d, y: 0.26609393710002227d), new NpgsqlTypes.NpgsqlPoint(x: 0.10853967703927025d, y: 0.6760810613884792d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.980122591469668d, y: 0.49031186456652465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167894810086046d, y: 0.251988773792271d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276437364535536d, y: 0.18182809559106927d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7469466407519054d, y: 0.471452733826874d), new NpgsqlTypes.NpgsqlPoint(x: 0.20806302565431645d, y: 0.3515048049605528d), new NpgsqlTypes.NpgsqlPoint(x: 0.17306670220067866d, y: 0.34505513539717114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9024806670911195d, y: 0.3085049576915825d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367762475429787d, y: 0.0340733951119363d), new NpgsqlTypes.NpgsqlPoint(x: 0.1459668578209038d, y: 0.8987480879756512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08803059645395828d, y: 0.17624699041568515d), new NpgsqlTypes.NpgsqlPoint(x: 0.30098552001508827d, y: 0.4436840922988623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429454160963946d, y: 0.0595883014198243d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050251503181921d, y: 0.8046018320229049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243529688807844d, y: 0.11151655812099825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9876493282513077d, y: 0.5339968205864103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04996056993772524d, y: 0.9569586673189887d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622523513760164d, y: 0.4071745903627665d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077902641096535d, y: 0.6118180743738817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634124705689076d, y: 0.9922412904329295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369192213176377d, y: 0.11614262880207649d), new NpgsqlTypes.NpgsqlPoint(x: 0.17209564755093631d, y: 0.6780757107072518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013306491722726466d, y: 0.6758628423286797d), new NpgsqlTypes.NpgsqlPoint(x: 0.08395374641848707d, y: 0.2740841553793988d), new NpgsqlTypes.NpgsqlPoint(x: 0.09653299271665994d, y: 0.6254772073176789d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7999974023180424d, y: 0.8332880873559138d), new NpgsqlTypes.NpgsqlPoint(x: 0.47963367310831695d, y: 0.1687097471956549d), new NpgsqlTypes.NpgsqlPoint(x: 0.20920689876110976d, y: 0.3742935083665143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02961158406268194d, y: 0.045228975573257335d), new NpgsqlTypes.NpgsqlPoint(x: 0.19599003068970666d, y: 0.42728205388967d), new NpgsqlTypes.NpgsqlPoint(x: 0.1383646738243629d, y: 0.9150281416793035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32392110572369714d, y: 0.5290800242435573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622742252343168d, y: 0.0785772817284065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680053799965083d, y: 0.5578899310269502d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47006778340172395d, y: 0.2478719599885918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969705253786658d, y: 0.9501109156870443d), new NpgsqlTypes.NpgsqlPoint(x: 0.660280671336769d, y: 0.6090967079129406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.663805828739003d, y: 0.7963713003290983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393750297592349d, y: 0.9463406225842022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991243986725626d, y: 0.5335288394530519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09108974979049045d, y: 0.018236282594560227d), new NpgsqlTypes.NpgsqlPoint(x: 0.1208369666706961d, y: 0.0983798618459446d), new NpgsqlTypes.NpgsqlPoint(x: 0.37065763940362095d, y: 0.950800640467566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44383078504083584d, y: 0.8655994977513213d), new NpgsqlTypes.NpgsqlPoint(x: 0.05054428955304857d, y: 0.5003294927032504d), new NpgsqlTypes.NpgsqlPoint(x: 0.0922062658442242d, y: 0.5614294832577053d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004057939797893262d, y: 0.5383220090558172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422149279459959d, y: 0.868891069388475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432528785285929d, y: 0.9689254715891775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7445273284952679d, y: 0.7536590532201518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642510259704826d, y: 0.8511416719738248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613250496167096d, y: 0.17245601380600628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09717085045256835d, y: 0.897637690832828d), new NpgsqlTypes.NpgsqlPoint(x: 0.1477462384989976d, y: 0.8864329843984643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422158843951097d, y: 0.38204707455123443d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536007373522562d, y: 0.7087589477825118d), new NpgsqlTypes.NpgsqlPoint(x: 0.2907319570124046d, y: 0.4120599281601809d), new NpgsqlTypes.NpgsqlPoint(x: 0.09803645452717202d, y: 0.6665505013304386d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6420232419054892d, y: 0.7972350069547259d), new NpgsqlTypes.NpgsqlPoint(x: 0.10986037194203502d, y: 0.9812614992491167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905700322517958d, y: 0.08979873535129057d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7894371756896784d, y: 0.3875818540150884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251907442730528d, y: 0.06776050271850087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622473121788675d, y: 0.5911980051892358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42342473318060914d, y: 0.6077069899928983d), new NpgsqlTypes.NpgsqlPoint(x: 0.4671871746112022d, y: 0.7727640029457016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085656462734489d, y: 0.13669308581538486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006691400885797d, y: 0.7586903315066179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263471099214232d, y: 0.0599973690719634d), new NpgsqlTypes.NpgsqlPoint(x: 0.15195920306658972d, y: 0.6967983453028144d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13784822715555722d, y: 0.22839825966113092d), new NpgsqlTypes.NpgsqlPoint(x: 0.1671666996830734d, y: 0.0548024441474787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511080426722663d, y: 0.4706266133549293d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46265461655947315d, y: 0.0006877070265591811d), new NpgsqlTypes.NpgsqlPoint(x: 0.03194834729827811d, y: 0.7612804755402045d), new NpgsqlTypes.NpgsqlPoint(x: 0.28741613769933805d, y: 0.08727525598320884d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6766511064679955d, y: 0.9573936738690398d), new NpgsqlTypes.NpgsqlPoint(x: 0.06732344632817999d, y: 0.8481986290398497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955377223479436d, y: 0.34403310719972624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5725191566555595d, y: 0.054010975027996455d), new NpgsqlTypes.NpgsqlPoint(x: 0.41213978195010537d, y: 0.3055739061241901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4779430697107966d, y: 0.1079830561653976d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017576246462975065d, y: 0.26629258934654154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819497064363109d, y: 0.2903132586572301d), new NpgsqlTypes.NpgsqlPoint(x: 0.20230987239590337d, y: 0.27894223142480323d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9115450487906902d, y: 0.3395914763227942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433126684930116d, y: 0.16309116443693006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967139168825196d, y: 0.7172551055952383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22659575288800526d, y: 0.2026288962829106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205890258276985d, y: 0.6234082675580723d), new NpgsqlTypes.NpgsqlPoint(x: 0.3026912648038149d, y: 0.7051010835461796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3241909149277936d, y: 0.4913221942997946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773375217572154d, y: 0.9514898174082621d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488287328464079d, y: 0.0261572931862748d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9436850939886476d, y: 0.9165570526518806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766810179933221d, y: 0.5331119926236746d), new NpgsqlTypes.NpgsqlPoint(x: 0.2044047644955994d, y: 0.9987281198080843d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5156228010013401d, y: 0.22033080988905673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202137642911133d, y: 0.7565133117392108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684743571571888d, y: 0.1550949325130745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2615241316139433d, y: 0.7718668152641572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4221023126424791d, y: 0.8436308845661932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502997018597505d, y: 0.8445766077428342d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6741117531209759d, y: 0.7539294564903334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6941427477446007d, y: 0.8962518848327242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4493047478612384d, y: 0.8480892837646062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2423114688455893d, y: 0.46160134854967594d), new NpgsqlTypes.NpgsqlPoint(x: 0.49792166942033145d, y: 0.16621986854587145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877064150067022d, y: 0.5802947828515811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9973221964324099d, y: 0.07664467729820401d), new NpgsqlTypes.NpgsqlPoint(x: 0.11546159925551869d, y: 0.15380842742481438d), new NpgsqlTypes.NpgsqlPoint(x: 0.4672613993178367d, y: 0.5126066764234901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14353990185052412d, y: 0.2019987341689019d), new NpgsqlTypes.NpgsqlPoint(x: 0.34917219696768054d, y: 0.1276224821430697d), new NpgsqlTypes.NpgsqlPoint(x: 0.208308307865522d, y: 0.3628948829548435d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9341826552251801d, y: 0.8328125199281147d), new NpgsqlTypes.NpgsqlPoint(x: 0.835820806406192d, y: 0.8627123917100764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629432493593726d, y: 0.8366957354089981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16506350339283427d, y: 0.124957426847075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580261801174577d, y: 0.5058417315563528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966373497475999d, y: 0.8827043747475813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8125938846558446d, y: 0.7858719635402164d), new NpgsqlTypes.NpgsqlPoint(x: 0.24117431795592337d, y: 0.41560139815052366d), new NpgsqlTypes.NpgsqlPoint(x: 0.522288911641362d, y: 0.2024736597102793d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.221267754046652d, y: 0.872072878452d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154718301365255d, y: 0.9267693446807567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728445374383402d, y: 0.053041968824658836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7800046347908242d, y: 0.74248298570957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0853324472739162d, y: 0.8481017284506572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406199226741897d, y: 0.625153124315415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7202938574207246d, y: 0.9588632102539942d), new NpgsqlTypes.NpgsqlPoint(x: 0.12511336274468177d, y: 0.26844661465471087d), new NpgsqlTypes.NpgsqlPoint(x: 0.14164599498128383d, y: 0.6153482885435013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7123614899051103d, y: 0.33502007480825047d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111197247713594d, y: 0.10030213149391731d), new NpgsqlTypes.NpgsqlPoint(x: 0.07742732064742874d, y: 0.333735427018351d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5083640421105361d, y: 0.336440114882666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4882002327478071d, y: 0.2755572118646622d), new NpgsqlTypes.NpgsqlPoint(x: 0.1249895797966658d, y: 0.32270580667694615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7654763983885546d, y: 0.8109605397809551d), new NpgsqlTypes.NpgsqlPoint(x: 0.43803370831299715d, y: 0.02240612928711916d), new NpgsqlTypes.NpgsqlPoint(x: 0.2985130324551841d, y: 0.1754694180716233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8295291532985115d, y: 0.02201629389234261d), new NpgsqlTypes.NpgsqlPoint(x: 0.39106495969613886d, y: 0.8418255508724621d), new NpgsqlTypes.NpgsqlPoint(x: 0.040330694098445474d, y: 0.6445756162021349d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24916605897133304d, y: 0.44283960764348373d), new NpgsqlTypes.NpgsqlPoint(x: 0.23826304506241036d, y: 0.5436414366855482d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178859976987946d, y: 0.2068886985957411d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3516763648707044d, y: 0.1769806934461734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030328425644074d, y: 0.025762842601363523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685032617255158d, y: 0.8109830000017406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014362760799646157d, y: 0.7845318454964733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320412397669664d, y: 0.6297315504114085d), new NpgsqlTypes.NpgsqlPoint(x: 0.028106834394596047d, y: 0.9619956041372387d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8544595583418021d, y: 0.013467719513884924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339696984519229d, y: 0.22065001123864647d), new NpgsqlTypes.NpgsqlPoint(x: 0.3903160318558929d, y: 0.25417456787223325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23696664760574826d, y: 0.4812427509556959d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244694857557697d, y: 0.8438334937823131d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215568335498237d, y: 0.026959172757393124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.741828577023893d, y: 0.9675439216165351d), new NpgsqlTypes.NpgsqlPoint(x: 0.2684601761283276d, y: 0.8835083712423507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436471666277259d, y: 0.6183707635396085d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05846776867639991d, y: 0.17864072318876967d), new NpgsqlTypes.NpgsqlPoint(x: 0.04563013455039289d, y: 0.49501811385988925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4185222928415381d, y: 0.5415977378317909d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2166451337908949d, y: 0.6164497524770417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331378586161709d, y: 0.34725684754418085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688133056403188d, y: 0.8457956216828008d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18251692997375712d, y: 0.6318572170300228d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642799915230998d, y: 0.3446790116646572d), new NpgsqlTypes.NpgsqlPoint(x: 0.008705966303025003d, y: 0.39520276605532956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08897149249407488d, y: 0.5684182881052713d), new NpgsqlTypes.NpgsqlPoint(x: 0.09195252963481848d, y: 0.0985201932889902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032419656292907d, y: 0.6482097193923334d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6473625927931146d, y: 0.21540439764297736d), new NpgsqlTypes.NpgsqlPoint(x: 0.01571178576090948d, y: 0.991069232705505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3321371119642572d, y: 0.4619520775880155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1838465517845156d, y: 0.19720486775664214d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374338443554049d, y: 0.07323822597554341d), new NpgsqlTypes.NpgsqlPoint(x: 0.43342717827877086d, y: 0.7999187415488642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8211483729286055d, y: 0.8671327860864801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741611614951657d, y: 0.005805830511214305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193605125078739d, y: 0.34416353498895846d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18070080499266228d, y: 0.6632399879996091d), new NpgsqlTypes.NpgsqlPoint(x: 0.1628528637551364d, y: 0.40318322199940826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1325984787296408d, y: 0.3489343025056736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04104560795108392d, y: 0.08608169395028342d), new NpgsqlTypes.NpgsqlPoint(x: 0.24384827134036047d, y: 0.1013498372534869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984125587983417d, y: 0.5257454580189259d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39355267233116464d, y: 0.7341526192554135d), new NpgsqlTypes.NpgsqlPoint(x: 0.00912695393252072d, y: 0.46059924085918225d), new NpgsqlTypes.NpgsqlPoint(x: 0.2717353402462902d, y: 0.7028985141952303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945382370127933d, y: 0.1679703575782513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5809116073210352d, y: 0.3482812211254456d), new NpgsqlTypes.NpgsqlPoint(x: 0.039000289143383826d, y: 0.35468540541966176d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9211962122711d, y: 0.8716660192441383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933179360703379d, y: 0.9644431299546233d), new NpgsqlTypes.NpgsqlPoint(x: 0.056078266566006674d, y: 0.6700290850472679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0067534676360681d, y: 0.5636707695949239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851085135845354d, y: 0.7466176619703662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398932851586211d, y: 0.4107075720859964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13350787008529164d, y: 0.7484605357563284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9125758111640017d, y: 0.32127245291459483d), new NpgsqlTypes.NpgsqlPoint(x: 0.36897510055065263d, y: 0.15535974997708313d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1610721128424042d, y: 0.3795585603686813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934808543579176d, y: 0.6561714021407692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971782815413356d, y: 0.3239569564500767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8125094674234505d, y: 0.06415945819176816d), new NpgsqlTypes.NpgsqlPoint(x: 0.39190358019496696d, y: 0.013880376624925805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303867089314141d, y: 0.4808124961136083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39275696077335587d, y: 0.7626378680523813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354696988114206d, y: 0.5356313852098804d), new NpgsqlTypes.NpgsqlPoint(x: 0.16532782889531317d, y: 0.5046248015773739d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9832133980198271d, y: 0.4587215133507684d), new NpgsqlTypes.NpgsqlPoint(x: 0.31579360139854973d, y: 0.4764161456580963d), new NpgsqlTypes.NpgsqlPoint(x: 0.744745460416826d, y: 0.19635964531213967d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1753424932126969d, y: 0.9057314367506011d), new NpgsqlTypes.NpgsqlPoint(x: 0.4177730246085817d, y: 0.9287358708172424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769943733163183d, y: 0.6287698041074105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7943864307013012d, y: 0.608981464725524d), new NpgsqlTypes.NpgsqlPoint(x: 0.04118684223904967d, y: 0.9624669448627247d), new NpgsqlTypes.NpgsqlPoint(x: 0.08451881584418064d, y: 0.9307693417595676d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8134592482846935d, y: 0.2214190596624872d), new NpgsqlTypes.NpgsqlPoint(x: 0.027112564376531978d, y: 0.3056886646380991d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895045145567767d, y: 0.35542283808667574d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5638330008880378d, y: 0.710091525894249d), new NpgsqlTypes.NpgsqlPoint(x: 0.060993791620492455d, y: 0.0509345454526301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012031242026864d, y: 0.5422836323533643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0045705834747128415d, y: 0.8820252076352711d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248261648554243d, y: 0.008317827755411678d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455939038434062d, y: 0.5460975368920195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4225096986343525d, y: 0.8662361117343473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6081676699028598d, y: 0.8285792088935817d), new NpgsqlTypes.NpgsqlPoint(x: 0.4114311277435527d, y: 0.6726378736850217d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3422529457504967d, y: 0.39135790409989746d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162987474874051d, y: 0.8319772650487349d), new NpgsqlTypes.NpgsqlPoint(x: 0.7846620485619776d, y: 0.24782699424397714d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566021232806353d, y: 0.3762436881866015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467477923819614d, y: 0.9292834210869272d), new NpgsqlTypes.NpgsqlPoint(x: 0.28239853276093274d, y: 0.2452737358956798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34387947153150256d, y: 0.819528370455154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027490543390151d, y: 0.283551569634627d), new NpgsqlTypes.NpgsqlPoint(x: 0.933834427846776d, y: 0.3818123645603836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37407698678522305d, y: 0.30267477651698027d), new NpgsqlTypes.NpgsqlPoint(x: 0.28083670336030453d, y: 0.47113245092068656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811794785170545d, y: 0.33808127526135345d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6615149176731258d, y: 0.9820276172170233d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656464178335972d, y: 0.9482130880928181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145768352645957d, y: 0.15174250019112978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4963500129066679d, y: 0.426767005777024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9000957185600716d, y: 0.9899604569916365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5638863672234391d, y: 0.5136785737391244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3996521219271407d, y: 0.5115889152849264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589078730276887d, y: 0.7317746640415206d), new NpgsqlTypes.NpgsqlPoint(x: 0.30747243553325665d, y: 0.6942079304790374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13040495682256004d, y: 0.2586211599771536d), new NpgsqlTypes.NpgsqlPoint(x: 0.1384561886424469d, y: 0.45538886222231556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269088708473932d, y: 0.4944566295563104d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8448983678530033d, y: 0.5178884169707326d), new NpgsqlTypes.NpgsqlPoint(x: 0.09551334839345083d, y: 0.18533053085523155d), new NpgsqlTypes.NpgsqlPoint(x: 0.287012840883784d, y: 0.5623426522808015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2830405034117054d, y: 0.5783275504406334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988333724874587d, y: 0.7843119080647504d), new NpgsqlTypes.NpgsqlPoint(x: 0.382822527491151d, y: 0.5029006130511546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20541683063111238d, y: 0.29423687725358105d), new NpgsqlTypes.NpgsqlPoint(x: 0.1498992048974025d, y: 0.849739658670244d), new NpgsqlTypes.NpgsqlPoint(x: 0.12268640317382629d, y: 0.16145434248726487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23660975051728694d, y: 0.7877132084188118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408242993009498d, y: 0.40026669874384835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707856600135103d, y: 0.45546863523175396d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6651486760933729d, y: 0.8461460782639656d), new NpgsqlTypes.NpgsqlPoint(x: 0.3819421588607739d, y: 0.028429334845982424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343861141852203d, y: 0.8463806328436906d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16176835167468862d, y: 0.8464151845080105d), new NpgsqlTypes.NpgsqlPoint(x: 0.01649308998948762d, y: 0.6560607226060391d), new NpgsqlTypes.NpgsqlPoint(x: 0.21091971290432565d, y: 0.23981996967502184d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.521814630361321d, y: 0.8517389717650637d), new NpgsqlTypes.NpgsqlPoint(x: 0.428985746774611d, y: 0.8996481798822992d), new NpgsqlTypes.NpgsqlPoint(x: 0.020603470367564714d, y: 0.003614366072847486d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18674587830453937d, y: 0.10607603608556126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566445545373088d, y: 0.47525319005318034d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966149222750283d, y: 0.2965007456234161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42040018432467685d, y: 0.8634859891002028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4191612021971418d, y: 0.6502309630016273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453624188991154d, y: 0.3232241021402663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24591383802737632d, y: 0.7674218721111996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533828320910356d, y: 0.5067721919498676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406463910517742d, y: 0.04629632384193694d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8904501163257867d, y: 0.7624394642802788d), new NpgsqlTypes.NpgsqlPoint(x: 0.3443360369608863d, y: 0.9712145024234292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9599946575629906d, y: 0.6205448122596425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5645068831558729d, y: 0.8863592271327785d), new NpgsqlTypes.NpgsqlPoint(x: 0.2435746836578614d, y: 0.2321348283946325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865353769183577d, y: 0.6350259644584582d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28277635404956913d, y: 0.04682598612326938d), new NpgsqlTypes.NpgsqlPoint(x: 0.19645554910744734d, y: 0.47194410346309956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314253265082012d, y: 0.5371050523035539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6965278096911636d, y: 0.6419516966444897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638722100707382d, y: 0.49447829277944766d), new NpgsqlTypes.NpgsqlPoint(x: 0.16052328837553864d, y: 0.13218988932194287d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3259315126139689d, y: 0.6745220756894367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560774165533269d, y: 0.7970730903330946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887451007672101d, y: 0.8783670023927419d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3584412201925201d, y: 0.19970134213326762d), new NpgsqlTypes.NpgsqlPoint(x: 0.39030005795068123d, y: 0.7453048391512198d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838271633649988d, y: 0.9683541786529268d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3495432711234667d, y: 0.8540053417632829d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011577654624992384d, y: 0.3761201371809403d), new NpgsqlTypes.NpgsqlPoint(x: 0.08121814972519348d, y: 0.7884150691804579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6218657261189544d, y: 0.5214478465129945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826244684038733d, y: 0.41259969261759166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739179197778918d, y: 0.9783417159880964d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1876850543208668d, y: 0.49482196348591345d), new NpgsqlTypes.NpgsqlPoint(x: 0.22679001190975256d, y: 0.6019733822239585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3400726758986541d, y: 0.6937001922316581d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5551087348142165d, y: 0.06608992792144874d), new NpgsqlTypes.NpgsqlPoint(x: 0.1964553121283127d, y: 0.9026788223918624d), new NpgsqlTypes.NpgsqlPoint(x: 0.21962076940972053d, y: 0.6427098785276332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7795962819290074d, y: 0.8065003519080726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312631410442608d, y: 0.07416379576190846d), new NpgsqlTypes.NpgsqlPoint(x: 0.16957195418878135d, y: 0.302504313879283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29146616515009804d, y: 0.8065172574579433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9150880266309184d, y: 0.0075860013600761445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6559931808320466d, y: 0.7998600654113187d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9062452963041547d, y: 0.028023492184227394d), new NpgsqlTypes.NpgsqlPoint(x: 0.03729500860541468d, y: 0.014248495031367159d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526573410336331d, y: 0.9142621466643602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24133247391499246d, y: 0.920379959825939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133133338432918d, y: 0.6558717827311852d), new NpgsqlTypes.NpgsqlPoint(x: 0.03953031376348304d, y: 0.3881684873671921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06452021078713865d, y: 0.334978773695071d), new NpgsqlTypes.NpgsqlPoint(x: 0.3307421481282661d, y: 0.270337399116502d), new NpgsqlTypes.NpgsqlPoint(x: 0.9163478598809127d, y: 0.3371822816449972d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08670366522929696d, y: 0.1447585351397721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961678159973328d, y: 0.3739884233355554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830368628789846d, y: 0.7171530479994862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7873799600613082d, y: 0.5136297663999929d), new NpgsqlTypes.NpgsqlPoint(x: 0.806196227261446d, y: 0.8531044888723658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884651622656602d, y: 0.8166381293616055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8450274718442703d, y: 0.8238908942620059d), new NpgsqlTypes.NpgsqlPoint(x: 0.0885210148700104d, y: 0.8594293143343334d), new NpgsqlTypes.NpgsqlPoint(x: 0.15841147227585783d, y: 0.6499267057292808d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1274592191212347d, y: 0.745608260355514d), new NpgsqlTypes.NpgsqlPoint(x: 0.24282513687238294d, y: 0.1452690315263112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824036892613852d, y: 0.5711318154933975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47973872181912036d, y: 0.6185832037410278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801436510692978d, y: 0.5107007202449282d), new NpgsqlTypes.NpgsqlPoint(x: 0.015759497292680447d, y: 0.07067849260662129d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9623455826635176d, y: 0.8165874086714444d), new NpgsqlTypes.NpgsqlPoint(x: 0.29649136656067077d, y: 0.7581196355023572d), new NpgsqlTypes.NpgsqlPoint(x: 0.17946103592541485d, y: 0.5126590489917132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6418405275019342d, y: 0.49417347239925236d), new NpgsqlTypes.NpgsqlPoint(x: 0.723009540391024d, y: 0.9129603242895911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294097736667795d, y: 0.556265913856241d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21169966539081153d, y: 0.7281202356432576d), new NpgsqlTypes.NpgsqlPoint(x: 0.23023149236919271d, y: 0.0996401440249034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626436427765822d, y: 0.27300971278733666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4222254900654907d, y: 0.1263098033473774d), new NpgsqlTypes.NpgsqlPoint(x: 0.31590332162982515d, y: 0.8730224113084145d), new NpgsqlTypes.NpgsqlPoint(x: 0.58031290932824d, y: 0.6899238139499796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9322357042114853d, y: 0.28221014070430506d), new NpgsqlTypes.NpgsqlPoint(x: 0.4610034031408351d, y: 0.20512993131719215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296688787215276d, y: 0.19153224926277534d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44742072317813775d, y: 0.6943581705139933d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030656763803003084d, y: 0.3193073041812956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859180956090282d, y: 0.6855517684189901d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043864264206591d, y: 0.4519610562108831d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511090226795025d, y: 0.6831156299628439d), new NpgsqlTypes.NpgsqlPoint(x: 0.948517892164983d, y: 0.4197943736108808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9940538290562888d, y: 0.1360252779865989d), new NpgsqlTypes.NpgsqlPoint(x: 0.666288869439998d, y: 0.4950391035338845d), new NpgsqlTypes.NpgsqlPoint(x: 0.015636002812489336d, y: 0.09149666992284144d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7968782214025472d, y: 0.701811524864284d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792285996361888d, y: 0.5703215450973903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414118649004287d, y: 0.4127143325990348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08064509533033437d, y: 0.8734616590836216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587773879515197d, y: 0.736714371374562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463813719901807d, y: 0.7121490958610527d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6367640851497143d, y: 0.3499772014210075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183862053877511d, y: 0.9672209421773416d), new NpgsqlTypes.NpgsqlPoint(x: 0.33937888159154384d, y: 0.912986931281465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5285869133764803d, y: 0.9603808583716634d), new NpgsqlTypes.NpgsqlPoint(x: 0.24781174027963349d, y: 0.7042641975849687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5073512414660221d, y: 0.3686057601470857d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09527779141192938d, y: 0.24563770065637158d), new NpgsqlTypes.NpgsqlPoint(x: 0.803265592310385d, y: 0.47631698970577907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005858124187078d, y: 0.5001464675819601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.711342648949185d, y: 0.10643943032295611d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754054234080175d, y: 0.5923840215185724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087069173207666d, y: 0.6682889121391392d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7588284017736983d, y: 0.8190113769838288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404997514121798d, y: 0.09814191647254156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046493448807113d, y: 0.7079288135300837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022530948868190404d, y: 0.9722991065610187d), new NpgsqlTypes.NpgsqlPoint(x: 0.31851284007100567d, y: 0.9740352203303034d), new NpgsqlTypes.NpgsqlPoint(x: 0.556297442278224d, y: 0.7522038686837912d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08275786135399599d, y: 0.6231337991136319d), new NpgsqlTypes.NpgsqlPoint(x: 0.11081154468377974d, y: 0.49300210950646683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997765346235879d, y: 0.35041272082997044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6435421367745658d, y: 0.9342477935060817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282228142669616d, y: 0.6795273016297546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515718054658817d, y: 0.2603642343080056d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19228731013325384d, y: 0.8700728813817156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4731859913895179d, y: 0.7895417849719291d), new NpgsqlTypes.NpgsqlPoint(x: 0.10792224702029396d, y: 0.2391812157122949d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7618282718251534d, y: 0.08405480312032976d), new NpgsqlTypes.NpgsqlPoint(x: 0.40105839950386624d, y: 0.08490537996257452d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455162707342787d, y: 0.4695205968729752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.500645892531098d, y: 0.3324871903191723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21342176127497692d, y: 0.07315888255325353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6648969096433704d, y: 0.7981476683204176d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4668789781741085d, y: 0.14418523272922612d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841362105792748d, y: 0.9723020171188199d), new NpgsqlTypes.NpgsqlPoint(x: 0.26567303812407617d, y: 0.5730287189234395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6567011327596913d, y: 0.6911856429993088d), new NpgsqlTypes.NpgsqlPoint(x: 0.806585479519885d, y: 0.48727279746031094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7792714170449175d, y: 0.1344978725202819d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5678233912491476d, y: 0.11157874800727885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118582716684557d, y: 0.19276452024703505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4109102576446194d, y: 0.9346182490058016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6586465829848949d, y: 0.5019559180878584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871499943927833d, y: 0.33988063292609816d), new NpgsqlTypes.NpgsqlPoint(x: 0.02368173508698157d, y: 0.5965924117990805d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27738140016064483d, y: 0.7986150804189815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401424490790568d, y: 0.5664724308315959d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423104481639372d, y: 0.2586929077646335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854189739379262d, y: 0.36890579959738456d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929564952015096d, y: 0.20787922670068226d), new NpgsqlTypes.NpgsqlPoint(x: 0.03377933686447032d, y: 0.12369682612367416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8209756174782773d, y: 0.2584652119493971d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561003339328881d, y: 0.15245958731227705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604592485814922d, y: 0.27739879695476866d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12475322893871943d, y: 0.06855349270108246d), new NpgsqlTypes.NpgsqlPoint(x: 0.09478575600294703d, y: 0.9063869651831917d), new NpgsqlTypes.NpgsqlPoint(x: 0.23565772962559117d, y: 0.5803054378958006d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15805030120241303d, y: 0.7303240989840311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3817075044929832d, y: 0.2640788887940456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961744687224926d, y: 0.2432699344178224d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1795245718396835d, y: 0.43382640694214647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7153344119948143d, y: 0.9630750366873395d), new NpgsqlTypes.NpgsqlPoint(x: 0.11767660089405929d, y: 0.7253892451655308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6277478210492151d, y: 0.5535401783244831d), new NpgsqlTypes.NpgsqlPoint(x: 0.12567838697833156d, y: 0.15734955651043026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360963103439595d, y: 0.8001118404184795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8948567537324158d, y: 0.5518542016105401d), new NpgsqlTypes.NpgsqlPoint(x: 0.031035155987018226d, y: 0.6589673705257151d), new NpgsqlTypes.NpgsqlPoint(x: 0.35368846832546696d, y: 0.030121475193382485d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12395566617016629d, y: 0.46120967003091984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925621901942407d, y: 0.9420183576930236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118399899743348d, y: 0.19862744555541667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8987926201205756d, y: 0.07976949074597794d), new NpgsqlTypes.NpgsqlPoint(x: 0.23166751124626883d, y: 0.8554604182238614d), new NpgsqlTypes.NpgsqlPoint(x: 0.30004744549147555d, y: 0.8366555936089815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.812881924569834d, y: 0.4655619047453221d), new NpgsqlTypes.NpgsqlPoint(x: 0.4109100129516472d, y: 0.049661409987965754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909403574363576d, y: 0.34894965204422645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8007896706407095d, y: 0.4919690226174781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705100670335365d, y: 0.21972862772928714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794180200847388d, y: 0.6994174145096316d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7306200496721535d, y: 0.9668364796439494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407861165096157d, y: 0.9886356476399978d), new NpgsqlTypes.NpgsqlPoint(x: 0.08326516985133225d, y: 0.7487555199183762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.181209064204912d, y: 0.46822845553324777d), new NpgsqlTypes.NpgsqlPoint(x: 0.15549562384714644d, y: 0.32719481208910184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659549823380232d, y: 0.07988594013552397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.614184078205256d, y: 0.15740481782200155d), new NpgsqlTypes.NpgsqlPoint(x: 0.49045442150242036d, y: 0.16188417855210713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5946752211620747d, y: 0.18319234734834944d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45656442267393005d, y: 0.13839931621012935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240579243509513d, y: 0.7177212254999968d), new NpgsqlTypes.NpgsqlPoint(x: 0.05971059623477659d, y: 0.23390292981226468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29320294981208783d, y: 0.5403937415007053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572326431260583d, y: 0.7825012751050798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5494738467205731d, y: 0.18285365761812478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32453395329691204d, y: 0.8998450440679109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714661576586001d, y: 0.7387635194114021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215329784919327d, y: 0.9934367462105276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16821856984408678d, y: 0.44169029274934524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417706124467266d, y: 0.31899966781678923d), new NpgsqlTypes.NpgsqlPoint(x: 0.654237227728912d, y: 0.1597666360587372d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976378266994683d, y: 0.20434856609805074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648081545125813d, y: 0.5965281131196406d), new NpgsqlTypes.NpgsqlPoint(x: 0.04099188548744792d, y: 0.4433247452408442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47474674498960434d, y: 0.08254989479718378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325995838413967d, y: 0.622991005712308d), new NpgsqlTypes.NpgsqlPoint(x: 0.14277015643222957d, y: 0.06357160181776556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6753306404556205d, y: 0.580073547826763d), new NpgsqlTypes.NpgsqlPoint(x: 0.17461717469189464d, y: 0.577982591539586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101117829733464d, y: 0.8827959557919942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046373643773808704d, y: 0.9801721923216341d), new NpgsqlTypes.NpgsqlPoint(x: 0.676107849195462d, y: 0.11965926551944372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6172148141004936d, y: 0.709645029455283d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5604800275968403d, y: 0.8633766834131664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169243861613774d, y: 0.9074564741089592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724826001161958d, y: 0.25038568085193746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20730047950523367d, y: 0.4121024972676496d), new NpgsqlTypes.NpgsqlPoint(x: 0.49253423591263223d, y: 0.678844894060939d), new NpgsqlTypes.NpgsqlPoint(x: 0.03726002529800709d, y: 0.7263687944311181d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7523236571941123d, y: 0.2676281177090445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645157558740906d, y: 0.8869487210965036d), new NpgsqlTypes.NpgsqlPoint(x: 0.11512016668045633d, y: 0.9822285898897443d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6419517295042723d, y: 0.745871343081019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149025246863484d, y: 0.5847566553261054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295473461195613d, y: 0.1148480043629142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5727651070076965d, y: 0.38444072898781567d), new NpgsqlTypes.NpgsqlPoint(x: 0.05272416178117323d, y: 0.5929189371879866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9072556033231384d, y: 0.02614038614944636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2483621598441036d, y: 0.4915536794174531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280361359478532d, y: 0.9363610757457796d), new NpgsqlTypes.NpgsqlPoint(x: 0.916194157324095d, y: 0.2315200860815143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9345024454764106d, y: 0.5112915428792093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467663656162636d, y: 0.6804783198350038d), new NpgsqlTypes.NpgsqlPoint(x: 0.32701421555490073d, y: 0.3307029508779057d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.693734270286286d, y: 0.37410529600211395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497994671314283d, y: 0.053874849246559386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994588221671288d, y: 0.3592693673876206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.82289246540993d, y: 0.09489027302115927d), new NpgsqlTypes.NpgsqlPoint(x: 0.15050842963404287d, y: 0.25548621780990666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2586961224228088d, y: 0.24231370843212108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49858981892301446d, y: 0.22755809604643318d), new NpgsqlTypes.NpgsqlPoint(x: 0.44252967662380505d, y: 0.7735676565515065d), new NpgsqlTypes.NpgsqlPoint(x: 0.1598789280203251d, y: 0.9579390689153576d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6402471541994923d, y: 0.625734846784101d), new NpgsqlTypes.NpgsqlPoint(x: 0.16691408423839016d, y: 0.20793041204018603d), new NpgsqlTypes.NpgsqlPoint(x: 0.42654031060069764d, y: 0.9096697490461834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.632767910822393d, y: 0.5365785378082015d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673842260733944d, y: 0.8747352788891316d), new NpgsqlTypes.NpgsqlPoint(x: 0.31055633397835014d, y: 0.21816311623269657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9737617822245618d, y: 0.8869882397380869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680401349366214d, y: 0.3168222388503802d), new NpgsqlTypes.NpgsqlPoint(x: 0.629347050612398d, y: 0.9256861708450189d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7456869830281319d, y: 0.7281822845190568d), new NpgsqlTypes.NpgsqlPoint(x: 0.36690465577092257d, y: 0.6484267296066806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912662064815266d, y: 0.6290462987482157d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07704536560823494d, y: 0.6988650943765015d), new NpgsqlTypes.NpgsqlPoint(x: 0.27294767115471874d, y: 0.8264834179517703d), new NpgsqlTypes.NpgsqlPoint(x: 0.627872132138823d, y: 0.3059495480298213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28767881265535566d, y: 0.44751932719334053d), new NpgsqlTypes.NpgsqlPoint(x: 0.44174928649896883d, y: 0.8860408610473305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551055695006881d, y: 0.5508137367670405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17564058612045053d, y: 0.8965850499888659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9489230965756504d, y: 0.05148214317158961d), new NpgsqlTypes.NpgsqlPoint(x: 0.8713344041876394d, y: 0.08068068949157192d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7728886984426474d, y: 0.6692215156270179d), new NpgsqlTypes.NpgsqlPoint(x: 0.435734729450576d, y: 0.7192399085832623d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011550367254645755d, y: 0.766102065168109d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1102033484090631d, y: 0.6504704158165643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537743261421375d, y: 0.4132944647046656d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807764724339584d, y: 0.8290246926387183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8298560584837407d, y: 0.5993593030311513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4542745412135518d, y: 0.7099432530142925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466416021328179d, y: 0.8150065163290416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9922468716600142d, y: 0.8126625823813144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5790732346340023d, y: 0.6749975100443982d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047854000070047d, y: 0.9602058095324433d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8893150255425434d, y: 0.03507172649429291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646798953901552d, y: 0.9899089713485032d), new NpgsqlTypes.NpgsqlPoint(x: 0.06542656904641508d, y: 0.19991537278137383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5722857124913796d, y: 0.3109468535416645d), new NpgsqlTypes.NpgsqlPoint(x: 0.06246780292937748d, y: 0.4164046338957835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067692540798161d, y: 0.7290471250718707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3176314193663714d, y: 0.1147727540960658d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653923937526598d, y: 0.23237760589908119d), new NpgsqlTypes.NpgsqlPoint(x: 0.20827510452685583d, y: 0.501235371115181d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9912896547632349d, y: 0.1314945428675507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192802781144788d, y: 0.7522143651766496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558460032717157d, y: 0.723948902953718d)),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.624570332575999d, y: 0.22960575180242826d), new NpgsqlTypes.NpgsqlPoint(x: 0.21226558440355325d, y: 0.027647573141720394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425140958546906d, y: 0.07397237301425152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45826614737529325d, y: 0.9582959606706982d), new NpgsqlTypes.NpgsqlPoint(x: 0.13167176875212572d, y: 0.9256357167657334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116164761639396d, y: 0.4608420625050157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6350055609611311d, y: 0.485050817866054d), new NpgsqlTypes.NpgsqlPoint(x: 0.07033680060039216d, y: 0.49095334392389745d), new NpgsqlTypes.NpgsqlPoint(x: 0.11072224647003681d, y: 0.5808209704015099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1694079130169851d, y: 0.9459122114507341d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360427129391035d, y: 0.34082219648198553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651170140192153d, y: 0.8517649249803204d)),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6888847083327432d, y: 0.24930565172956842d), new NpgsqlTypes.NpgsqlPoint(x: 0.01823536116917457d, y: 0.8030848538940868d), new NpgsqlTypes.NpgsqlPoint(x: 0.1055277154374753d, y: 0.28121219718500867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3199421966613052d, y: 0.672556899341523d), new NpgsqlTypes.NpgsqlPoint(x: 0.845738739281228d, y: 0.6397757897730457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189614976519989d, y: 0.3690054039920989d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42013970422723745d, y: 0.8319829570832687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472275075368887d, y: 0.03496523418803965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658838168075033d, y: 0.602150274185236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5387612584457642d, y: 0.1774200120628413d), new NpgsqlTypes.NpgsqlPoint(x: 0.35660028584672754d, y: 0.39926381165781644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750812943850954d, y: 0.4019274542658783d)),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6140664311075583d, y: 0.2561808035521609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022597120205727d, y: 0.5181304278086907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480082885439298d, y: 0.5535714362039962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8743760006860095d, y: 0.13513356910578067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211472134674586d, y: 0.20197015010571828d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370994851254388d, y: 0.0747024374569395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9438308702263657d, y: 0.6611735699535558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914491403492237d, y: 0.11420092146863647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823234502340996d, y: 0.09696034077366633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5373964219535643d, y: 0.7319233410884514d), new NpgsqlTypes.NpgsqlPoint(x: 0.19427451334778945d, y: 0.8023347758110493d), new NpgsqlTypes.NpgsqlPoint(x: 0.07157719717662014d, y: 0.724916187599407d)),
}));
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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622100838413926d, y: 0.5245235008972859d), new NpgsqlTypes.NpgsqlPoint(x: 0.27373984649716887d, y: 0.8318634548920651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949808326534385d, y: 0.04806528794460363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6145041141557179d, y: 0.7347314338884331d), new NpgsqlTypes.NpgsqlPoint(x: 0.37519797935086774d, y: 0.18351828217827837d), new NpgsqlTypes.NpgsqlPoint(x: 0.20639810443743412d, y: 0.03880375343951048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.561811049563025d, y: 0.9975158974722034d), new NpgsqlTypes.NpgsqlPoint(x: 0.45177201183245874d, y: 0.2660323964098281d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630722221919969d, y: 0.2602156844104565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4297132238758068d, y: 0.4714700665626632d), new NpgsqlTypes.NpgsqlPoint(x: 0.15853720991264653d, y: 0.0037569045292077385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6546888520493827d, y: 0.19300233896065067d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47388527453021545d, y: 0.9729442294018193d), new NpgsqlTypes.NpgsqlPoint(x: 0.48887303446736874d, y: 0.9099559507205343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707641117414905d, y: 0.9435751994211297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26508228450957616d, y: 0.5261886726973446d), new NpgsqlTypes.NpgsqlPoint(x: 0.930511797910458d, y: 0.9282167271315734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927236936587408d, y: 0.08881107679001765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7523036895107522d, y: 0.8292023483205893d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605897505264213d, y: 0.4520073181317702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305232936648857d, y: 0.035068604591650177d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16046782251516267d, y: 0.6862570465572422d), new NpgsqlTypes.NpgsqlPoint(x: 0.22817176279949558d, y: 0.8875753535048093d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384158033101647d, y: 0.9635822483053949d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236656637173366d, y: 0.3130582632511395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2789195217894348d, y: 0.2602125024475255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341522159670874d, y: 0.7656570518559955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03830584014069138d, y: 0.8821838207827597d), new NpgsqlTypes.NpgsqlPoint(x: 0.17998407814458317d, y: 0.3110494124480342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827017484513016d, y: 0.7042145815953105d)),
}));
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[34], false);
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
                parametr1.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 161, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 131, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 158, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 158, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 168))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 160, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 158);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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

