

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9063118319539258d,right: 0.4684942287220345d,bottom: 0.1868965625239798d,left: 0.174315312354138d),

new NpgsqlTypes.NpgsqlBox(top: 0.9528771976894095d,right: 0.14103131980146377d,bottom: 0.9512810192743394d,left: 0.10232465771330501d),

new NpgsqlTypes.NpgsqlBox(top: 0.9885117229808261d,right: 0.10420588001952713d,bottom: 0.4591103822689335d,left: 0.0595229149799229d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4492279974998391d,right: 0.9165528867060072d,bottom: 0.27850110737674394d,left: 0.5216807717555815d),

new NpgsqlTypes.NpgsqlBox(top: 0.23379571201916782d,right: 0.39523955886911366d,bottom: 0.12466911120568835d,left: 0.2617196058656296d),

new NpgsqlTypes.NpgsqlBox(top: 0.8345664318911189d,right: 0.9848605236386013d,bottom: 0.29424294912625815d,left: 0.15436932232039802d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8736455957352246d,right: 0.8274673434853593d,bottom: 0.6938372436096605d,left: 0.04137428177559943d),

new NpgsqlTypes.NpgsqlBox(top: 0.9383500755284752d,right: 0.9913428501660365d,bottom: 0.9248360126230307d,left: 0.9480811679924522d),

new NpgsqlTypes.NpgsqlBox(top: 0.661411158348773d,right: 0.3896835640605947d,bottom: 0.2916361596075523d,left: 0.3346041009094679d),

new NpgsqlTypes.NpgsqlBox(top: 0.3977449651585363d,right: 0.387856876732824d,bottom: 0.01801777975920338d,left: 0.05400395493316945d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6833741546000588d,right: 0.8427010753125778d,bottom: 0.06440960962006304d,left: 0.42874317576888976d),

new NpgsqlTypes.NpgsqlBox(top: 0.9817327855011507d,right: 0.8660166800159044d,bottom: 0.4917804246156857d,left: 0.38043447309976053d),

new NpgsqlTypes.NpgsqlBox(top: 0.5113329652448846d,right: 0.09804809442261964d,bottom: 0.20686874733044025d,left: 0.030789750583409492d),

new NpgsqlTypes.NpgsqlBox(top: 0.6745408883321468d,right: 0.959510538726035d,bottom: 0.22675964141229232d,left: 0.48809319781039096d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.943828388579102d,right: 0.37933331532032777d,bottom: 0.8657338190683901d,left: 0.0836215769358164d),

new NpgsqlTypes.NpgsqlBox(top: 0.4504191722316908d,right: 0.7139295169393989d,bottom: 0.24004755294368796d,left: 0.5817552672349042d),

new NpgsqlTypes.NpgsqlBox(top: 0.8144131053935239d,right: 0.9249730762285043d,bottom: 0.13729882681347005d,left: 0.09651785666501722d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9585213690434877d,right: 0.5574018440926157d,bottom: 0.6919010880264245d,left: 0.26017252415203673d),

new NpgsqlTypes.NpgsqlBox(top: 0.40953879334430243d,right: 0.6510460898826873d,bottom: 0.23288867319418205d,left: 0.25396399143045156d),

new NpgsqlTypes.NpgsqlBox(top: 0.9400505608141334d,right: 0.8912760937411116d,bottom: 0.1433233120045988d,left: 0.04637458498141911d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.596567036730442d,right: 0.44336871979885817d,bottom: 0.07347404633491827d,left: 0.08376093727627731d),

new NpgsqlTypes.NpgsqlBox(top: 0.27297192246882374d,right: 0.7840511121175381d,bottom: 0.05704572266790464d,left: 0.028755143698367736d),

new NpgsqlTypes.NpgsqlBox(top: 0.20003778436829922d,right: 0.28903715335697433d,bottom: 0.039679605202106116d,left: 0.01890362608698526d),

new NpgsqlTypes.NpgsqlBox(top: 0.9662866228837972d,right: 0.8953333480217216d,bottom: 0.9067073546186436d,left: 0.4289601077403803d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9416362775603471d,right: 0.9424586513462937d,bottom: 0.29933242300785456d,left: 0.8469863401986301d),

new NpgsqlTypes.NpgsqlBox(top: 0.525901083339752d,right: 0.6044302365287771d,bottom: 0.49676865242564383d,left: 0.22773048672789886d),

new NpgsqlTypes.NpgsqlBox(top: 0.32453249043917576d,right: 0.9480886944773386d,bottom: 0.2642717356471245d,left: 0.28353696818633123d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9419762680186876d,right: 0.7285237489630045d,bottom: 0.688713470272402d,left: 0.3100541574713762d),

new NpgsqlTypes.NpgsqlBox(top: 0.33010830396988533d,right: 0.4421599331371344d,bottom: 0.32607094748542886d,left: 0.02844961546847824d),

new NpgsqlTypes.NpgsqlBox(top: 0.48959530040988897d,right: 0.17653264818752046d,bottom: 0.09368488177078382d,left: 0.031872492328813284d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9029664606128889d,right: 0.5682084517429651d,bottom: 0.7700016237182471d,left: 0.4357812839661924d),

new NpgsqlTypes.NpgsqlBox(top: 0.15336361679771415d,right: 0.9325308721176948d,bottom: 0.12394933796490593d,left: 0.8534868841219133d),

new NpgsqlTypes.NpgsqlBox(top: 0.30525036647958015d,right: 0.4656279447733662d,bottom: 0.13612204897796687d,left: 0.20370643580406378d),

