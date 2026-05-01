

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9970939416369012d, y: 0.5363282575747619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6996497169221898d, y: 0.049188709654572116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9372083199015693d, y: 0.49478542613305976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909378088646354d, y: 0.9412510795145955d), new NpgsqlTypes.NpgsqlPoint(x: 0.05393550839139705d, y: 0.41566617613578105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562044405233858d, y: 0.4763861389880477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2799904731387729d, y: 0.6426965888821711d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420560326700688d, y: 0.7039460731038157d), new NpgsqlTypes.NpgsqlPoint(x: 0.05783834041929847d, y: 0.25902790916811114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09910264145522674d, y: 0.553453866270721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416979617369883d, y: 0.9032842180004798d), new NpgsqlTypes.NpgsqlPoint(x: 0.31559555801081884d, y: 0.5553727384325271d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42029064033555674d, y: 0.02884414227580845d), new NpgsqlTypes.NpgsqlPoint(x: 0.304881785701949d, y: 0.12817641667166635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192629224467859d, y: 0.5014221539696946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6759903957840948d, y: 0.32544600406475044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943726425400637d, y: 0.6354599420445082d), new NpgsqlTypes.NpgsqlPoint(x: 0.20685031117382724d, y: 0.4477386452525556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337030990766678d, y: 0.8897340537755826d), new NpgsqlTypes.NpgsqlPoint(x: 0.34409882108727874d, y: 0.37909225933007784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624806487293348d, y: 0.03729449506153193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705544041406912d, y: 0.326649958285378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221915808821352d, y: 0.9149614935570483d), new NpgsqlTypes.NpgsqlPoint(x: 0.22053110677105892d, y: 0.7390002521659088d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29319003281392253d, y: 0.57508699831774d), new NpgsqlTypes.NpgsqlPoint(x: 0.18378520578103374d, y: 0.3350635144825166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056564034855523d, y: 0.4726212606293634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8079739535077078d, y: 0.4625041614051165d), new NpgsqlTypes.NpgsqlPoint(x: 0.551510577699562d, y: 0.024321814789704188d), new NpgsqlTypes.NpgsqlPoint(x: 0.706762457179097d, y: 0.06443535533123212d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5485966586959053d, y: 0.2671293902612596d), new NpgsqlTypes.NpgsqlPoint(x: 0.640528494277555d, y: 0.5147899237108178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563170252491286d, y: 0.6037527233282349d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4955080428450309d, y: 0.34392087154917383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895264646914134d, y: 0.4455608098545646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256328499681137d, y: 0.48345889410688114d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623248688092112d, y: 0.9323094490136252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809233603419627d, y: 0.12760344063867946d), new NpgsqlTypes.NpgsqlPoint(x: 0.30377312084895636d, y: 0.3272760409422819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5116932184484093d, y: 0.4395727329497642d), new NpgsqlTypes.NpgsqlPoint(x: 0.27903787809058644d, y: 0.2283200349585066d), new NpgsqlTypes.NpgsqlPoint(x: 0.219784709583435d, y: 0.7492891113181678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8461025747187816d, y: 0.04141145891445086d), new NpgsqlTypes.NpgsqlPoint(x: 0.03652009445819704d, y: 0.16753485199542173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800815917024335d, y: 0.17279435667603138d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.962317951642211d, y: 0.8707606412914443d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379193114614357d, y: 0.7645696565293157d), new NpgsqlTypes.NpgsqlPoint(x: 0.45424926048813075d, y: 0.7620322076089754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.627675286297195d, y: 0.5454122160747219d), new NpgsqlTypes.NpgsqlPoint(x: 0.601821491629826d, y: 0.08261814235302778d), new NpgsqlTypes.NpgsqlPoint(x: 0.15884977065896144d, y: 0.849480176313311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18712699853253678d, y: 0.18734468641599067d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148044248004984d, y: 0.38889563700342555d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898065202891731d, y: 0.07762575902151092d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11633474434605917d, y: 0.9453196386188422d), new NpgsqlTypes.NpgsqlPoint(x: 0.19715089374964645d, y: 0.9866843431404303d), new NpgsqlTypes.NpgsqlPoint(x: 0.16150984991143558d, y: 0.23106913216174563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.510879801400855d, y: 0.3144649691443542d), new NpgsqlTypes.NpgsqlPoint(x: 0.36108313294173067d, y: 0.704470125882219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7028688854243924d, y: 0.6828185853984786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935975450466387d, y: 0.0030750114894023683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359459438814511d, y: 0.5969351239920558d), new NpgsqlTypes.NpgsqlPoint(x: 0.08691503450517757d, y: 0.0705068368151005d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5383319142401946d, y: 0.41976753803824074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688144768862845d, y: 0.9037736129111017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7874017176505815d, y: 0.7791032029855096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5761697402593238d, y: 0.9823479392415158d), new NpgsqlTypes.NpgsqlPoint(x: 0.16604131649999732d, y: 0.1464467904972815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2735817491732405d, y: 0.020017597445075475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9590234887955249d, y: 0.7586009232834476d), new NpgsqlTypes.NpgsqlPoint(x: 0.18298240535936894d, y: 0.00964800281712519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354908859686569d, y: 0.46660056556938634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4224709883898682d, y: 0.07810480547681808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904268073250892d, y: 0.17485529089224772d), new NpgsqlTypes.NpgsqlPoint(x: 0.48078192747229664d, y: 0.17795176068820662d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2789790848829633d, y: 0.5596845296378938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030109917695663d, y: 0.9036841856087677d), new NpgsqlTypes.NpgsqlPoint(x: 0.023692265179703464d, y: 0.5325988518629634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22563509150769456d, y: 0.039071075522089105d), new NpgsqlTypes.NpgsqlPoint(x: 0.10256181654806451d, y: 0.11845978718276118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793309130089977d, y: 0.31208487594606515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.300009227419465d, y: 0.3770489917509324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8413066391886957d, y: 0.6397480983234102d), new NpgsqlTypes.NpgsqlPoint(x: 0.14086707540585186d, y: 0.7388044992597059d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8923131018046039d, y: 0.42068709383887903d), new NpgsqlTypes.NpgsqlPoint(x: 0.31957547120442453d, y: 0.7831011632498956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3117447843310024d, y: 0.7090513842311497d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5389883592251726d, y: 0.6847369803540139d), new NpgsqlTypes.NpgsqlPoint(x: 0.689055433753198d, y: 0.1290355401774591d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875282190907018d, y: 0.7880611568714802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7292023070466589d, y: 0.6887453092438178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859369382411983d, y: 0.6512718781253322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8648467023246099d, y: 0.2735390042936754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6094193387719774d, y: 0.7858016473350735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829253127180317d, y: 0.9853878734180821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641249184746702d, y: 0.4581488266758015d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29721057867243905d, y: 0.6184727082770508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276021083989556d, y: 0.12824336481901455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856447987031268d, y: 0.5737019130737069d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30391355301096323d, y: 0.38257900275709844d), new NpgsqlTypes.NpgsqlPoint(x: 0.13968545270030097d, y: 0.006777692501456878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255938209850814d, y: 0.5207101286311644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26108320079832315d, y: 0.1366296013860483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208512344626071d, y: 0.9187396494225419d), new NpgsqlTypes.NpgsqlPoint(x: 0.15204155580248568d, y: 0.8744984997222156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054489584534744284d, y: 0.5742983467798577d), new NpgsqlTypes.NpgsqlPoint(x: 0.10079475959511652d, y: 0.9467824435908433d), new NpgsqlTypes.NpgsqlPoint(x: 0.20973302599673516d, y: 0.607338125716797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49801132478773225d, y: 0.3466663692921852d), new NpgsqlTypes.NpgsqlPoint(x: 0.16982502805900934d, y: 0.4139381492938131d), new NpgsqlTypes.NpgsqlPoint(x: 0.04490550158742246d, y: 0.816681661201861d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6876913495716397d, y: 0.48693879381963834d), new NpgsqlTypes.NpgsqlPoint(x: 0.665579095258485d, y: 0.6112237841638314d), new NpgsqlTypes.NpgsqlPoint(x: 0.4597606369103896d, y: 0.9237906990080194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5532436467763401d, y: 0.6649477775471101d), new NpgsqlTypes.NpgsqlPoint(x: 0.30852216037927804d, y: 0.10955290593489264d), new NpgsqlTypes.NpgsqlPoint(x: 0.698515050603193d, y: 0.5400179070894393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8218910556773135d, y: 0.9393641368519918d), new NpgsqlTypes.NpgsqlPoint(x: 0.030891267211748508d, y: 0.17585015859097075d), new NpgsqlTypes.NpgsqlPoint(x: 0.39994842868395697d, y: 0.9144713284310886d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20755823200030477d, y: 0.9582326511925172d), new NpgsqlTypes.NpgsqlPoint(x: 0.35530273504748133d, y: 0.8218054720194763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229559397734551d, y: 0.8679094202968263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7338369737337277d, y: 0.6350272623272573d), new NpgsqlTypes.NpgsqlPoint(x: 0.47501210049270026d, y: 0.46906976690614544d), new NpgsqlTypes.NpgsqlPoint(x: 0.14959621461303652d, y: 0.5481149027147517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7250839563613931d, y: 0.7734620301678895d), new NpgsqlTypes.NpgsqlPoint(x: 0.584694415541807d, y: 0.9498022525309695d), new NpgsqlTypes.NpgsqlPoint(x: 0.39251122192293986d, y: 0.009282420823476856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5354536245100842d, y: 0.3174453429788594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446645778671617d, y: 0.2732608503551771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050817532938604d, y: 0.10419425603791654d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3773914572237216d, y: 0.28057164950699787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3991735645577479d, y: 0.43273256518131054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913780537157091d, y: 0.628503142430114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5354847412213487d, y: 0.5357905726741437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4714962954018542d, y: 0.9210641673529533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963091849167221d, y: 0.1941642397087091d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09709287459432858d, y: 0.05161670728754797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6509324812364538d, y: 0.2732302520138762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283754275764314d, y: 0.4805205703205384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5452397009998113d, y: 0.535337232672491d), new NpgsqlTypes.NpgsqlPoint(x: 0.06638172887991778d, y: 0.5316681557815488d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738603318528568d, y: 0.9648614319645339d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4767507158634914d, y: 0.23315670092021368d), new NpgsqlTypes.NpgsqlPoint(x: 0.352299225878115d, y: 0.6431673180778853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772907564240173d, y: 0.014119265015278049d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8324573773203368d, y: 0.9889103666611258d), new NpgsqlTypes.NpgsqlPoint(x: 0.25468486874601615d, y: 0.9705125942290882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769529538513852d, y: 0.9962420283494786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07829020431465894d, y: 0.180553075053412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226472879580254d, y: 0.49746659846050933d), new NpgsqlTypes.NpgsqlPoint(x: 0.38559369419870504d, y: 0.2652945944649461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3133750874237048d, y: 0.7790597249348713d), new NpgsqlTypes.NpgsqlPoint(x: 0.41513317853813125d, y: 0.17743185270853923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20256014818815504d, y: 0.5011234899313932d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6757905330778646d, y: 0.8537725442137784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2550926567829733d, y: 0.7940087030626669d), new NpgsqlTypes.NpgsqlPoint(x: 0.3641747355685331d, y: 0.6717537347955539d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4440046462071796d, y: 0.38434222869924284d), new NpgsqlTypes.NpgsqlPoint(x: 0.822561306099023d, y: 0.7795380019752508d), new NpgsqlTypes.NpgsqlPoint(x: 0.3460319221032908d, y: 0.09644478394806555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505557863465323d, y: 0.496132818987011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103498548241634d, y: 0.8976087080871378d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883999532951761d, y: 0.918978290257849d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39584216615300327d, y: 0.470553459656062d), new NpgsqlTypes.NpgsqlPoint(x: 0.009826598868399983d, y: 0.9212398867801079d), new NpgsqlTypes.NpgsqlPoint(x: 0.03133193406358237d, y: 0.44436862131971255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45207642434871254d, y: 0.5129150999362543d), new NpgsqlTypes.NpgsqlPoint(x: 0.005424068656592507d, y: 0.356975637086246d), new NpgsqlTypes.NpgsqlPoint(x: 0.14370659147804477d, y: 0.197817949360106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37332801693490425d, y: 0.35619112457264135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939930783373813d, y: 0.7343976024246399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7670630138110031d, y: 0.5354217669201535d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2224200870212143d, y: 0.9168171831106097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807965025177637d, y: 0.024544380310906777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715893134133931d, y: 0.9068752947692469d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7601981516085381d, y: 0.11249142907820875d), new NpgsqlTypes.NpgsqlPoint(x: 0.007998211362554075d, y: 0.7053405468093031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713674590102455d, y: 0.13191938131572467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417770397225151d, y: 0.7696174772150461d), new NpgsqlTypes.NpgsqlPoint(x: 0.601918006178713d, y: 0.864020248200854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853718942133499d, y: 0.7001761917342514d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942304393562141d, y: 0.6912525174823122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216693755292905d, y: 0.9152549660573525d), new NpgsqlTypes.NpgsqlPoint(x: 0.19872345183827678d, y: 0.08183626379295306d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 7.863589975121155E-05d, y: 0.5752928322833483d), new NpgsqlTypes.NpgsqlPoint(x: 0.17714183404840433d, y: 0.6265064346522506d), new NpgsqlTypes.NpgsqlPoint(x: 0.45793700341780275d, y: 0.4376637928228875d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9813780104742551d, y: 0.20495008535135617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9026165791732886d, y: 0.9220117767195387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399168436958572d, y: 0.2424608551383438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.960422312514945d, y: 0.7969614698777963d), new NpgsqlTypes.NpgsqlPoint(x: 0.883021401197082d, y: 0.7499288793077433d), new NpgsqlTypes.NpgsqlPoint(x: 0.1841401105674122d, y: 0.9672944970631123d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6043815243318498d, y: 0.42080401296099457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740296658981397d, y: 0.4956113798855072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002165168930801d, y: 0.5974372713183199d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5116855441782487d, y: 0.7013697608035979d), new NpgsqlTypes.NpgsqlPoint(x: 0.035386346166283555d, y: 0.2812073968746892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9075808943184578d, y: 0.993448907797717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9410666756774984d, y: 0.17538543668244355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3888309050625586d, y: 0.8546793027752017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3359141760547385d, y: 0.40602553992186197d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09849076220395836d, y: 0.7848561070243694d), new NpgsqlTypes.NpgsqlPoint(x: 0.952340913401451d, y: 0.7149300557745916d), new NpgsqlTypes.NpgsqlPoint(x: 0.779199781421606d, y: 0.6732211017417556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6265795650000079d, y: 0.05883494818137169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079886101335086d, y: 0.4067842881706625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552018049313004d, y: 0.5959683776017172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3305539028249287d, y: 0.41071235474685663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9317694578699852d, y: 0.4069118337755131d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836848279789395d, y: 0.879409882543472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7497576994628941d, y: 0.8244382790884336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828107529219121d, y: 0.6953599007046068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131463523875881d, y: 0.51289393712545d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3184043168722269d, y: 0.1738530947546636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7139379017920136d, y: 0.24639230715226945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887861425917118d, y: 0.10777618258778265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.530687922535584d, y: 0.5546547698713853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470056122505131d, y: 0.48944177238979525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4838719478674489d, y: 0.14117035423900526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8102025831122863d, y: 0.7618791944722364d), new NpgsqlTypes.NpgsqlPoint(x: 0.25009827266542306d, y: 0.056019703851090785d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060850977252503d, y: 0.7127619723223986d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2095739961544778d, y: 0.7565794588796387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182375720741316d, y: 0.8905122323087127d), new NpgsqlTypes.NpgsqlPoint(x: 0.017908472683037968d, y: 0.46238608421231964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.967791652377073d, y: 0.7044411071272381d), new NpgsqlTypes.NpgsqlPoint(x: 0.892267097446599d, y: 0.44961436953969247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251751473105889d, y: 0.017183747847948072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41273192631443645d, y: 0.3427996488579469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6546696470759585d, y: 0.4359655388763459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951253110890637d, y: 0.8741203774948154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2982234308755115d, y: 0.44366643513783643d), new NpgsqlTypes.NpgsqlPoint(x: 0.4698556788389423d, y: 0.4856676315671816d), new NpgsqlTypes.NpgsqlPoint(x: 0.32303734260336037d, y: 0.6815208304654935d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8275106868433283d, y: 0.9913205297268526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796478627413258d, y: 0.25477704342516283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647336966050522d, y: 0.6649678550123008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14394755967164197d, y: 0.2896639176709058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424329501376541d, y: 0.44004024563352195d), new NpgsqlTypes.NpgsqlPoint(x: 0.06750910731368687d, y: 0.3033298688755022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4178845983441958d, y: 0.6188085702363672d), new NpgsqlTypes.NpgsqlPoint(x: 0.03577155579816127d, y: 0.8263914710418934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3117158614121185d, y: 0.49367255044379765d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00851600475223957d, y: 0.3427348045636329d), new NpgsqlTypes.NpgsqlPoint(x: 0.29600126885457345d, y: 0.6870612422863772d), new NpgsqlTypes.NpgsqlPoint(x: 0.29715126585890905d, y: 0.22651119938430386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4966782428663168d, y: 0.12759537118636188d), new NpgsqlTypes.NpgsqlPoint(x: 0.305886672640437d, y: 0.11085094693544406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880638436964986d, y: 0.22418417231784427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40349376905693d, y: 0.25476772297648664d), new NpgsqlTypes.NpgsqlPoint(x: 0.22668243830761203d, y: 0.2898937693555713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991656626272038d, y: 0.4335649284163806d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7346541650417947d, y: 0.5987005780591693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500889670324178d, y: 0.2156919374290145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123642197974975d, y: 0.2536621331898097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2990507818688012d, y: 0.3024937148068977d), new NpgsqlTypes.NpgsqlPoint(x: 0.21772664424861765d, y: 0.6716127503128465d), new NpgsqlTypes.NpgsqlPoint(x: 0.018512652961990228d, y: 0.02317045022709896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9683997581851763d, y: 0.016883524246920745d), new NpgsqlTypes.NpgsqlPoint(x: 0.23303227195127862d, y: 0.8193282043986735d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745501180583727d, y: 0.5871299447232371d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8039957006034985d, y: 0.44364754600622436d), new NpgsqlTypes.NpgsqlPoint(x: 0.06215654530541037d, y: 0.4086165758098177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552991977137654d, y: 0.86719208597469d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875150255616496d, y: 0.9204110442942919d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374586488895153d, y: 0.0963199094204954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583332788563104d, y: 0.8191249978509745d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9665651272304973d, y: 0.8598555928958934d), new NpgsqlTypes.NpgsqlPoint(x: 0.37820874795234316d, y: 0.6964485914960118d), new NpgsqlTypes.NpgsqlPoint(x: 0.08840303215606016d, y: 0.8730760781776306d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022552021732809457d, y: 0.9277893511721134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7816041597225444d, y: 0.8196210533846173d), new NpgsqlTypes.NpgsqlPoint(x: 0.40808269877086034d, y: 0.10282281493990275d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23212446006240295d, y: 0.1935150382667027d), new NpgsqlTypes.NpgsqlPoint(x: 0.793534358540835d, y: 0.9997095426760935d), new NpgsqlTypes.NpgsqlPoint(x: 0.28879469287440784d, y: 0.44523376851013574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.823084168246201d, y: 0.6373826606642664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875481582858904d, y: 0.9053717941077201d), new NpgsqlTypes.NpgsqlPoint(x: 0.4895962109112483d, y: 0.012677970314085352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731085809849789d, y: 0.8336001194472041d), new NpgsqlTypes.NpgsqlPoint(x: 0.36764720113538496d, y: 0.4868752664271464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4539468955300284d, y: 0.8508822262300109d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14288499176483305d, y: 0.33606727576342865d), new NpgsqlTypes.NpgsqlPoint(x: 0.284752269433861d, y: 0.8080402427315897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078825380115784d, y: 0.5952779025807904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031386087090181314d, y: 0.5337690411732673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2171879580255507d, y: 0.897377356913514d), new NpgsqlTypes.NpgsqlPoint(x: 0.40876568578947414d, y: 0.740416871108123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8074845156843029d, y: 0.7540652143271971d), new NpgsqlTypes.NpgsqlPoint(x: 0.14527135643268274d, y: 0.898681851269278d), new NpgsqlTypes.NpgsqlPoint(x: 0.3292848180348903d, y: 0.07853722919290373d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20485194980572863d, y: 0.19757584693230634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084932995257081d, y: 0.5819786653570646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068652086004388d, y: 0.518398777892951d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028919203354540235d, y: 0.36705741631630706d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918098024662974d, y: 0.7334182725488932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387574232206027d, y: 0.15452068309121514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5321393761315771d, y: 0.43208709465256334d), new NpgsqlTypes.NpgsqlPoint(x: 0.11744884758187657d, y: 0.8077020442585029d), new NpgsqlTypes.NpgsqlPoint(x: 0.07767642197441227d, y: 0.5900284868177902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21648695411951135d, y: 0.5752825636012718d), new NpgsqlTypes.NpgsqlPoint(x: 0.21594633768047655d, y: 0.8494951560850487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029797842293297d, y: 0.8621527098830878d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12235337284202097d, y: 0.33565518997537425d), new NpgsqlTypes.NpgsqlPoint(x: 0.1193624507028429d, y: 0.9341146174865362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279589884874925d, y: 0.02639957263009407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6134145727609026d, y: 0.0044326931624998345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359240035400845d, y: 0.88798706135013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779453033332941d, y: 0.6010897469690341d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45541449592007366d, y: 0.6006544718849238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083726850365037d, y: 0.40024998120678945d), new NpgsqlTypes.NpgsqlPoint(x: 0.42851374725037805d, y: 0.13040712741320937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4049390215292652d, y: 0.37909968800015936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833826748325225d, y: 0.0996495709001537d), new NpgsqlTypes.NpgsqlPoint(x: 0.531299240598682d, y: 0.8721976221442208d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6199780006215868d, y: 0.8880043883101177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350004724201274d, y: 0.5162235350228268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426487291987296d, y: 0.9671785488707713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.693046617522372d, y: 0.16451699125000152d), new NpgsqlTypes.NpgsqlPoint(x: 0.21024304215243672d, y: 0.2894720637498601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4771153780107651d, y: 0.9243353672257106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583935379526339d, y: 0.9717803502935201d), new NpgsqlTypes.NpgsqlPoint(x: 0.46479857037304906d, y: 0.34798693607127307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465157386407708d, y: 0.18918384899584828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39702898340797865d, y: 0.5348099501464617d), new NpgsqlTypes.NpgsqlPoint(x: 0.06394767146586156d, y: 0.3735005626682848d), new NpgsqlTypes.NpgsqlPoint(x: 0.11948821226036344d, y: 0.8787076070057857d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.99131002542304d, y: 0.6410464871681358d), new NpgsqlTypes.NpgsqlPoint(x: 0.207912105825529d, y: 0.6298848114891907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626213043312019d, y: 0.43722047464331426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49163091950579163d, y: 0.6972064947052177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196443929764185d, y: 0.1476307485328271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472991004545302d, y: 0.9751384244317075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6088869472576963d, y: 0.6353806826602731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9648139578995668d, y: 0.8444321589560941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231495584140853d, y: 0.691177651526315d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4034691896653806d, y: 0.7438509580471449d), new NpgsqlTypes.NpgsqlPoint(x: 0.13481551433039018d, y: 0.24079532086759736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705016403851538d, y: 0.11919304274847353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6491836393970104d, y: 0.1674924240645238d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776243851313226d, y: 0.19271305240139047d), new NpgsqlTypes.NpgsqlPoint(x: 0.15605540145560093d, y: 0.9490695231212081d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7824843242705853d, y: 0.6071563348179624d), new NpgsqlTypes.NpgsqlPoint(x: 0.11822591165853102d, y: 0.09648964074909883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130815619142061d, y: 0.005180622008624236d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5495299266233031d, y: 0.39028836707105696d), new NpgsqlTypes.NpgsqlPoint(x: 0.28203439166320265d, y: 0.42988106322027664d), new NpgsqlTypes.NpgsqlPoint(x: 0.019815723587015d, y: 0.8458662154629522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5726966181383958d, y: 0.8865155639009324d), new NpgsqlTypes.NpgsqlPoint(x: 0.568427548221652d, y: 0.7985681362827464d), new NpgsqlTypes.NpgsqlPoint(x: 0.18668144721618196d, y: 0.5689831026086922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04798885705975242d, y: 0.007551980420365312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3840364433122013d, y: 0.019631564400284796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623545695664849d, y: 0.50691426045025d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3504697553687536d, y: 0.056840079086267314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118511269526058d, y: 0.33097094816566763d), new NpgsqlTypes.NpgsqlPoint(x: 0.11692742362433839d, y: 0.2679309622996904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14570986058084978d, y: 0.833947488106599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968088134172402d, y: 0.7116574198353501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434188498017635d, y: 0.004029398268628692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520249742895756d, y: 0.5616733156024215d), new NpgsqlTypes.NpgsqlPoint(x: 0.981545098637099d, y: 0.7985662486736212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5876306115674416d, y: 0.7763127963173156d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7735684628720727d, y: 0.44772464267149725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125588612556377d, y: 0.6354811199819147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512383052395717d, y: 0.6716189690989581d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.060319068934118314d, y: 0.7216727536402923d), new NpgsqlTypes.NpgsqlPoint(x: 0.10135889336266535d, y: 0.4690350232809115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007378388687675d, y: 0.7750924899371957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2591274779452962d, y: 0.4393086426935636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432594937404095d, y: 0.5715134796807755d), new NpgsqlTypes.NpgsqlPoint(x: 0.17513268542446758d, y: 0.36800727943795863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6396552176722505d, y: 0.6436780176714003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714485163729877d, y: 0.9623573038295649d), new NpgsqlTypes.NpgsqlPoint(x: 0.030316403581244877d, y: 0.20836370160845596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2522544680360629d, y: 0.41707902115715434d), new NpgsqlTypes.NpgsqlPoint(x: 0.420580158720945d, y: 0.4492420234462198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4291373202005029d, y: 0.9247427058892944d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33618604024121157d, y: 0.2756626965482789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015859346124237d, y: 0.3259787988032625d), new NpgsqlTypes.NpgsqlPoint(x: 0.036122956025684716d, y: 0.8222215260884367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32151154155319517d, y: 0.7331301293530816d), new NpgsqlTypes.NpgsqlPoint(x: 0.020101924168222318d, y: 0.38405853637119725d), new NpgsqlTypes.NpgsqlPoint(x: 0.05883296301509566d, y: 0.819883705884501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3400110728763621d, y: 0.7841415641974443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249128977239941d, y: 0.1841313072124824d), new NpgsqlTypes.NpgsqlPoint(x: 0.19323552128123322d, y: 0.865658011552022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9548960298136823d, y: 0.8732934264058384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4625382785034897d, y: 0.8810381350617801d), new NpgsqlTypes.NpgsqlPoint(x: 0.45495989231586964d, y: 0.44455920900036694d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6510309368052382d, y: 0.1532746083879507d), new NpgsqlTypes.NpgsqlPoint(x: 0.3631967100285006d, y: 0.7345683540815887d), new NpgsqlTypes.NpgsqlPoint(x: 0.883846732323613d, y: 0.2113114141824317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9748045249119944d, y: 0.19291711529593925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240303216071209d, y: 0.9165051055828926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521248981448614d, y: 0.17501481037061628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7983447803647418d, y: 0.4389985182509216d), new NpgsqlTypes.NpgsqlPoint(x: 0.02904296399602102d, y: 0.9935057282379478d), new NpgsqlTypes.NpgsqlPoint(x: 0.03822543301499215d, y: 0.272832960324229d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11836849523795279d, y: 0.023247691365020695d), new NpgsqlTypes.NpgsqlPoint(x: 0.37521779793925236d, y: 0.7880592017996695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294054376453369d, y: 0.820730067749129d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7514986853136072d, y: 0.9470204213774024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840643608033975d, y: 0.011690309152005085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756964340759168d, y: 0.9795987727660674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07535055855982553d, y: 0.004660437228772851d), new NpgsqlTypes.NpgsqlPoint(x: 0.435714551195849d, y: 0.13013947653094582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699513831383148d, y: 0.5559792493605827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3036004358377684d, y: 0.046717735221416756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1049295063771799d, y: 0.8985690992392815d), new NpgsqlTypes.NpgsqlPoint(x: 0.11735506077826208d, y: 0.8507941784858539d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4524577970240059d, y: 0.7125192913579095d), new NpgsqlTypes.NpgsqlPoint(x: 0.41329768264835187d, y: 0.5223422697760841d), new NpgsqlTypes.NpgsqlPoint(x: 0.22320700630649926d, y: 0.0845141629827304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0074608600164617345d, y: 0.4466746161639569d), new NpgsqlTypes.NpgsqlPoint(x: 0.07161260620742049d, y: 0.45101492231080376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903175614201484d, y: 0.9183447238728724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9194339796521472d, y: 0.22713440952147101d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580943317896405d, y: 0.2299849903754353d), new NpgsqlTypes.NpgsqlPoint(x: 0.169419916988377d, y: 0.4696762100720635d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11448093158670392d, y: 0.18458268633316066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5974073670111258d, y: 0.5557946484620995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514503854017397d, y: 0.9164680106238315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2510433691877899d, y: 0.6668056391030857d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905935106556989d, y: 0.1398341696287464d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761446122041834d, y: 0.3829648393113434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3132759440006482d, y: 0.24396706477883068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026330400944097d, y: 0.840131712036284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7527581784157362d, y: 0.253409301399913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.200750204057215d, y: 0.3233322485374541d), new NpgsqlTypes.NpgsqlPoint(x: 0.12677590845120557d, y: 0.7653847451005878d), new NpgsqlTypes.NpgsqlPoint(x: 0.05754655297139022d, y: 0.5454873688434836d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20912987631801383d, y: 0.01565836391667097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576247362186359d, y: 0.0861716455136663d), new NpgsqlTypes.NpgsqlPoint(x: 0.19971480766766736d, y: 0.8624270739827887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9284775077721984d, y: 0.20323181725359563d), new NpgsqlTypes.NpgsqlPoint(x: 0.3954066896289933d, y: 0.5343249284137662d), new NpgsqlTypes.NpgsqlPoint(x: 0.39157594084205516d, y: 0.9098423158423434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9383394947830083d, y: 0.5832808634529342d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091649058590577d, y: 0.07222435404422467d), new NpgsqlTypes.NpgsqlPoint(x: 0.10021974277624235d, y: 0.8678010407229508d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9868543186936263d, y: 0.09600896164576433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539552832146192d, y: 0.17641607820543304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197922422544017d, y: 0.04086684447379774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6798454809886131d, y: 0.8648014056653891d), new NpgsqlTypes.NpgsqlPoint(x: 0.33925078469770453d, y: 0.5243283745708717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2657691446954684d, y: 0.8165893034993258d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2891975017301115d, y: 0.3769215080180546d), new NpgsqlTypes.NpgsqlPoint(x: 0.20719767369053477d, y: 0.8760828574983003d), new NpgsqlTypes.NpgsqlPoint(x: 0.25229604948954676d, y: 0.29726297537742474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26820766701968024d, y: 0.8619338158767702d), new NpgsqlTypes.NpgsqlPoint(x: 0.13748970620827838d, y: 0.9376048617388576d), new NpgsqlTypes.NpgsqlPoint(x: 0.012427203841176793d, y: 0.3491517824948899d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9962696946950386d, y: 0.300317792176782d), new NpgsqlTypes.NpgsqlPoint(x: 0.2195425457826342d, y: 0.19885202445889827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3995632947710507d, y: 0.8735696339584286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9885301937582529d, y: 0.3662647367808005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598770460024755d, y: 0.6552121678671035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698357169278146d, y: 0.4872392198330232d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8845987065403589d, y: 0.8585788514009293d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789642980533668d, y: 0.05037479822808477d), new NpgsqlTypes.NpgsqlPoint(x: 0.26484371335981693d, y: 0.33476347733103595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.78100276469367d, y: 0.31576025255273676d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735765417064176d, y: 0.6544707951755468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041822122680232d, y: 0.6076840318886261d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32492955295407955d, y: 0.8967830905984301d), new NpgsqlTypes.NpgsqlPoint(x: 0.43021845524303215d, y: 0.7227156211823751d), new NpgsqlTypes.NpgsqlPoint(x: 0.0032771747982066612d, y: 0.19975896645219537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5224019684189523d, y: 0.9030507582696399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155628853692214d, y: 0.6447621953547904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664301135234551d, y: 0.15237347954296376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25902787543485306d, y: 0.6299131470576815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609640025997971d, y: 0.7559881353147836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366488141389421d, y: 0.40794489289754554d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353439200583533d, y: 0.9020399142755983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387525992422874d, y: 0.18637256067290275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630308539998705d, y: 0.3156767411843594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4554238289721676d, y: 0.6753208293989189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928105572276228d, y: 0.9321365080415979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073515893435459d, y: 0.05247442402218827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6523030682813683d, y: 0.5460162059273009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769025955338437d, y: 0.583358316883054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716946382651603d, y: 0.7031284567218694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3401084039553365d, y: 0.8694654482588539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378766358272854d, y: 0.004052795846477553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378127711461688d, y: 0.6844312460844589d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3760850058023075d, y: 0.5418986478119129d), new NpgsqlTypes.NpgsqlPoint(x: 0.20900439385785008d, y: 0.9329178294335507d), new NpgsqlTypes.NpgsqlPoint(x: 0.686651094036193d, y: 0.30197067581262826d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0317761451682238d, y: 0.7458085459117604d), new NpgsqlTypes.NpgsqlPoint(x: 0.21863034583780416d, y: 0.15332629221478344d), new NpgsqlTypes.NpgsqlPoint(x: 0.36282768050242875d, y: 0.11424066461056959d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06672826735359905d, y: 0.2152592998691436d), new NpgsqlTypes.NpgsqlPoint(x: 0.48678052601383226d, y: 0.40503674793385924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8942625186655231d, y: 0.9964265322351408d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3649000942728732d, y: 0.36992856259210416d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123976791232024d, y: 0.2526916995177977d), new NpgsqlTypes.NpgsqlPoint(x: 0.35210303959412503d, y: 0.8799803489943364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8264553730728744d, y: 0.026755240813731374d), new NpgsqlTypes.NpgsqlPoint(x: 0.12318588526357044d, y: 0.9518601296474546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618146018911869d, y: 0.6892085160867274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8471963750433371d, y: 0.8460509213333252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987455687334153d, y: 0.5230469997113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085502208275019d, y: 0.17135682727453783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.764466614277844d, y: 0.08085254631948391d), new NpgsqlTypes.NpgsqlPoint(x: 0.043786335829642864d, y: 0.2137389048921019d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018247500198662d, y: 0.876753220166849d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3699080488980647d, y: 0.7878413146874953d), new NpgsqlTypes.NpgsqlPoint(x: 0.14376739534987582d, y: 0.06504922982766481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535656020727869d, y: 0.9233497494541956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598306953322451d, y: 0.8513660763128769d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521306432960601d, y: 0.467014497010798d), new NpgsqlTypes.NpgsqlPoint(x: 0.02902503069569562d, y: 0.7361493019899612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.802525597133432d, y: 0.7899703751543612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013018597769632d, y: 0.34261503355834677d), new NpgsqlTypes.NpgsqlPoint(x: 0.791364007365178d, y: 0.259248593111702d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488209210855364d, y: 0.31268307883660373d), new NpgsqlTypes.NpgsqlPoint(x: 0.21903429485763692d, y: 0.025974560288895332d), new NpgsqlTypes.NpgsqlPoint(x: 0.623393489478583d, y: 0.29291861864486957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7369760726711946d, y: 0.920182714448033d), new NpgsqlTypes.NpgsqlPoint(x: 0.74736138867944d, y: 0.8873576846967454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195807237058469d, y: 0.6915676396046438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19349539641305435d, y: 0.40210106063601436d), new NpgsqlTypes.NpgsqlPoint(x: 0.38014106283990234d, y: 0.2615608044371245d), new NpgsqlTypes.NpgsqlPoint(x: 0.38235782261154827d, y: 0.4551783422801312d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1352821231745308d, y: 0.8837579920515128d), new NpgsqlTypes.NpgsqlPoint(x: 0.272318420851134d, y: 0.4557120668115344d), new NpgsqlTypes.NpgsqlPoint(x: 0.14388900829546425d, y: 0.6248326161311452d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5109312671642485d, y: 0.9393616048345328d), new NpgsqlTypes.NpgsqlPoint(x: 0.07004669647405048d, y: 0.36627895530373167d), new NpgsqlTypes.NpgsqlPoint(x: 0.240996570144694d, y: 0.8057827551176645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2264741872180559d, y: 0.2973320894701865d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246175629301108d, y: 0.6864729291779694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093870183273001d, y: 0.07762504802980785d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9601264244587382d, y: 0.872147589790014d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543959585068045d, y: 0.9814725483374387d), new NpgsqlTypes.NpgsqlPoint(x: 0.18528155496575116d, y: 0.760438637842209d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31628088735189286d, y: 0.9815165076132253d), new NpgsqlTypes.NpgsqlPoint(x: 0.1529584958071717d, y: 0.687355537754334d), new NpgsqlTypes.NpgsqlPoint(x: 0.052432287659971766d, y: 0.07584792628244363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4010043889930114d, y: 0.16812249684723723d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813658013138935d, y: 0.5030449826412454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9704373700127339d, y: 0.8038015138855068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1310601076992236d, y: 0.9727221974492651d), new NpgsqlTypes.NpgsqlPoint(x: 0.17370893929845488d, y: 0.07327240922479616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320479800358934d, y: 0.3648427548941606d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7684458223079857d, y: 0.8313186735889535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9083962593146023d, y: 0.27727614186557925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036838102615018d, y: 0.806184880234499d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6577690600323591d, y: 0.6631357358768316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6200505467381655d, y: 0.3952292704808823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855846019450245d, y: 0.8932491599972959d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004779889740236465d, y: 0.05224883203032815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699984295479682d, y: 0.36050838911475935d), new NpgsqlTypes.NpgsqlPoint(x: 0.3287640665797036d, y: 0.6172238244435889d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5303108942100506d, y: 0.9391523849125893d), new NpgsqlTypes.NpgsqlPoint(x: 0.25692131417021347d, y: 0.3921459421681489d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082587008600007d, y: 0.28436265334407795d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366751393556695d, y: 0.5631382189554297d), new NpgsqlTypes.NpgsqlPoint(x: 0.368647927735967d, y: 0.4531446319366629d), new NpgsqlTypes.NpgsqlPoint(x: 0.2193832054775493d, y: 0.48348650694832596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5648308732795535d, y: 0.8376413259928897d), new NpgsqlTypes.NpgsqlPoint(x: 0.1328768183625879d, y: 0.1232274000804865d), new NpgsqlTypes.NpgsqlPoint(x: 0.584242156197126d, y: 0.026744981202908358d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8984520602080838d, y: 0.5678416550865392d), new NpgsqlTypes.NpgsqlPoint(x: 0.20677508421276114d, y: 0.6586973466708015d), new NpgsqlTypes.NpgsqlPoint(x: 0.08048769067069195d, y: 0.02153702459981177d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13355606767461348d, y: 0.6135646192325611d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455558549926724d, y: 0.9734605686752348d), new NpgsqlTypes.NpgsqlPoint(x: 0.0695586314447405d, y: 0.35377383040933397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39922500358096424d, y: 0.5736259921536028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3208990955251555d, y: 0.8591951557884302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168870862495496d, y: 0.20834320313514532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31441542497757724d, y: 0.16913519505349606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5791615559537939d, y: 0.22071549901196374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203015265837286d, y: 0.07304303528472633d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935964139396295d, y: 0.43792568860591696d), new NpgsqlTypes.NpgsqlPoint(x: 0.48799530688430226d, y: 0.10789301203924095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2789994073527936d, y: 0.6315732214969139d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780418504367711d, y: 0.5857756793773595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301195142660409d, y: 0.6002582517351359d), new NpgsqlTypes.NpgsqlPoint(x: 0.25842189854861586d, y: 0.32029335350055577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.645670106099371d, y: 0.6220765671222795d), new NpgsqlTypes.NpgsqlPoint(x: 0.09696862433326991d, y: 0.34611000921055957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0115479050202687d, y: 0.1572406606417427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20781411625723245d, y: 0.9515734998049349d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376395686791445d, y: 0.26461252406719604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451392305907327d, y: 0.9508986180970368d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8091314732658381d, y: 0.6408295099748044d), new NpgsqlTypes.NpgsqlPoint(x: 0.11579563122941305d, y: 0.462480498269905d), new NpgsqlTypes.NpgsqlPoint(x: 0.09518758580614228d, y: 0.8996091342611122d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023686229245832635d, y: 0.5703793799515063d), new NpgsqlTypes.NpgsqlPoint(x: 0.31530254955653314d, y: 0.8880395139948853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317586169306778d, y: 0.05949631839687031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6862662352610157d, y: 0.8038648423570159d), new NpgsqlTypes.NpgsqlPoint(x: 0.24663562222714985d, y: 0.9971008802862982d), new NpgsqlTypes.NpgsqlPoint(x: 0.011825022784728634d, y: 0.9883266673575717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5836301007607663d, y: 0.28275455384548087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904539713298163d, y: 0.07488524728261647d), new NpgsqlTypes.NpgsqlPoint(x: 0.48734976679147046d, y: 0.5390063978280056d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9474480329014129d, y: 0.4865619631625894d), new NpgsqlTypes.NpgsqlPoint(x: 0.14256543847421355d, y: 0.07669775616328967d), new NpgsqlTypes.NpgsqlPoint(x: 0.567782284671391d, y: 0.813337877457738d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271680629761793d, y: 0.6494783556649558d), new NpgsqlTypes.NpgsqlPoint(x: 0.24955146841359555d, y: 0.6525643345252311d), new NpgsqlTypes.NpgsqlPoint(x: 0.917856237576997d, y: 0.0036317181240375085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11068221240373133d, y: 0.0615092969344454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565206951342339d, y: 0.35657977748381553d), new NpgsqlTypes.NpgsqlPoint(x: 0.46017624963839887d, y: 0.8732530575405212d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7591453371129822d, y: 0.6683279666692156d), new NpgsqlTypes.NpgsqlPoint(x: 0.500828764561984d, y: 0.3370573611999327d), new NpgsqlTypes.NpgsqlPoint(x: 0.1584349868755257d, y: 0.7681087230056075d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8092681297200633d, y: 0.9215388550729187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6031010661640921d, y: 0.5465569592186836d), new NpgsqlTypes.NpgsqlPoint(x: 0.2594288518959026d, y: 0.9655372046682198d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.880207988929118d, y: 0.011879677822907664d), new NpgsqlTypes.NpgsqlPoint(x: 0.36370876376775674d, y: 0.9873509000405948d), new NpgsqlTypes.NpgsqlPoint(x: 0.14169447792766743d, y: 0.605989890339769d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903048577052875d, y: 0.1487489615028713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8395700634240629d, y: 0.49196563520226533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102070562016494d, y: 0.8520627790521373d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2257585577294089d, y: 0.03460738494557325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273444011707707d, y: 0.45619024454446666d), new NpgsqlTypes.NpgsqlPoint(x: 0.26493536549091723d, y: 0.5751038848344757d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3307204836699068d, y: 0.41734318381748425d), new NpgsqlTypes.NpgsqlPoint(x: 0.11221072308932711d, y: 0.19362584138723493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438098833815915d, y: 0.054943231505883317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13834452778218786d, y: 0.49902009695180694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075813090314225d, y: 0.9608980091846014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421699513302759d, y: 0.6173844584292858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6142516874073249d, y: 0.8522933367655237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100422264858236d, y: 0.9022331982636853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1788257686437622d, y: 0.8811381877095495d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08477544325134767d, y: 0.42123690161777083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011735571951388d, y: 0.6735611176071438d), new NpgsqlTypes.NpgsqlPoint(x: 0.07374873454116448d, y: 0.2747418405893943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020676973400541865d, y: 0.09303445392683618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5135408389190842d, y: 0.48301203324279673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753036604783352d, y: 0.8244135904243063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22446938137292716d, y: 0.79854195437665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4828424311077625d, y: 0.9426873952570012d), new NpgsqlTypes.NpgsqlPoint(x: 0.18238991082581968d, y: 0.809894211670007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7829959754817465d, y: 0.042051729023439566d), new NpgsqlTypes.NpgsqlPoint(x: 0.33368251297849805d, y: 0.40940381528930603d), new NpgsqlTypes.NpgsqlPoint(x: 0.14571123509007433d, y: 0.3545527847411456d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6506462202148303d, y: 0.6282333746771518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889451387670236d, y: 0.738943147777699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504058864256747d, y: 0.5129336616540247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14391204644635647d, y: 0.7085658420192372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107184472277178d, y: 0.07187140455965879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134948020088135d, y: 0.08245554027858204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136159686352339d, y: 0.8371038029874176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642393048698603d, y: 0.9852511364050558d), new NpgsqlTypes.NpgsqlPoint(x: 0.18917287544051165d, y: 0.27530481093342574d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8227542765653769d, y: 0.5526248985646101d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718723928322207d, y: 0.3598389827776248d), new NpgsqlTypes.NpgsqlPoint(x: 0.17407448235349954d, y: 0.8856773711903828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4312764325465306d, y: 0.6080012674610958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2956481858318638d, y: 0.4542857116012651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7486910543993622d, y: 0.21564301244116912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8401525959291242d, y: 0.14133272042329859d), new NpgsqlTypes.NpgsqlPoint(x: 0.2187764119901514d, y: 0.09311981306639772d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878370085719702d, y: 0.713963773506456d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27030181111551665d, y: 0.9972438885208275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8086125488923966d, y: 0.30519727781223827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046959115549846d, y: 0.959596828276524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6670519908154205d, y: 0.8262535183700123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591141565575089d, y: 0.430678124810843d), new NpgsqlTypes.NpgsqlPoint(x: 0.08023655633723015d, y: 0.31750202564080054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.558454273964796d, y: 0.5507753880350953d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470310332071529d, y: 0.5931944915090848d), new NpgsqlTypes.NpgsqlPoint(x: 0.909574282195303d, y: 0.78414344544047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3150878636280965d, y: 0.9808940266513316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687629591611636d, y: 0.4632259210586458d), new NpgsqlTypes.NpgsqlPoint(x: 0.2150096671979832d, y: 0.17326528473040914d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1036005940272261d, y: 0.8289479601747352d), new NpgsqlTypes.NpgsqlPoint(x: 0.14825443637063618d, y: 0.18877946707933968d), new NpgsqlTypes.NpgsqlPoint(x: 0.05069609858268731d, y: 0.3710862134843913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9121210409043329d, y: 0.6104222175308313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219041600415672d, y: 0.30287926299878654d), new NpgsqlTypes.NpgsqlPoint(x: 0.17344218300826597d, y: 0.5100213057041186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.991204263491187d, y: 0.11436559754717324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801558715819774d, y: 0.6993051114325736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070035597790283d, y: 0.6137730978027658d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0961027658274326d, y: 0.19116978615525138d), new NpgsqlTypes.NpgsqlPoint(x: 0.06874558636760919d, y: 0.6163466615986195d), new NpgsqlTypes.NpgsqlPoint(x: 0.666287755538714d, y: 0.88241853054516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.396626627092484d, y: 0.1998269044969384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928471119288628d, y: 0.9321766112713895d), new NpgsqlTypes.NpgsqlPoint(x: 0.613784863711342d, y: 0.6217101591892993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9858634229698906d, y: 0.5083196362555443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380240316974835d, y: 0.9517742378253666d), new NpgsqlTypes.NpgsqlPoint(x: 0.691622425420642d, y: 0.14209403723571568d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9337413795647271d, y: 0.5803082771722793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972195314601408d, y: 0.040824573385082163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356169198260929d, y: 0.854104282573492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.567229778901378d, y: 0.5727371956711726d), new NpgsqlTypes.NpgsqlPoint(x: 0.19095531039097935d, y: 0.07677777415273734d), new NpgsqlTypes.NpgsqlPoint(x: 0.030562061189857825d, y: 0.10571161641849736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18489894962140518d, y: 0.1898660370364842d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093285823687888d, y: 0.7280744598702659d), new NpgsqlTypes.NpgsqlPoint(x: 0.32328771452013483d, y: 0.20854753149432392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7393948210801007d, y: 0.34802653716872733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8431115089343656d, y: 0.8858200359940601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037630161092152d, y: 0.4170288348596254d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7212824967531491d, y: 0.8128093088652608d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912678647639859d, y: 0.033839440558214084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389899859385729d, y: 0.6468333675663497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9177274264330155d, y: 0.5169024461103926d), new NpgsqlTypes.NpgsqlPoint(x: 0.37510156634876746d, y: 0.0036839862820756686d), new NpgsqlTypes.NpgsqlPoint(x: 0.15363108295782402d, y: 0.2655254836062799d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44020463852043024d, y: 0.09570763916953273d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560768162449226d, y: 0.878173398238428d), new NpgsqlTypes.NpgsqlPoint(x: 0.3971511058747864d, y: 0.09445802019426996d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7073639197256503d, y: 0.4238194544321524d), new NpgsqlTypes.NpgsqlPoint(x: 0.32558389496660955d, y: 0.2186366994674116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2158116672617807d, y: 0.2751277943829825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05709670517113774d, y: 0.7585999777821838d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983741325141394d, y: 0.5193120796136622d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416320817407081d, y: 0.11217340734163683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9700051382536076d, y: 0.43764715463458104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369849468053854d, y: 0.43271362804593383d), new NpgsqlTypes.NpgsqlPoint(x: 0.280744602435396d, y: 0.3137055781019843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5572404041097088d, y: 0.4894556197231529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818172286866085d, y: 0.8477898421756787d), new NpgsqlTypes.NpgsqlPoint(x: 0.19426113458477312d, y: 0.07753948252399823d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7169317011899274d, y: 0.8704327507501647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210526445818295d, y: 0.5686019281047553d), new NpgsqlTypes.NpgsqlPoint(x: 0.36269325697294896d, y: 0.3203985926686611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6547447489559298d, y: 0.7746680363197924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6230997943948976d, y: 0.3809594852486604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158723231893697d, y: 0.004458142041929736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10029252815045953d, y: 0.07456108320244603d), new NpgsqlTypes.NpgsqlPoint(x: 0.007873560274531455d, y: 0.8632859100650111d), new NpgsqlTypes.NpgsqlPoint(x: 0.4925101692490973d, y: 0.976437981387157d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6563190509309343d, y: 0.6898296903850323d), new NpgsqlTypes.NpgsqlPoint(x: 0.20468799132271176d, y: 0.17612002408787975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9585749576496853d, y: 0.6801301718576377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09506473372858759d, y: 0.6554912413706289d), new NpgsqlTypes.NpgsqlPoint(x: 0.09633334333616694d, y: 0.9717442968248643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446395833639066d, y: 0.20847184753940928d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736761021137071d, y: 0.9520461716277996d), new NpgsqlTypes.NpgsqlPoint(x: 0.4287608184664403d, y: 0.8976143468210539d), new NpgsqlTypes.NpgsqlPoint(x: 0.11620901643049708d, y: 0.29071119474268414d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9279612419570155d, y: 0.08700774794478983d), new NpgsqlTypes.NpgsqlPoint(x: 0.2705898756917674d, y: 0.8803543520966887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382344633815076d, y: 0.650136924124608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3641148105754348d, y: 0.9306869617043144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825187709398834d, y: 0.07609385681669378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3249579343169616d, y: 0.9951318493799822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664137796527927d, y: 0.12470099176467664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3587087796647044d, y: 0.42355166176929304d), new NpgsqlTypes.NpgsqlPoint(x: 0.39797534292840053d, y: 0.31248166380685427d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6819588401342085d, y: 0.09141681420992187d), new NpgsqlTypes.NpgsqlPoint(x: 0.10323795941819103d, y: 0.9024074482153027d), new NpgsqlTypes.NpgsqlPoint(x: 0.519457495634373d, y: 0.03383718461687657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0038125956536949612d, y: 0.7853064898430544d), new NpgsqlTypes.NpgsqlPoint(x: 0.24054746060519028d, y: 0.24699378360662105d), new NpgsqlTypes.NpgsqlPoint(x: 0.01292761555207822d, y: 0.20134812461941898d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7890910037265955d, y: 0.5707154323823532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259105721695254d, y: 0.06293634895383182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2296510716151816d, y: 0.44707282843168283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2673753961058013d, y: 0.9124522438001265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407641827095715d, y: 0.289304116254851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556751668497069d, y: 0.0991124720360389d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2145525278210808d, y: 0.1095283860114008d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085019712918644d, y: 0.23747753326130838d), new NpgsqlTypes.NpgsqlPoint(x: 0.052859028008568565d, y: 0.9588509781398868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6964009501367272d, y: 0.7761348198087868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4949601833171402d, y: 0.45171867913389063d), new NpgsqlTypes.NpgsqlPoint(x: 0.99975039768494d, y: 0.6952184214865805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9329065555471201d, y: 0.04954001606719649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747410467056279d, y: 0.694021133727211d), new NpgsqlTypes.NpgsqlPoint(x: 0.03367474703801021d, y: 0.4836222273053744d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7142426013818644d, y: 0.025271073411190725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364923186674345d, y: 0.24033245093077527d), new NpgsqlTypes.NpgsqlPoint(x: 0.07441924489090557d, y: 0.9834790874337029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.93916020080328d, y: 0.7571668918493919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607417277287257d, y: 0.17000754904427462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6751439498790841d, y: 0.16390856316382507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48706554683859793d, y: 0.5320353249929062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5595449204009867d, y: 0.923740345458784d), new NpgsqlTypes.NpgsqlPoint(x: 0.04909805335617845d, y: 0.573229794581194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1291620487520122d, y: 0.008556017730717569d), new NpgsqlTypes.NpgsqlPoint(x: 0.755006380971362d, y: 0.5469805661007906d), new NpgsqlTypes.NpgsqlPoint(x: 0.05332614992003637d, y: 0.2700787632121895d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26146293879635785d, y: 0.18981796345103552d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415078794675635d, y: 0.3391030217436789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057594763109665d, y: 0.7880507586375324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4546685535382857d, y: 0.6677091084696113d), new NpgsqlTypes.NpgsqlPoint(x: 0.847973654593239d, y: 0.46019565704858423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3618381628281836d, y: 0.6899586975377666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.375848038364445d, y: 0.8136639331695289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9347417862591474d, y: 0.7383211611751486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694306297504943d, y: 0.4149754305136365d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 194,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3902315377762037d, y: 0.39304178941222934d), new NpgsqlTypes.NpgsqlPoint(x: 0.952907280552161d, y: 0.8239282335082521d), new NpgsqlTypes.NpgsqlPoint(x: 0.1792765335146772d, y: 0.9087056554173454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.312262560401419d, y: 0.010458211025176078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8954033197042269d, y: 0.8439902364095175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454778148773887d, y: 0.5541199393261458d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41078077286520476d, y: 0.4073975408421462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7474583901711588d, y: 0.3588279654465404d), new NpgsqlTypes.NpgsqlPoint(x: 0.31574795102965636d, y: 0.31189840253988044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5845914315459977d, y: 0.8621219179365136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458689437839579d, y: 0.36475859854253745d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534364412465766d, y: 0.48397980089358905d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 99;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 60, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 9, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 168, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 165, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 174, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 111, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 141, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