new NpgsqlTypes.NpgsqlBox(top: 0.25614573777706673d,right: 0.5699656676898297d,bottom: 0.09071142664616527d,left: 0.38306020029184706d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.576099304428483d,right: 0.5512347901369292d,bottom: 0.2530922178985038d,left: 0.11683684188349097d),

new NpgsqlTypes.NpgsqlBox(top: 0.6642318241827875d,right: 0.5135983503792778d,bottom: 0.5194448021799988d,left: 0.08230422338512111d),

new NpgsqlTypes.NpgsqlBox(top: 0.5326648411303667d,right: 0.797268607530192d,bottom: 0.37837748631722d,left: 0.2207300389650304d),

new NpgsqlTypes.NpgsqlBox(top: 0.4675924098221993d,right: 0.917870264494622d,bottom: 0.05211498249473523d,left: 0.6458669619220875d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.5207185904155778d,right: 0.6588812374845223d,bottom: 0.11016483572479607d,left: 0.3010596901785634d),

new NpgsqlTypes.NpgsqlBox(top: 0.4335039585208903d,right: 0.5403907671180123d,bottom: 0.3173880057791473d,left: 0.2587162724879889d),

new NpgsqlTypes.NpgsqlBox(top: 0.9821943224898734d,right: 0.8513182675358925d,bottom: 0.37496881434026275d,left: 0.8313405591122776d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5477919445798123d,right: 0.5822643315421416d,bottom: 0.1910803704406222d,left: 0.5430688055738317d),

new NpgsqlTypes.NpgsqlBox(top: 0.8519886158923559d,right: 0.4595482186295001d,bottom: 0.29898480700776053d,left: 0.23881535413038224d),

new NpgsqlTypes.NpgsqlBox(top: 0.3599932822320002d,right: 0.6224687283283188d,bottom: 0.09363135015105473d,left: 0.5153539964506761d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9588902531813411d,right: 0.876169981576258d,bottom: 0.918429311222681d,left: 0.45701099999733585d),

new NpgsqlTypes.NpgsqlBox(top: 0.37642689661493445d,right: 0.9371078001786773d,bottom: 0.053020096602911515d,left: 0.5092717567888218d),

new NpgsqlTypes.NpgsqlBox(top: 0.9050000074298319d,right: 0.8244951232496329d,bottom: 0.7259386743773438d,left: 0.18482617323572215d),

new NpgsqlTypes.NpgsqlBox(top: 0.8113992837734947d,right: 0.8246696058173795d,bottom: 0.41775632698362564d,left: 0.3423099087373639d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8607642087583796d,right: 0.7122796327155325d,bottom: 0.7375539032697858d,left: 0.3101566694974527d),

new NpgsqlTypes.NpgsqlBox(top: 0.5139730455916699d,right: 0.1832183864368777d,bottom: 0.3646562108229172d,left: 0.08986934378004219d),

new NpgsqlTypes.NpgsqlBox(top: 0.7041711109177856d,right: 0.8572834009148603d,bottom: 0.2615663401165289d,left: 0.16889539365584794d),

new NpgsqlTypes.NpgsqlBox(top: 0.897254597053796d,right: 0.9851489150334766d,bottom: 0.18709223933201202d,left: 0.4660926673269107d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6467596282417423d,right: 0.138721344750678d,bottom: 0.4509138858843681d,left: 0.047709302848752966d),

new NpgsqlTypes.NpgsqlBox(top: 0.12885322930732723d,right: 0.8369669690189803d,bottom: 0.12054063491033606d,left: 0.39444395025244516d),

new NpgsqlTypes.NpgsqlBox(top: 0.8776883207305507d,right: 0.6022498515337811d,bottom: 0.31689505120690553d,left: 0.3464555340422114d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.927793696195409d,right: 0.7206383515793571d,bottom: 0.5277936850147383d,left: 0.038416397413090664d),

new NpgsqlTypes.NpgsqlBox(top: 0.3292905690335719d,right: 0.3180761097852999d,bottom: 0.08464006141569735d,left: 0.016181081180501877d),

new NpgsqlTypes.NpgsqlBox(top: 0.6449589560428047d,right: 0.15777399529860126d,bottom: 0.5882712991732166d,left: 0.0286927154388793d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6494763250920299d,right: 0.35516488315265216d,bottom: 0.14111306937118473d,left: 0.13319712770529046d),

new NpgsqlTypes.NpgsqlBox(top: 0.8132484021641792d,right: 0.8956856304581248d,bottom: 0.44645420141235637d,left: 0.05145835392809761d),

new NpgsqlTypes.NpgsqlBox(top: 0.8811398498655673d,right: 0.7808881671536743d,bottom: 0.28501877313995494d,left: 0.4306926704893079d),

new NpgsqlTypes.NpgsqlBox(top: 0.7811665275811086d,right: 0.9809738046608589d,bottom: 0.10771391308554401d,left: 0.38180704135565624d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37191906046538137d,right: 0.7561473138558474d,bottom: 0.255056779754538d,left: 0.7467112682779954d),

new NpgsqlTypes.NpgsqlBox(top: 0.7611266292170004d,right: 0.34849500448470505d,bottom: 0.6719614520498114d,left: 0.257966603605296d),

new NpgsqlTypes.NpgsqlBox(top: 0.1995143981844375d,right: 0.8717625084003661d,bottom: 0.11566906702207114d,left: 0.38541372830265286d),

new NpgsqlTypes.NpgsqlBox(top: 0.8302179265947466d,right: 0.695986835555718d,bottom: 0.47603094150497427d,left: 0.37082680797963674d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7866960151749917d,right: 0.9763591353222927d,bottom: 0.0655247659529864d,left: 0.015001151019176762d),

new NpgsqlTypes.NpgsqlBox(top: 0.4473141968155291d,right: 0.9709498718979729d,bottom: 0.4393487251105742d,left: 0.637918585452637d),

new NpgsqlTypes.NpgsqlBox(top: 0.9667504365051002d,right: 0.6255705497163256d,bottom: 0.30198819954151035d,left: 0.5594648719732062d),

new NpgsqlTypes.NpgsqlBox(top: 0.7128445492292793d,right: 0.7214282880224029d,bottom: 0.2836792929272616d,left: 0.6227445159989967d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7186714799799425d,right: 0.9640139349811588d,bottom: 0.5915827968042918d,left: 0.5732608274187072d),

new NpgsqlTypes.NpgsqlBox(top: 0.8458021393877705d,right: 0.9906703836466093d,bottom: 0.02065319799056009d,left: 0.6867758330151952d),

new NpgsqlTypes.NpgsqlBox(top: 0.7678003208378824d,right: 0.5544941693429896d,bottom: 0.6223012316206642d,left: 0.09033695639732209d),

new NpgsqlTypes.NpgsqlBox(top: 0.40137076862786514d,right: 0.4013337778448406d,bottom: 0.08998308309314729d,left: 0.2154385230279211d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6679586061648042d,right: 0.6986291496780275d,bottom: 0.36661994488336735d,left: 0.10530894425112691d),

new NpgsqlTypes.NpgsqlBox(top: 0.43803087851504574d,right: 0.9487200885236989d,bottom: 0.4295621689845932d,left: 0.9439874313668479d),

new NpgsqlTypes.NpgsqlBox(top: 0.9560661907427674d,right: 0.5115660593270402d,bottom: 0.8225897158823428d,left: 0.15787441544605885d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8283633473519099d,right: 0.7944133214521861d,bottom: 0.7439629282909525d,left: 0.013468854367702843d),

new NpgsqlTypes.NpgsqlBox(top: 0.5686065754532204d,right: 0.3264331060627502d,bottom: 0.058516737530280416d,left: 0.24608280597963605d),

new NpgsqlTypes.NpgsqlBox(top: 0.9937003559830191d,right: 0.7826569016809449d,bottom: 0.07387908448094804d,left: 0.4706787577374726d),

new NpgsqlTypes.NpgsqlBox(top: 0.9040379688505088d,right: 0.8152571229170937d,bottom: 0.6960465099416457d,left: 0.4833551807385301d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.30853187074609545d,right: 0.7166931526417332d,bottom: 0.2190028691453887d,left: 0.1747295567652124d),

new NpgsqlTypes.NpgsqlBox(top: 0.5318890109593198d,right: 0.6891967353673697d,bottom: 0.032166243781141746d,left: 0.12919735319679115d),

new NpgsqlTypes.NpgsqlBox(top: 0.45535787885676327d,right: 0.9556238123367983d,bottom: 0.2155812675917148d,left: 0.830063508721521d),

new NpgsqlTypes.NpgsqlBox(top: 0.9246755316984294d,right: 0.6172985685909055d,bottom: 0.1505889218649007d,left: 0.219362888714698d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6858665666965901d,right: 0.7496119339970099d,bottom: 0.4964693274000864d,left: 0.5295622323962521d),

new NpgsqlTypes.NpgsqlBox(top: 0.9995102619189367d,right: 0.773270718027597d,bottom: 0.19270718839859546d,left: 0.2356993511353186d),

new NpgsqlTypes.NpgsqlBox(top: 0.7797203522641148d,right: 0.125293831157534d,bottom: 0.5233372745380253d,left: 0.09773714507460662d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7931162346562576d,right: 0.6245426418760776d,bottom: 0.4786581280800878d,left: 0.24009535889844746d),

new NpgsqlTypes.NpgsqlBox(top: 0.959151383160235d,right: 0.14610904273740566d,bottom: 0.7121076751432671d,left: 0.11448130958568348d),

new NpgsqlTypes.NpgsqlBox(top: 0.3207763912147753d,right: 0.35150131531504303d,bottom: 0.05987680153250696d,left: 0.195900368897719d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9625693770354977d,right: 0.9388625768775596d,bottom: 0.3110568780660007d,left: 0.45825672393371175d),

new NpgsqlTypes.NpgsqlBox(top: 0.6005831362070797d,right: 0.6457086018801406d,bottom: 0.2521497647636154d,left: 0.4701461695068019d),

new NpgsqlTypes.NpgsqlBox(top: 0.829759059871015d,right: 0.7646243868314913d,bottom: 0.23930954493923862d,left: 0.20724565577377096d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9984460585519578d,right: 0.924026895046754d,bottom: 0.4676669316653743d,left: 0.5845821148908251d),

new NpgsqlTypes.NpgsqlBox(top: 0.36475370795873263d,right: 0.7265381057283551d,bottom: 0.14830175800121914d,left: 0.5495108173961238d),

new NpgsqlTypes.NpgsqlBox(top: 0.6806800580023457d,right: 0.6483198837706851d,bottom: 0.2936082133984895d,left: 0.4495878836485201d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5962329384171527d,right: 0.6584447483640136d,bottom: 0.2525002909057307d,left: 0.16248340524890714d),

new NpgsqlTypes.NpgsqlBox(top: 0.8369555776026159d,right: 0.53737943517649d,bottom: 0.526195462239882d,left: 0.11917156615123148d),

new NpgsqlTypes.NpgsqlBox(top: 0.7946019943718589d,right: 0.8108008534109157d,bottom: 0.09690306024085049d,left: 0.7819912812599582d),

new NpgsqlTypes.NpgsqlBox(top: 0.9471785894915788d,right: 0.4777923745651258d,bottom: 0.6316102616795533d,left: 0.37859265876002857d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9639192884569655d,right: 0.990826019481219d,bottom: 0.6741495899487354d,left: 0.7723035668856739d),

new NpgsqlTypes.NpgsqlBox(top: 0.7585699249926016d,right: 0.966256805734285d,bottom: 0.23165111443902686d,left: 0.22480158149589224d),

new NpgsqlTypes.NpgsqlBox(top: 0.2773910376590133d,right: 0.7646494922349342d,bottom: 0.1820852143367837d,left: 0.0054309779911729805d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9752131388857859d,right: 0.8227635501514199d,bottom: 0.3068970761435982d,left: 0.05155073150433387d),

new NpgsqlTypes.NpgsqlBox(top: 0.8771812085823861d,right: 0.5260271367122762d,bottom: 0.24479288184596404d,left: 0.32142638840226334d),

new NpgsqlTypes.NpgsqlBox(top: 0.8344110960216d,right: 0.29950393986360613d,bottom: 0.6028360324070619d,left: 0.15479605513361516d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.26427013026061164d,right: 0.958895736330543d,bottom: 0.053488154289075274d,left: 0.0969175015410969d),

new NpgsqlTypes.NpgsqlBox(top: 0.9764903504146895d,right: 0.779157730930577d,bottom: 0.8104419324444053d,left: 0.07110175005465735d),

new NpgsqlTypes.NpgsqlBox(top: 0.24789982720319692d,right: 0.8233554458062325d,bottom: 0.005452348276778096d,left: 0.3260881104559068d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33598878685592015d,right: 0.7298264919174143d,bottom: 0.03595580859710945d,left: 0.533164846879309d),

new NpgsqlTypes.NpgsqlBox(top: 0.37602071732763864d,right: 0.9745038511088921d,bottom: 0.3066633400922516d,left: 0.09990261711249215d),

new NpgsqlTypes.NpgsqlBox(top: 0.8804846658137722d,right: 0.9394789521176781d,bottom: 0.8796758033070737d,left: 0.8916089628116625d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5349294726620968d,right: 0.7142486911336037d,bottom: 0.24620797438135156d,left: 0.25090132251640096d),

new NpgsqlTypes.NpgsqlBox(top: 0.5365549899841786d,right: 0.8719285180991172d,bottom: 0.166037720218011d,left: 0.16360887809146507d),

new NpgsqlTypes.NpgsqlBox(top: 0.3362210827069394d,right: 0.9902921154185257d,bottom: 0.229070468444174d,left: 0.5329095971637728d),

new NpgsqlTypes.NpgsqlBox(top: 0.9933683508389508d,right: 0.3980207702895542d,bottom: 0.18764939273367576d,left: 0.09712768832750796d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6596105122430372d,right: 0.3476973889242486d,bottom: 0.34610603469198764d,left: 0.041591049808999414d),

new NpgsqlTypes.NpgsqlBox(top: 0.8533131799910535d,right: 0.7339418275948292d,bottom: 0.26127631593036815d,left: 0.25525801547882143d),

new NpgsqlTypes.NpgsqlBox(top: 0.8829994034041323d,right: 0.3182720395685551d,bottom: 0.5730366646409475d,left: 0.2556157228855578d),

new NpgsqlTypes.NpgsqlBox(top: 0.6888272636250882d,right: 0.8703117382692007d,bottom: 0.35214431014167935d,left: 0.5982850288211362d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6191064568191017d,right: 0.3588419668532845d,bottom: 0.1700381489259286d,left: 0.01889589484295906d),

new NpgsqlTypes.NpgsqlBox(top: 0.9141170861894277d,right: 0.2646391372312884d,bottom: 0.7437778266614842d,left: 0.1189018110939839d),

new NpgsqlTypes.NpgsqlBox(top: 0.20530157910491942d,right: 0.22178210730184444d,bottom: 0.040612719901534255d,left: 0.03588510286518143d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4628663571587488d,right: 0.8571937920402694d,bottom: 0.1105978247064695d,left: 0.6888035758101436d),

new NpgsqlTypes.NpgsqlBox(top: 0.4226219164532279d,right: 0.9855645958321043d,bottom: 0.2037294575467249d,left: 0.8220227625634026d),

new NpgsqlTypes.NpgsqlBox(top: 0.7743737484723148d,right: 0.5879021377959815d,bottom: 0.03784671890168545d,left: 0.037874013799268025d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9264088901068804d,right: 0.3496417380094884d,bottom: 0.3484944215539505d,left: 0.2065126081176697d),

new NpgsqlTypes.NpgsqlBox(top: 0.9253585532927343d,right: 0.9501434947230554d,bottom: 0.16787783393663047d,left: 0.6712982593665348d),

new NpgsqlTypes.NpgsqlBox(top: 0.4380635270580122d,right: 0.3232664661648337d,bottom: 0.12161342094238159d,left: 0.3125608036990152d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2202725646116641d,right: 0.7452489499659667d,bottom: 0.0468641219653918d,left: 0.28338579442885004d),

new NpgsqlTypes.NpgsqlBox(top: 0.9425102918194256d,right: 0.9497238381538828d,bottom: 0.19821103551858188d,left: 0.6571425271184413d),

new NpgsqlTypes.NpgsqlBox(top: 0.8451858387988477d,right: 0.6493701288192305d,bottom: 0.7282132765790228d,left: 0.3173359141867972d),

new NpgsqlTypes.NpgsqlBox(top: 0.5344651549882928d,right: 0.7578820617855166d,bottom: 0.47108571862087834d,left: 0.48582408332384064d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6531673938168683d,right: 0.7850474280550742d,bottom: 0.1521231475786744d,left: 0.23369951339657524d),

new NpgsqlTypes.NpgsqlBox(top: 0.24538325789483872d,right: 0.7173648388078384d,bottom: 0.14303729017590405d,left: 0.7100730123870181d),

new NpgsqlTypes.NpgsqlBox(top: 0.8268270586366612d,right: 0.5935380148405796d,bottom: 0.263925799950666d,left: 0.09700251110340807d),

new NpgsqlTypes.NpgsqlBox(top: 0.8592011248122987d,right: 0.8983422153853607d,bottom: 0.52648550276317d,left: 0.8534329217169632d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8454893645490813d,right: 0.691322436857225d,bottom: 0.6984927099217898d,left: 0.6360829371493883d),

new NpgsqlTypes.NpgsqlBox(top: 0.5932288119134d,right: 0.9924488395179191d,bottom: 0.0003758963654965086d,left: 0.9707379026161258d),

new NpgsqlTypes.NpgsqlBox(top: 0.8591833000825392d,right: 0.3704107336237893d,bottom: 0.8508768204776644d,left: 0.23802474644877136d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20765522340499687d,right: 0.7841776555880052d,bottom: 0.13440083361108335d,left: 0.019950469972705998d),

new NpgsqlTypes.NpgsqlBox(top: 0.3403511023443677d,right: 0.2979972602327303d,bottom: 0.010379245230160095d,left: 0.13586510525493978d),

new NpgsqlTypes.NpgsqlBox(top: 0.5170376148992839d,right: 0.27702784687632187d,bottom: 0.23614044550959445d,left: 0.1196861163517875d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6179477854773457d,right: 0.8973637446523686d,bottom: 0.2856345665429646d,left: 0.27024052916898844d),

new NpgsqlTypes.NpgsqlBox(top: 0.8298301423159288d,right: 0.8118118216123329d,bottom: 0.7561349027859842d,left: 0.015847670850438922d),

new NpgsqlTypes.NpgsqlBox(top: 0.6365548529156765d,right: 0.7376170248507395d,bottom: 0.04960232245380336d,left: 0.02505599823005955d),

new NpgsqlTypes.NpgsqlBox(top: 0.7087887724653917d,right: 0.7527183928092198d,bottom: 0.6229220826227021d,left: 0.16440018437404325d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9203946780649209d,right: 0.7672877528842869d,bottom: 0.1778576808625545d,left: 0.18040412474060996d),

new NpgsqlTypes.NpgsqlBox(top: 0.985602748949151d,right: 0.5994933674449643d,bottom: 0.9753946244847985d,left: 0.3347610884630907d),

new NpgsqlTypes.NpgsqlBox(top: 0.8894093210934928d,right: 0.9565634973981317d,bottom: 0.545135952672871d,left: 0.19282041988576748d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7028377056919736d,right: 0.9899518591901023d,bottom: 0.32274674796681313d,left: 0.8333673097826879d),

new NpgsqlTypes.NpgsqlBox(top: 0.9773894749744099d,right: 0.9732412671919408d,bottom: 0.31331638651403226d,left: 0.6101572943022812d),

new NpgsqlTypes.NpgsqlBox(top: 0.46971492487211686d,right: 0.33924174491872516d,bottom: 0.05697231668236835d,left: 0.12197874079161031d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8532303954363175d,right: 0.8966692992552435d,bottom: 0.1758444955471773d,left: 0.19668797543324035d),

new NpgsqlTypes.NpgsqlBox(top: 0.4120052674882052d,right: 0.650223196119889d,bottom: 0.05612495710430765d,left: 0.5253982599205481d),

new NpgsqlTypes.NpgsqlBox(top: 0.9935834734460178d,right: 0.26131994244328316d,bottom: 0.006892703267112332d,left: 0.2497464622176797d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32556522224325524d,right: 0.936992043174988d,bottom: 0.28487436169498803d,left: 0.24301978033707605d),

new NpgsqlTypes.NpgsqlBox(top: 0.6293346851053027d,right: 0.5805228146530054d,bottom: 0.27223331669700224d,left: 0.13981814201652054d),

new NpgsqlTypes.NpgsqlBox(top: 0.4591264109169959d,right: 0.8480647266583798d,bottom: 0.07128898628484148d,left: 0.5207269346488536d),

new NpgsqlTypes.NpgsqlBox(top: 0.4985174703480929d,right: 0.6357067330587781d,bottom: 0.08870632510992726d,left: 0.5266143325998619d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6429265661282748d,right: 0.9571069841624609d,bottom: 0.1028326952525237d,left: 0.7179331645314669d),

new NpgsqlTypes.NpgsqlBox(top: 0.9467872005317319d,right: 0.6028233327849033d,bottom: 0.9259241076679022d,left: 0.07077724391530915d),

new NpgsqlTypes.NpgsqlBox(top: 0.8084284341251421d,right: 0.8199404537482379d,bottom: 0.04179914124502526d,left: 0.5539708226605559d),

new NpgsqlTypes.NpgsqlBox(top: 0.6627186757293289d,right: 0.7208705669397475d,bottom: 0.21227620199694275d,left: 0.5394495300792211d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8226073560418186d,right: 0.5481409730772088d,bottom: 0.7285874247884296d,left: 0.5382557075036143d),

new NpgsqlTypes.NpgsqlBox(top: 0.8325178251636984d,right: 0.7278140077410674d,bottom: 0.3274526415819441d,left: 0.19083612037558562d),

new NpgsqlTypes.NpgsqlBox(top: 0.6274717928825232d,right: 0.6684437646362088d,bottom: 0.3703806265796926d,left: 0.5402879584139793d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.734145241459181d,right: 0.7782965768664264d,bottom: 0.4394935476924329d,left: 0.5975290681407445d),

new NpgsqlTypes.NpgsqlBox(top: 0.7311451310511662d,right: 0.8102478148101336d,bottom: 0.26326071889101943d,left: 0.431889635082949d),

new NpgsqlTypes.NpgsqlBox(top: 0.9272797814874028d,right: 0.8944541855980147d,bottom: 0.05277506907595775d,left: 0.2552365059149355d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7830365980470425d,right: 0.7748132798006594d,bottom: 0.6661016827255116d,left: 0.2917932814988756d),

new NpgsqlTypes.NpgsqlBox(top: 0.9295375326221217d,right: 0.33638113571044626d,bottom: 0.4156697108533529d,left: 0.12323259299171008d),

new NpgsqlTypes.NpgsqlBox(top: 0.6229995663503257d,right: 0.3992597786305043d,bottom: 0.14708777102324522d,left: 0.18021669131538298d),

new NpgsqlTypes.NpgsqlBox(top: 0.8777444591249165d,right: 0.4702306945914807d,bottom: 0.13193755695167564d,left: 0.2640036513950714d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8005535724292819d,right: 0.7345251171312902d,bottom: 0.4876842261841562d,left: 0.21768639509975052d),

new NpgsqlTypes.NpgsqlBox(top: 0.5905120105933513d,right: 0.8904422226364134d,bottom: 0.00498506301081425d,left: 0.43512489662788423d),

new NpgsqlTypes.NpgsqlBox(top: 0.9120798189665378d,right: 0.9951022951429047d,bottom: 0.22538211792939344d,left: 0.7355670234981692d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39002578590552583d,right: 0.9303333007917512d,bottom: 0.32109007865282047d,left: 0.4806786778306078d),

new NpgsqlTypes.NpgsqlBox(top: 0.9151748723374997d,right: 0.8760499170708282d,bottom: 0.30216946537014167d,left: 0.6597405466425753d),

new NpgsqlTypes.NpgsqlBox(top: 0.8395130028625125d,right: 0.8080060747842941d,bottom: 0.1418215274371175d,left: 0.38168148067664076d),

new NpgsqlTypes.NpgsqlBox(top: 0.9245029336236116d,right: 0.670868147556385d,bottom: 0.5397958594742909d,left: 0.2650324342587742d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.35321642067588d,right: 0.7673549526105397d,bottom: 0.2545891525244651d,left: 0.23440511722431423d),

new NpgsqlTypes.NpgsqlBox(top: 0.7443667902381406d,right: 0.8576662581336708d,bottom: 0.09762779054654658d,left: 0.2432074512677913d),

new NpgsqlTypes.NpgsqlBox(top: 0.9651798689505137d,right: 0.5546259767625827d,bottom: 0.6588290467340385d,left: 0.46427109098032826d),

new NpgsqlTypes.NpgsqlBox(top: 0.42650885711993636d,right: 0.19869832507325946d,bottom: 0.3291143948487709d,left: 0.018374793667396916d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2297877782912633d,right: 0.316003347379994d,bottom: 0.037528749700465824d,left: 0.009873251581904108d),

new NpgsqlTypes.NpgsqlBox(top: 0.9367976602422307d,right: 0.8789898802791231d,bottom: 0.8128418349988128d,left: 0.7652743591024583d),

new NpgsqlTypes.NpgsqlBox(top: 0.36451109280454663d,right: 0.3387023630406629d,bottom: 0.11858506901401888d,left: 0.03953389915165628d),

new NpgsqlTypes.NpgsqlBox(top: 0.6313972867309939d,right: 0.6161810063963099d,bottom: 0.3086120913304258d,left: 0.26821884210432667d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3101426104035857d,right: 0.504197195399958d,bottom: 0.012215682618475276d,left: 0.15525753350936988d),

new NpgsqlTypes.NpgsqlBox(top: 0.36396806910421076d,right: 0.6861916019016177d,bottom: 0.3587335720476348d,left: 0.63573760658872d),

new NpgsqlTypes.NpgsqlBox(top: 0.4189135485217502d,right: 0.6763776448237571d,bottom: 0.3233835454754468d,left: 0.6470081996983457d),

new NpgsqlTypes.NpgsqlBox(top: 0.5034432411861994d,right: 0.5900020756796676d,bottom: 0.46496668578813094d,left: 0.39322535761486255d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9024410073793719d,right: 0.8011734724927183d,bottom: 0.37964272439443714d,left: 0.6723397702186102d),

new NpgsqlTypes.NpgsqlBox(top: 0.364034101218377d,right: 0.7676523065012893d,bottom: 0.2832296445401178d,left: 0.42556448882429376d),

new NpgsqlTypes.NpgsqlBox(top: 0.5597841110120072d,right: 0.3331294353990951d,bottom: 0.02275901146052195d,left: 0.1631136538997202d),

new NpgsqlTypes.NpgsqlBox(top: 0.941719451154962d,right: 0.57317345667663d,bottom: 0.8946082374073547d,left: 0.012794695207155704d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6429494364658771d,right: 0.3433144529149311d,bottom: 0.20892305557528323d,left: 0.32522392979163794d),

new NpgsqlTypes.NpgsqlBox(top: 0.8402037756236341d,right: 0.30962672217650755d,bottom: 0.2735858085948696d,left: 0.17610088291279535d),

new NpgsqlTypes.NpgsqlBox(top: 0.2609408097658308d,right: 0.3466357361100967d,bottom: 0.08220463814820989d,left: 0.03860714936897891d),

new NpgsqlTypes.NpgsqlBox(top: 0.6568021321197528d,right: 0.6026675215852397d,bottom: 0.2262659281575241d,left: 0.40481220239457716d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48964779292270033d,right: 0.47701456807987586d,bottom: 0.11984974222522049d,left: 0.3198477841789019d),

new NpgsqlTypes.NpgsqlBox(top: 0.37452322853606657d,right: 0.2537226697591505d,bottom: 0.1412756922896502d,left: 0.0034559535009093256d),

new NpgsqlTypes.NpgsqlBox(top: 0.2941534141530867d,right: 0.5372537570256867d,bottom: 0.27094111856582015d,left: 0.12616717696658486d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9251167328855845d,right: 0.9675448567950091d,bottom: 0.029550587008863705d,left: 0.7140777910241215d),

new NpgsqlTypes.NpgsqlBox(top: 0.14928570281439957d,right: 0.6415026076582232d,bottom: 0.05233783786192148d,left: 0.5108212515286581d),

new NpgsqlTypes.NpgsqlBox(top: 0.714919564624111d,right: 0.6179626674194618d,bottom: 0.5544305822662867d,left: 0.29582546254334796d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42756128552722883d,right: 0.8791916403046127d,bottom: 0.31519038008682965d,left: 0.5271537257587365d),

new NpgsqlTypes.NpgsqlBox(top: 0.5538846067240114d,right: 0.8197496764694415d,bottom: 0.2234898797044066d,left: 0.1276255937994636d),

new NpgsqlTypes.NpgsqlBox(top: 0.9621792294065531d,right: 0.32152200089027483d,bottom: 0.37855270301000965d,left: 0.30249266629654736d),

new NpgsqlTypes.NpgsqlBox(top: 0.6032713771582888d,right: 0.748713581425998d,bottom: 0.12525010640523404d,left: 0.6894744598497855d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6415129151800854d,right: 0.3221813627528961d,bottom: 0.32785368530863424d,left: 0.27239884681558035d),

new NpgsqlTypes.NpgsqlBox(top: 0.563604820674751d,right: 0.438056470914459d,bottom: 0.05099049964355462d,left: 0.2147668116639585d),

new NpgsqlTypes.NpgsqlBox(top: 0.4390331254287766d,right: 0.4543069678727626d,bottom: 0.38887557468878764d,left: 0.4490306149861022d),

new NpgsqlTypes.NpgsqlBox(top: 0.9645565610299726d,right: 0.3378612642941058d,bottom: 0.35667443839553525d,left: 0.25856899391980004d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.665146852463438d,right: 0.9067806329459429d,bottom: 0.23768700240719642d,left: 0.36777121819125747d),

new NpgsqlTypes.NpgsqlBox(top: 0.8096688009182398d,right: 0.832489460810459d,bottom: 0.2472298667374332d,left: 0.6369401965044815d),

new NpgsqlTypes.NpgsqlBox(top: 0.6386472664491692d,right: 0.5811377953920616d,bottom: 0.15093695674896512d,left: 0.4074709916899042d),

new NpgsqlTypes.NpgsqlBox(top: 0.873861547031704d,right: 0.9581409503155157d,bottom: 0.10876898431704307d,left: 0.5737250271015445d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6042005647713985d,right: 0.9988392100476587d,bottom: 0.5629180118312548d,left: 0.17917700780957124d),

new NpgsqlTypes.NpgsqlBox(top: 0.5015165098149816d,right: 0.2412682301317024d,bottom: 0.4039342585764968d,left: 0.0892023042277077d),

new NpgsqlTypes.NpgsqlBox(top: 0.4882518187625977d,right: 0.9546741712214885d,bottom: 0.020889378344111864d,left: 0.9028739556636549d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.45672053359623754d,right: 0.23193045266505852d,bottom: 0.1379916071510563d,left: 0.21354834735788797d),

new NpgsqlTypes.NpgsqlBox(top: 0.4255070876642185d,right: 0.6822891873926139d,bottom: 0.11053480196033061d,left: 0.3360223296051158d),

new NpgsqlTypes.NpgsqlBox(top: 0.32203615821634946d,right: 0.7649176581870981d,bottom: 0.22914695684257091d,left: 0.6646874511926274d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9834311809837224d,right: 0.4247836956575797d,bottom: 0.631555919740749d,left: 0.29290680323401597d),

new NpgsqlTypes.NpgsqlBox(top: 0.9352061863877366d,right: 0.9220354681742097d,bottom: 0.3218111685449203d,left: 0.22595732853608474d),

new NpgsqlTypes.NpgsqlBox(top: 0.8829775819146063d,right: 0.5699206285268652d,bottom: 0.012259906906440854d,left: 0.41652840930082d),

new NpgsqlTypes.NpgsqlBox(top: 0.7164142562734068d,right: 0.9045281499731544d,bottom: 0.34738736109185886d,left: 0.5258783116508505d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6779198254269437d,right: 0.8426808165228349d,bottom: 0.1894909292980539d,left: 0.840495252262851d),

new NpgsqlTypes.NpgsqlBox(top: 0.9275491849160565d,right: 0.9313074896015249d,bottom: 0.3386734380831131d,left: 0.27171674348944674d),

new NpgsqlTypes.NpgsqlBox(top: 0.8156020556195187d,right: 0.2586891292015957d,bottom: 0.43382225753149095d,left: 0.14552630478446626d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6856437607871455d,right: 0.9245818075162462d,bottom: 0.28721729887077585d,left: 0.1604836676336714d),

new NpgsqlTypes.NpgsqlBox(top: 0.554970732394804d,right: 0.6241744020632288d,bottom: 0.001102517348379295d,left: 0.009781675336195672d),

new NpgsqlTypes.NpgsqlBox(top: 0.9149462135912566d,right: 0.7238931038886269d,bottom: 0.6641131554248152d,left: 0.31089789086485276d),

new NpgsqlTypes.NpgsqlBox(top: 0.8708386130167514d,right: 0.03541564480776316d,bottom: 0.04523394325438679d,left: 0.00857968559335709d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8808556533915587d,right: 0.8386392109015304d,bottom: 0.3957519780705736d,left: 0.439177458227373d),

new NpgsqlTypes.NpgsqlBox(top: 0.8900648148650849d,right: 0.9593199364285054d,bottom: 0.09525526693075925d,left: 0.046540207132433786d),

new NpgsqlTypes.NpgsqlBox(top: 0.6829800932699547d,right: 0.7977387308674876d,bottom: 0.02834641553665207d,left: 0.46399174830709566d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.713576575068813d,right: 0.8828456505678113d,bottom: 0.6249092104493156d,left: 0.03961553180231536d),

new NpgsqlTypes.NpgsqlBox(top: 0.11703375255266968d,right: 0.8591278159347637d,bottom: 0.005472919904610518d,left: 0.3135862838146043d),

new NpgsqlTypes.NpgsqlBox(top: 0.30893018267873285d,right: 0.8983436968474883d,bottom: 0.25486410238510604d,left: 0.19443809220241182d),

new NpgsqlTypes.NpgsqlBox(top: 0.5673765407844834d,right: 0.7010194869110796d,bottom: 0.0035573183998948155d,left: 0.28212349265956405d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6715530026342733d,right: 0.3858480707426988d,bottom: 0.5002603196161043d,left: 0.2665100525227866d),

new NpgsqlTypes.NpgsqlBox(top: 0.2608950293154848d,right: 0.8414647566769137d,bottom: 0.14946188445775566d,left: 0.2077605601319228d),

new NpgsqlTypes.NpgsqlBox(top: 0.8780295370920047d,right: 0.8719339338521517d,bottom: 0.084693036672423d,left: 0.6863496584514553d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6918076567839123d,right: 0.7492813982582942d,bottom: 0.03301151641552702d,left: 0.05775904338732751d),

new NpgsqlTypes.NpgsqlBox(top: 0.6577108138975903d,right: 0.5138626177283819d,bottom: 0.1779196255298533d,left: 0.24521704999378824d),

new NpgsqlTypes.NpgsqlBox(top: 0.7577595493310209d,right: 0.919627996375985d,bottom: 0.033547928880815925d,left: 0.7861470437511329d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6616965684758084d,right: 0.7437087667918013d,bottom: 0.32660702004673514d,left: 0.45286576337086104d),

new NpgsqlTypes.NpgsqlBox(top: 0.48241278552278577d,right: 0.9307220358325428d,bottom: 0.1521107840147482d,left: 0.40537732593437314d),

new NpgsqlTypes.NpgsqlBox(top: 0.9348073195328245d,right: 0.605640813807617d,bottom: 0.8595601134074774d,left: 0.57448426908749d),

new NpgsqlTypes.NpgsqlBox(top: 0.36169311661240766d,right: 0.7250129155047549d,bottom: 0.10071240622756183d,left: 0.5979975663405732d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.18560912856872913d,right: 0.9906105063823664d,bottom: 0.11888398477156725d,left: 0.4728253310084155d),

new NpgsqlTypes.NpgsqlBox(top: 0.3859836692901245d,right: 0.4957119594098276d,bottom: 0.13417567318237744d,left: 0.054371831814379656d),

new NpgsqlTypes.NpgsqlBox(top: 0.8386420466466408d,right: 0.6024718690371664d,bottom: 0.38878052559708454d,left: 0.4542941199895314d),

new NpgsqlTypes.NpgsqlBox(top: 0.3830675229610654d,right: 0.9971468389761123d,bottom: 0.0550389548334278d,left: 0.28983431292428397d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5837493818569571d,right: 0.5850707358947361d,bottom: 0.20487797608567515d,left: 0.14165141305216167d),

new NpgsqlTypes.NpgsqlBox(top: 0.7343121286516403d,right: 0.5223308949231938d,bottom: 0.670651391469692d,left: 0.18798106409616244d),

new NpgsqlTypes.NpgsqlBox(top: 0.7883391716156308d,right: 0.7101447843760977d,bottom: 0.5367693720143547d,left: 0.5658935390315787d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7088033031880452d,right: 0.5295753029390703d,bottom: 0.5555906222397371d,left: 0.04667776734306006d),

new NpgsqlTypes.NpgsqlBox(top: 0.9615412941561616d,right: 0.9745488741891021d,bottom: 0.18436444741278712d,left: 0.6715609943181657d),

new NpgsqlTypes.NpgsqlBox(top: 0.7490858394108277d,right: 0.9785464003601017d,bottom: 0.07825174233011323d,left: 0.3432682076544644d),

},
    ModelInner = null,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 137, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
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
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 149, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 153, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 162, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[34], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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

