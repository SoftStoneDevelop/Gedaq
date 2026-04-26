

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9755527239569229d, y: 0.1999789159272355d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759590597008168d, y: 0.6519067302661985d), new NpgsqlTypes.NpgsqlPoint(x: 0.679620509898172d, y: 0.7896214956775847d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8357778571498856d, y: 0.12804262807691535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288444861504022d, y: 0.7047741800827211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281361503142945d, y: 0.9106280695377783d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33398429071086866d, y: 0.24098693108913738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871552143617451d, y: 0.33336576795396344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656796489868505d, y: 0.5904378843035609d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5036970954802846d, y: 0.28911412809080106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894835029398734d, y: 0.5833356020312832d), new NpgsqlTypes.NpgsqlPoint(x: 0.38917056210316125d, y: 0.11149963974050892d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3172460934906306d, y: 0.9321481561627968d), new NpgsqlTypes.NpgsqlPoint(x: 0.24575890407425938d, y: 0.12636151659127615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278304466502882d, y: 0.17293040803000237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5754301367595546d, y: 0.7854106998375657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855332505918095d, y: 0.6093290981977255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879341615274766d, y: 0.3834411559471933d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8464794986394009d, y: 0.8985429000571763d), new NpgsqlTypes.NpgsqlPoint(x: 0.13623117149005537d, y: 0.4689808418562107d), new NpgsqlTypes.NpgsqlPoint(x: 0.03712790653122089d, y: 0.6081946301801945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01192851786562521d, y: 0.10319475896722596d), new NpgsqlTypes.NpgsqlPoint(x: 0.49640124811806063d, y: 0.6074348949476687d), new NpgsqlTypes.NpgsqlPoint(x: 0.07860688704908836d, y: 0.9054689666843789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41660545836932883d, y: 0.8405481727878683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8305692866716241d, y: 0.35906989403841694d), new NpgsqlTypes.NpgsqlPoint(x: 0.566066013609722d, y: 0.11844305175746339d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5522692070981504d, y: 0.9625790529174119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668156173333805d, y: 0.6967907445023169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109000362187996d, y: 0.35331548476612484d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48195101027523457d, y: 0.7276399312299003d), new NpgsqlTypes.NpgsqlPoint(x: 0.003122416767650571d, y: 0.4591583403743055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8836467943467284d, y: 0.00320929785918711d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7152240268961916d, y: 0.40054081118865814d), new NpgsqlTypes.NpgsqlPoint(x: 0.03508853408963353d, y: 0.513964430572341d), new NpgsqlTypes.NpgsqlPoint(x: 0.456025358786743d, y: 0.1621338698901159d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14870534502172283d, y: 0.44875863107552505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9042846265363067d, y: 0.7056576212010449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318526834461387d, y: 0.8140878472194715d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2897518810195474d, y: 0.11491120777566477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749227653796346d, y: 0.7369077602309407d), new NpgsqlTypes.NpgsqlPoint(x: 0.30835440244657686d, y: 0.41271528120608514d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8392254471756386d, y: 0.058158604885059195d), new NpgsqlTypes.NpgsqlPoint(x: 0.20313143811107914d, y: 0.8173995299804151d), new NpgsqlTypes.NpgsqlPoint(x: 0.021071712616383298d, y: 0.8175781027449689d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7124498946998892d, y: 0.37639056403184123d), new NpgsqlTypes.NpgsqlPoint(x: 0.196655825649514d, y: 0.6202270837098458d), new NpgsqlTypes.NpgsqlPoint(x: 0.42411029723299687d, y: 0.4986405055826192d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.747510394635044d, y: 0.29928037080878644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278197320085146d, y: 0.8026741618797422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9662777374107617d, y: 0.16190777344505425d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35781677459365435d, y: 0.04785761465320748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586091181902608d, y: 0.8580735432244198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420329696190574d, y: 0.9280904750485187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0757597583807691d, y: 0.7264718569262208d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478544807995365d, y: 0.9280618226520491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8436625565343907d, y: 0.9341828645690442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5588054626253902d, y: 0.9263474130252771d), new NpgsqlTypes.NpgsqlPoint(x: 0.36154504483636696d, y: 0.3354974260632688d), new NpgsqlTypes.NpgsqlPoint(x: 0.16994921657577433d, y: 0.09654311853877029d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10195116802821602d, y: 0.442129713148534d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298721679166023d, y: 0.8057931526746215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1316545032048574d, y: 0.10100730023624072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6455605955939892d, y: 0.29311280900011194d), new NpgsqlTypes.NpgsqlPoint(x: 0.778598877792228d, y: 0.28734405426094833d), new NpgsqlTypes.NpgsqlPoint(x: 0.29878736303516096d, y: 0.22019208317757877d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9972815940670459d, y: 0.3928896893370315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3086101461601848d, y: 0.026714803495067274d), new NpgsqlTypes.NpgsqlPoint(x: 0.1124964337016422d, y: 0.6715050168776365d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0003170379163849324d, y: 0.45016825841821184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455844873819146d, y: 0.7511491978426963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208184420068163d, y: 0.1593905829006783d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4373089778322604d, y: 0.6828876782667846d), new NpgsqlTypes.NpgsqlPoint(x: 0.25600324025840904d, y: 0.027234122558689067d), new NpgsqlTypes.NpgsqlPoint(x: 0.3539906811197999d, y: 0.7219869021753225d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15145248418336998d, y: 0.3707517494699203d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632541175648335d, y: 0.6243798423808523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066072777428589d, y: 0.5798953820701721d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7718501802294635d, y: 0.022252333120604484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888275269467978d, y: 0.5804652059928488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047730596639495d, y: 0.7021339171234021d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05284451966987336d, y: 0.016124450969272508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201887208771339d, y: 0.08035617429208619d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444070671717108d, y: 0.21878713722166d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9271547699435493d, y: 0.05193510713673244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297963950083341d, y: 0.06416052806699657d), new NpgsqlTypes.NpgsqlPoint(x: 0.44206371769694963d, y: 0.45563617373242105d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5244177051512043d, y: 0.6215778151260698d), new NpgsqlTypes.NpgsqlPoint(x: 0.2927341711139063d, y: 0.9803404323916989d), new NpgsqlTypes.NpgsqlPoint(x: 0.854893490816311d, y: 0.747093691293621d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4348797146475797d, y: 0.14747151213080334d), new NpgsqlTypes.NpgsqlPoint(x: 0.759990689217068d, y: 0.2951669501157146d), new NpgsqlTypes.NpgsqlPoint(x: 0.46704662273333164d, y: 0.2521165405449569d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40907446425560856d, y: 0.23991450372086487d), new NpgsqlTypes.NpgsqlPoint(x: 0.1322512325623828d, y: 0.6823704799572144d), new NpgsqlTypes.NpgsqlPoint(x: 0.38539968765743204d, y: 0.3407115857907802d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5731337803952006d, y: 0.5971733857514241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092153684178064d, y: 0.8313023035001913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0665253682822814d, y: 0.9934291602773017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9817809610181846d, y: 0.151217574687306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046994681720799d, y: 0.875831873686316d), new NpgsqlTypes.NpgsqlPoint(x: 0.1560320952645703d, y: 0.01364217331355344d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8296219088350403d, y: 0.09028413936635915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957094228478977d, y: 0.5023200984424535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583302935274763d, y: 0.3756028210317325d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054640208948443014d, y: 0.7020487048717446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574484092208348d, y: 0.4499390816595078d), new NpgsqlTypes.NpgsqlPoint(x: 0.22509029922959756d, y: 0.9713570530896942d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9747233500886835d, y: 0.9857780450262104d), new NpgsqlTypes.NpgsqlPoint(x: 0.594870826875658d, y: 0.6169088029214285d), new NpgsqlTypes.NpgsqlPoint(x: 0.34470564499606915d, y: 0.1345857882909245d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9672582892375532d, y: 0.7374922028211337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891860625011779d, y: 0.7374747676396467d), new NpgsqlTypes.NpgsqlPoint(x: 0.3117002139533679d, y: 0.6857286460561226d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8403155359786234d, y: 0.05425339618032565d), new NpgsqlTypes.NpgsqlPoint(x: 0.30682527108529967d, y: 0.6851718448144529d), new NpgsqlTypes.NpgsqlPoint(x: 0.40649342592415616d, y: 0.8993136077080603d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43712120931759935d, y: 0.8627422678091713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603235915678018d, y: 0.3468144057975856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558636273380092d, y: 0.6848169497229201d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9913099740529692d, y: 0.08019238475100687d), new NpgsqlTypes.NpgsqlPoint(x: 0.75005302095792d, y: 0.026759398069872598d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776494365634174d, y: 0.8763481992001982d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1887670438779555d, y: 0.6104541665786347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314961391223633d, y: 0.9044665013775881d), new NpgsqlTypes.NpgsqlPoint(x: 0.11205941355382676d, y: 0.833782963931759d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3939942370080399d, y: 0.47263233516460623d), new NpgsqlTypes.NpgsqlPoint(x: 0.09005742377339632d, y: 0.5691588836932013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508967287105877d, y: 0.9482562444972356d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6096523024473423d, y: 0.3725661219232651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692401574509822d, y: 0.8752877346512565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825769894605779d, y: 0.20859184922347407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23762957834754228d, y: 0.7204222746607434d), new NpgsqlTypes.NpgsqlPoint(x: 0.22966815027301613d, y: 0.6646466107954311d), new NpgsqlTypes.NpgsqlPoint(x: 0.979344766654499d, y: 0.6419195817789799d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3470728896613545d, y: 0.10188629042989017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469683135664418d, y: 0.4131725095851587d), new NpgsqlTypes.NpgsqlPoint(x: 0.10079076322904446d, y: 0.2802277698910046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09343255732271116d, y: 0.842548979947346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413619579769174d, y: 0.636035066891024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102583913188883d, y: 0.7574352990866262d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14781459482264303d, y: 0.13099563257431857d), new NpgsqlTypes.NpgsqlPoint(x: 0.25593552948343834d, y: 0.567795163971303d), new NpgsqlTypes.NpgsqlPoint(x: 0.06958234785573114d, y: 0.6640221443723182d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7253555019212556d, y: 0.7437437666927706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660300976121724d, y: 0.6055338390124129d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394614727465069d, y: 0.4457919811001668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46431122151763404d, y: 0.687257666678021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516038577386763d, y: 0.37677709773208834d), new NpgsqlTypes.NpgsqlPoint(x: 0.19805797804337832d, y: 0.15721958825448656d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06883970626120783d, y: 0.8450051960820363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907568580009143d, y: 0.4762946351916374d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773420937098533d, y: 0.18552911625676172d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5507741134281952d, y: 0.9048943258933312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8795193854333513d, y: 0.5394651332543409d), new NpgsqlTypes.NpgsqlPoint(x: 0.38063014121434524d, y: 0.24764138702438798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6901425848382837d, y: 0.22841950456536186d), new NpgsqlTypes.NpgsqlPoint(x: 0.053796170138414534d, y: 0.027199461258053614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17590232830206987d, y: 0.35639985259502505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23038929867677338d, y: 0.4534766841451271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940342260340875d, y: 0.27714165738422214d), new NpgsqlTypes.NpgsqlPoint(x: 0.47478465183073426d, y: 0.4500801336421313d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5734165419238727d, y: 0.7233590898649054d), new NpgsqlTypes.NpgsqlPoint(x: 0.99869349939294d, y: 0.21460333720819935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252246328351449d, y: 0.860158355925332d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18680486133773966d, y: 0.2547217683985592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330616664462712d, y: 0.11364371075755642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9783906139233857d, y: 0.12051022234202968d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15327145529354835d, y: 0.5222500967384474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662849875891001d, y: 0.3784246851463049d), new NpgsqlTypes.NpgsqlPoint(x: 0.006829623875126534d, y: 0.14394024798849647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5456267571247606d, y: 0.6873233923952989d), new NpgsqlTypes.NpgsqlPoint(x: 0.23921643720327335d, y: 0.27166455193272676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6916547291371732d, y: 0.16637927951703813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9954228647573349d, y: 0.5469101765235846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138324064481875d, y: 0.043656027037334844d), new NpgsqlTypes.NpgsqlPoint(x: 0.09115149416673352d, y: 0.7068510611407113d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1520120003747898d, y: 0.6464167572544997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652393518194443d, y: 0.8098751459227375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208155448532134d, y: 0.9646478212570976d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6175046125997276d, y: 0.1984065304167284d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023357525794494016d, y: 0.3489842153263142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5337162757726321d, y: 0.6717994584190148d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18699654040210467d, y: 0.03343401936746093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431425323737963d, y: 0.6080019664624389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356964913068014d, y: 0.36192236704966674d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2899240164809441d, y: 0.5062383885697951d), new NpgsqlTypes.NpgsqlPoint(x: 0.10962208445256971d, y: 0.9719046346941298d), new NpgsqlTypes.NpgsqlPoint(x: 0.11071577091719875d, y: 0.48207444748007755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28356622532235054d, y: 0.4319400163916769d), new NpgsqlTypes.NpgsqlPoint(x: 0.1487988939580891d, y: 0.27268345490053847d), new NpgsqlTypes.NpgsqlPoint(x: 0.04655214808016628d, y: 0.9841603546629498d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6443090948509428d, y: 0.3492881681354443d), new NpgsqlTypes.NpgsqlPoint(x: 0.85055938740638d, y: 0.6402784749046302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714764982232355d, y: 0.9988530795878651d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8163944029385259d, y: 0.5333287163341233d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815448703858002d, y: 0.628341911099572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970067956488805d, y: 0.48538841736583793d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05168018852331335d, y: 0.750131314321935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928359491721677d, y: 0.43153168582695256d), new NpgsqlTypes.NpgsqlPoint(x: 0.2536451490692614d, y: 0.9111997509602126d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7892667114556584d, y: 0.14560239389630736d), new NpgsqlTypes.NpgsqlPoint(x: 0.17820131171683395d, y: 0.08711022130042567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317418243952196d, y: 0.7402678117541366d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2609494029519498d, y: 0.9566237876539779d), new NpgsqlTypes.NpgsqlPoint(x: 0.37447171290397374d, y: 0.8201636371166153d), new NpgsqlTypes.NpgsqlPoint(x: 0.04308579444587668d, y: 0.27562117588296686d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47798606866962734d, y: 0.11055700178869676d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619352022181924d, y: 0.819423140651888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8193470233863601d, y: 0.03002851640786286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4784363596925988d, y: 0.03886711506842555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443039086235797d, y: 0.671395278846577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042545699653472d, y: 0.6143895228171651d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5572478265689156d, y: 0.43901800300765403d), new NpgsqlTypes.NpgsqlPoint(x: 0.1761179554065011d, y: 0.8640178238125495d), new NpgsqlTypes.NpgsqlPoint(x: 0.580509796302721d, y: 0.3129446062009337d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22192826787536235d, y: 0.502243432651316d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978509377365505d, y: 0.7502892204118516d), new NpgsqlTypes.NpgsqlPoint(x: 0.35792010698743815d, y: 0.08983389252508422d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.564792231898681d, y: 0.03786243425093694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862938141802658d, y: 0.7812507685458863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3767122204462352d, y: 0.6031983200383991d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006941665235945194d, y: 0.04468258791110313d), new NpgsqlTypes.NpgsqlPoint(x: 0.2594456018327741d, y: 0.02863083161414548d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706530215111874d, y: 0.7827000465839014d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8232601772786733d, y: 0.18148056193209972d), new NpgsqlTypes.NpgsqlPoint(x: 0.47511716037895846d, y: 0.18851684300779348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444403869515182d, y: 0.06119589890926702d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7513788587271079d, y: 0.683639114813283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376524810055421d, y: 0.23992121645484898d), new NpgsqlTypes.NpgsqlPoint(x: 0.32822260576401086d, y: 0.7273211582834315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.818819140638317d, y: 0.822131550388457d), new NpgsqlTypes.NpgsqlPoint(x: 0.16825377717897194d, y: 0.2585600291502942d), new NpgsqlTypes.NpgsqlPoint(x: 0.0476178004538268d, y: 0.5393905350290777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24968209370156436d, y: 0.38370438417765085d), new NpgsqlTypes.NpgsqlPoint(x: 0.997548939466886d, y: 0.2813897936588672d), new NpgsqlTypes.NpgsqlPoint(x: 0.26929941728488616d, y: 0.5705505012371691d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9787378336124967d, y: 0.36167707640582203d), new NpgsqlTypes.NpgsqlPoint(x: 0.08469887943020626d, y: 0.4977826539154847d), new NpgsqlTypes.NpgsqlPoint(x: 0.19230449246280634d, y: 0.06755970056210536d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9876051142948037d, y: 0.27918997261754064d), new NpgsqlTypes.NpgsqlPoint(x: 0.15151401260863562d, y: 0.1694937708065365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890097196065281d, y: 0.864431004692122d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41428243867013403d, y: 0.8948569616328051d), new NpgsqlTypes.NpgsqlPoint(x: 0.44586384566533555d, y: 0.02202405292924603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922773614959584d, y: 0.8341084881124625d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.665704166080087d, y: 0.15452340699923717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314664986318634d, y: 0.9829103463618093d), new NpgsqlTypes.NpgsqlPoint(x: 0.28158030699151193d, y: 0.43928655708780184d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7665351172560934d, y: 0.7373963897508556d), new NpgsqlTypes.NpgsqlPoint(x: 0.35631420785121437d, y: 0.15211284551929727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5403119977113351d, y: 0.45668395914051674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9475191943405425d, y: 0.878453140860436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070039493042163d, y: 0.07787939752840745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868256639769864d, y: 0.4514845088891173d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7700270121883163d, y: 0.21353328791895576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9774424366722652d, y: 0.2026995455581272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8713793302301488d, y: 0.1877894864870624d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8835700146138428d, y: 0.2120108612899435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272293835590075d, y: 0.7552512790129066d), new NpgsqlTypes.NpgsqlPoint(x: 0.46884930455427853d, y: 0.2959656398168996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08898045937194565d, y: 0.999645555228498d), new NpgsqlTypes.NpgsqlPoint(x: 0.44503455344342047d, y: 0.34705009022265854d), new NpgsqlTypes.NpgsqlPoint(x: 0.582763334408001d, y: 0.9230692105512212d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33171182497725027d, y: 0.7387962530550267d), new NpgsqlTypes.NpgsqlPoint(x: 0.19903367011208928d, y: 0.48345986600005497d), new NpgsqlTypes.NpgsqlPoint(x: 0.08328030180030144d, y: 0.23243698454588224d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1298850007190362d, y: 0.9344272357249399d), new NpgsqlTypes.NpgsqlPoint(x: 0.41336784966247286d, y: 0.33740485904303086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709216069240644d, y: 0.7871029987644044d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12781053130117315d, y: 0.5210599224082402d), new NpgsqlTypes.NpgsqlPoint(x: 0.575807703721107d, y: 0.2679856851344562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576729381556062d, y: 0.21378202457529694d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7183258421235019d, y: 0.2296181344737922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748415036154626d, y: 0.9829408236374018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690826244571114d, y: 0.1903819221818165d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6220312981721261d, y: 0.8094150810775214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034039527904459d, y: 0.10737654322916113d), new NpgsqlTypes.NpgsqlPoint(x: 0.05668894969454785d, y: 0.7600651164874491d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35797165376799367d, y: 0.18565942967050808d), new NpgsqlTypes.NpgsqlPoint(x: 0.40530190002374256d, y: 0.7919437713955025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104124718337439d, y: 0.4513189039603088d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3803490041189038d, y: 0.8740560630369647d), new NpgsqlTypes.NpgsqlPoint(x: 0.10680923007532639d, y: 0.6965617291102466d), new NpgsqlTypes.NpgsqlPoint(x: 0.41271585343790607d, y: 0.9169622832494813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5977425391656367d, y: 0.6984219117394265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978537794723915d, y: 0.05189933911809874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156811423855257d, y: 0.8597169516117112d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02931545837581373d, y: 0.3531935309952504d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936923583412775d, y: 0.2268743017288718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4642478385369154d, y: 0.14487508773341473d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7372186122705104d, y: 0.8392167248214435d), new NpgsqlTypes.NpgsqlPoint(x: 0.06481088833296667d, y: 0.06005176790288669d), new NpgsqlTypes.NpgsqlPoint(x: 0.19073238029340822d, y: 0.3097662559000658d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0006573510546783456d, y: 0.9185557924373604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6490692974617707d, y: 0.3490077768661689d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464017234907679d, y: 0.8594478606629554d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3598891882662627d, y: 0.6373323691372145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059689442129853d, y: 0.12058372282579699d), new NpgsqlTypes.NpgsqlPoint(x: 0.20003093797092553d, y: 0.8509516164420747d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33666718188295686d, y: 0.5196790142805411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774602370802222d, y: 0.3584766660652917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110416556449454d, y: 0.26916463529216406d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10404184116431314d, y: 0.8628510514211657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584775177885641d, y: 0.6029394308924008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410651715083529d, y: 0.8300899421900552d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18229510764259094d, y: 0.4980175609679254d), new NpgsqlTypes.NpgsqlPoint(x: 0.02267193986271221d, y: 0.31476946115333326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193905810526357d, y: 0.15196620210334721d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6251117836592945d, y: 0.19730855081029397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849060399981758d, y: 0.847539980963522d), new NpgsqlTypes.NpgsqlPoint(x: 0.21511509368894932d, y: 0.7768548350947929d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6035554069215812d, y: 0.8597585768367347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768865861204293d, y: 0.3062873056403068d), new NpgsqlTypes.NpgsqlPoint(x: 0.29155207320418963d, y: 0.4917825132197421d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5774447834053923d, y: 0.489028703593273d), new NpgsqlTypes.NpgsqlPoint(x: 0.1091241097590302d, y: 0.9534783048602093d), new NpgsqlTypes.NpgsqlPoint(x: 0.20783084131243756d, y: 0.7744236825279665d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29591073606222495d, y: 0.05353506470326996d), new NpgsqlTypes.NpgsqlPoint(x: 0.45944044951807106d, y: 0.20634178799111014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927328648435393d, y: 0.1665952225584293d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16422010532297526d, y: 0.20931904510056776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122376919928318d, y: 0.37785021121441864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5333867674472564d, y: 0.5031617637143909d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4188404282240479d, y: 0.07531186203872631d), new NpgsqlTypes.NpgsqlPoint(x: 0.11141609867711288d, y: 0.08479188858494302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398389924927706d, y: 0.5245123777225056d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7073756950243703d, y: 0.5669733616251109d), new NpgsqlTypes.NpgsqlPoint(x: 0.006909333235004311d, y: 0.013834815606938777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750254138817198d, y: 0.4292307783525472d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07445128720838823d, y: 0.07663027389540622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279399147305278d, y: 0.9260562534034442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961930182296143d, y: 0.43079614230854246d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7230151037992995d, y: 0.9504844349984024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255858924226706d, y: 0.8812865756431992d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732915246638571d, y: 0.5349447497755291d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20908114909272468d, y: 0.20735217577615006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686825024244251d, y: 0.9227607182861137d), new NpgsqlTypes.NpgsqlPoint(x: 0.42079825904233636d, y: 0.5736905512188027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5733290909793085d, y: 0.38808070122908456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769959552146697d, y: 0.1899752945070956d), new NpgsqlTypes.NpgsqlPoint(x: 0.11149417639807624d, y: 0.1909167097076513d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210390648080846d, y: 0.45127097158407736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504203336657209d, y: 0.35949244045923423d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601982536707376d, y: 0.7356893510359397d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7915855743411578d, y: 0.016857794261991743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8195309317954154d, y: 0.5304601130367845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632096648673762d, y: 0.6736961523821682d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7799470045216614d, y: 0.43991392393064854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057227918991451d, y: 0.5782940774518448d), new NpgsqlTypes.NpgsqlPoint(x: 0.30476931126488294d, y: 0.08142225729485286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.571286033544368d, y: 0.7216787522318983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5395879368015357d, y: 0.7444508677746269d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570558731041902d, y: 0.4468581199304452d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16203089154301598d, y: 0.42365817003854167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117082430879808d, y: 0.04559090162635138d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966488855717695d, y: 0.6370576904858207d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3267926376621726d, y: 0.5955820602221422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240436445785136d, y: 0.474278745791181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575207850840139d, y: 0.7097974877105647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32248708529261816d, y: 0.10148209111924089d), new NpgsqlTypes.NpgsqlPoint(x: 0.26280525033323254d, y: 0.6900538801846664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7884769254248295d, y: 0.8292490969433388d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7176211199539851d, y: 0.555246650324185d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008156667410696983d, y: 0.1208911964123397d), new NpgsqlTypes.NpgsqlPoint(x: 0.93268352288302d, y: 0.3982351027290807d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8325958177897449d, y: 0.6751325072306082d), new NpgsqlTypes.NpgsqlPoint(x: 0.583382586388981d, y: 0.8671005824975524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178352133241109d, y: 0.019334895926269247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32466471849804446d, y: 0.9109082208656346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8146553780572257d, y: 0.10521563792853728d), new NpgsqlTypes.NpgsqlPoint(x: 0.27253239961776077d, y: 0.26229068951632606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1660181209894861d, y: 0.1479581503877646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350573216575299d, y: 0.046393336888811754d), new NpgsqlTypes.NpgsqlPoint(x: 0.44122583154892714d, y: 0.4286526880408431d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6311427809166299d, y: 0.4476881102273307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4436060851804774d, y: 0.729826888068743d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254069160653672d, y: 0.30645968568717663d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05238074723083952d, y: 0.3606725717204009d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082186780305039d, y: 0.06674305623656429d), new NpgsqlTypes.NpgsqlPoint(x: 0.11137723786885789d, y: 0.8240855346603192d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26967909225870357d, y: 0.4893982381990887d), new NpgsqlTypes.NpgsqlPoint(x: 0.13820930555513233d, y: 0.8223314436796637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035963742453943d, y: 0.10824182358511947d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9219711397957719d, y: 0.033701941754693765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566346389007371d, y: 0.7831084633072952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539552912062405d, y: 0.4423113084675946d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8317927548881183d, y: 0.8038468747984239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6842987602761292d, y: 0.11720685190805258d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039932168003111d, y: 0.4800728457007791d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7547626436749645d, y: 0.29628728321426767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9373213985644085d, y: 0.3430352171812603d), new NpgsqlTypes.NpgsqlPoint(x: 0.49714493622210665d, y: 0.4971057017833229d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3285268346944199d, y: 0.727883640301804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045034727206903d, y: 0.9133681801982492d), new NpgsqlTypes.NpgsqlPoint(x: 0.28241270840568766d, y: 0.44240709127065825d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8048521888372585d, y: 0.4040435177459266d), new NpgsqlTypes.NpgsqlPoint(x: 0.19454265196576348d, y: 0.17343063742210063d), new NpgsqlTypes.NpgsqlPoint(x: 0.28609748787098876d, y: 0.7890357812490343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16659967384587704d, y: 0.7788979937290355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309955532059627d, y: 0.26974480207039264d), new NpgsqlTypes.NpgsqlPoint(x: 0.05920226612985924d, y: 0.14612030585122915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015005231542409625d, y: 0.4557496321530822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172821000850591d, y: 0.05401014360619283d), new NpgsqlTypes.NpgsqlPoint(x: 0.45021496261101246d, y: 0.04947627697472101d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46933123195073123d, y: 0.5516211056373007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025491274468699d, y: 0.07531617108272415d), new NpgsqlTypes.NpgsqlPoint(x: 0.48254927866434894d, y: 0.38066647406451837d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39421794716847747d, y: 0.35487071625241295d), new NpgsqlTypes.NpgsqlPoint(x: 0.718934894100141d, y: 0.423226405622681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7669414575501998d, y: 0.14777233715886207d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5549659358522955d, y: 0.17755542444907157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279627643680057d, y: 0.09650250303099106d), new NpgsqlTypes.NpgsqlPoint(x: 0.1062931635135056d, y: 0.3925537986638067d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8891060548440075d, y: 0.7461321503852401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929397536108323d, y: 0.2147668222555611d), new NpgsqlTypes.NpgsqlPoint(x: 0.10157534995954154d, y: 0.8063583699160809d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26186789091987095d, y: 0.33653269526624696d), new NpgsqlTypes.NpgsqlPoint(x: 0.634938592443739d, y: 0.2664271348569075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687612207924539d, y: 0.6277127702312714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.432683965079254d, y: 0.838414338414119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539799405254094d, y: 0.9808709364769628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919734898532119d, y: 0.854360574445355d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9890706260035147d, y: 0.8430891930168002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499391359048011d, y: 0.0488005673429841d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915745901983282d, y: 0.6933594073245852d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6465868439430752d, y: 0.28463657220460237d), new NpgsqlTypes.NpgsqlPoint(x: 0.18141647016969553d, y: 0.399018119595691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973942493163248d, y: 0.18086137093619703d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36891189373478495d, y: 0.6432000703331036d), new NpgsqlTypes.NpgsqlPoint(x: 0.04892282034755702d, y: 0.17253814175243087d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756308495418148d, y: 0.6933715835949112d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5867570172767106d, y: 0.42626134797653825d), new NpgsqlTypes.NpgsqlPoint(x: 0.11195546478887697d, y: 0.6292097953258157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023421700733589d, y: 0.6218052497586145d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3265695762659109d, y: 0.5269583191021192d), new NpgsqlTypes.NpgsqlPoint(x: 0.16915537128441382d, y: 0.4508922322323532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585918614842452d, y: 0.8877593909444511d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6793567422934453d, y: 0.3558380802815053d), new NpgsqlTypes.NpgsqlPoint(x: 0.18208505155072252d, y: 0.9547912247182464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566430182324482d, y: 0.8019375975883237d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.363086087439371d, y: 0.48067016744097724d), new NpgsqlTypes.NpgsqlPoint(x: 0.18379575517707447d, y: 0.5246951853281531d), new NpgsqlTypes.NpgsqlPoint(x: 0.45371766369713684d, y: 0.34644093249664987d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29289513694895963d, y: 0.45316547126995643d), new NpgsqlTypes.NpgsqlPoint(x: 0.228364855238969d, y: 0.09357289295989235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613156499577761d, y: 0.28893097054276473d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11923295713583149d, y: 0.31055421955061313d), new NpgsqlTypes.NpgsqlPoint(x: 0.42762523142982745d, y: 0.689393964214582d), new NpgsqlTypes.NpgsqlPoint(x: 0.13125228670567135d, y: 0.34781532118430025d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5497863125208288d, y: 0.6818600715852758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9041692939282834d, y: 0.07052144045132602d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001567172253403d, y: 0.9525944328921802d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07673347194571067d, y: 0.24906220224454223d), new NpgsqlTypes.NpgsqlPoint(x: 0.05336805147731272d, y: 0.38121943014853654d), new NpgsqlTypes.NpgsqlPoint(x: 0.1639019552873472d, y: 0.8074947204379211d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33806561983719596d, y: 0.8549804894911045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061312786470886d, y: 0.13344675369469428d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867807288481302d, y: 0.07159359996269055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.026545456567039216d, y: 0.4221409403059404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844207604767642d, y: 0.26649327203494655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4230494738647379d, y: 0.09522861220681378d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9652225833004742d, y: 0.7914515593413305d), new NpgsqlTypes.NpgsqlPoint(x: 0.12115458884528174d, y: 0.22011388326167047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159479967388753d, y: 0.46330097934606695d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6401183609191842d, y: 0.07884705734772834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098909027966186d, y: 0.013365467717255441d), new NpgsqlTypes.NpgsqlPoint(x: 0.02513361992905605d, y: 0.38827326162631626d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06906036351665323d, y: 0.5634971533413685d), new NpgsqlTypes.NpgsqlPoint(x: 0.03103298043041114d, y: 0.5781089064676942d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008962388769826468d, y: 0.10484771548815641d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16651840969938558d, y: 0.7346015040788317d), new NpgsqlTypes.NpgsqlPoint(x: 0.12198627635030868d, y: 0.14424084539270254d), new NpgsqlTypes.NpgsqlPoint(x: 0.4492630026490534d, y: 0.7736489338433252d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.864845756323434d, y: 0.8499230590823584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770262002700898d, y: 0.9483465659119606d), new NpgsqlTypes.NpgsqlPoint(x: 0.41795486118238256d, y: 0.7926035099001812d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2002264633627061d, y: 0.5861197068212368d), new NpgsqlTypes.NpgsqlPoint(x: 0.36652041795221924d, y: 0.6592162131221195d), new NpgsqlTypes.NpgsqlPoint(x: 0.1479546914982085d, y: 0.5346874788050575d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.972090992629767d, y: 0.27307711097730514d), new NpgsqlTypes.NpgsqlPoint(x: 0.982800762025782d, y: 0.4166169603218367d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152699525032746d, y: 0.2087683301386286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06884567344169801d, y: 0.7960814416545846d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587283985492699d, y: 0.6806905905007232d), new NpgsqlTypes.NpgsqlPoint(x: 0.502981243718493d, y: 0.31104980399816984d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34449142074364936d, y: 0.08193394577169488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991009021590313d, y: 0.513225115681633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176291105512597d, y: 0.7568638998733531d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5702588553152995d, y: 0.015596704414482576d), new NpgsqlTypes.NpgsqlPoint(x: 0.006537835201930964d, y: 0.5875635880709816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246973875916415d, y: 0.2095202807232981d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14077675130545675d, y: 0.5053481599899866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171648565186289d, y: 0.1163089557262974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036259289694704d, y: 0.5925623609033885d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3767095469533044d, y: 0.7912812653057172d), new NpgsqlTypes.NpgsqlPoint(x: 0.94185745703809d, y: 0.9215817301673369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229354028042817d, y: 0.8457127847254176d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9222542508400666d, y: 0.7696547012167898d), new NpgsqlTypes.NpgsqlPoint(x: 0.10337335408195525d, y: 0.37644865249749093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429894424859401d, y: 0.247607133310926d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8894417340020822d, y: 0.3353401630007804d), new NpgsqlTypes.NpgsqlPoint(x: 0.660122440969196d, y: 0.791054157743626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566672511766008d, y: 0.9501569824172343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5051825295541406d, y: 0.9896546768287036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775730354542196d, y: 0.003154773665883681d), new NpgsqlTypes.NpgsqlPoint(x: 0.934798927087127d, y: 0.6634778469558227d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7128620788004391d, y: 0.5492068737655854d), new NpgsqlTypes.NpgsqlPoint(x: 0.09342732853507718d, y: 0.13230849452167726d), new NpgsqlTypes.NpgsqlPoint(x: 0.398476391412542d, y: 0.23404497144513114d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9435854296079758d, y: 0.981897524606401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931001122546094d, y: 0.7108511879680144d), new NpgsqlTypes.NpgsqlPoint(x: 0.819417393506934d, y: 0.2715480180700728d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03487723409465315d, y: 0.9285970290553974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6122574679088493d, y: 0.5012684774973194d), new NpgsqlTypes.NpgsqlPoint(x: 0.1188838981520205d, y: 0.1337144815900052d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3951985863357351d, y: 0.4666613584881407d), new NpgsqlTypes.NpgsqlPoint(x: 0.17461428623245367d, y: 0.2699921194056599d), new NpgsqlTypes.NpgsqlPoint(x: 0.15862306582421504d, y: 0.7143471912205442d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4510222061747664d, y: 0.18191958199602165d), new NpgsqlTypes.NpgsqlPoint(x: 0.016284913134428702d, y: 0.19149102496325543d), new NpgsqlTypes.NpgsqlPoint(x: 0.663825970696652d, y: 0.6572300470555944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9349401918697523d, y: 0.062293924992768535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7462001102839316d, y: 0.7691575609931389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384188753319733d, y: 0.5645848013338555d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4291631136890277d, y: 0.7080348923666697d), new NpgsqlTypes.NpgsqlPoint(x: 0.08444869840243252d, y: 0.7111475715929273d), new NpgsqlTypes.NpgsqlPoint(x: 0.15870831048540845d, y: 0.021177561419376656d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.746712921388985d, y: 0.35783867539585834d), new NpgsqlTypes.NpgsqlPoint(x: 0.12829927157287146d, y: 0.9733138574822404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046549453043741d, y: 0.340668398953472d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3405222425812823d, y: 0.9158459357045519d), new NpgsqlTypes.NpgsqlPoint(x: 0.37644655706710073d, y: 0.038612291001937415d), new NpgsqlTypes.NpgsqlPoint(x: 0.637923272247973d, y: 0.7749980332481775d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4767193452144679d, y: 0.8137930365447751d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343652420628259d, y: 0.8946931809980553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4883430037710901d, y: 0.5520331576934363d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.488425062455383d, y: 0.815014553286726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502792535584488d, y: 0.8989501975501728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464572497922039d, y: 0.31846564699136537d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6822264965577356d, y: 0.5135231802939744d), new NpgsqlTypes.NpgsqlPoint(x: 0.03409574876626065d, y: 0.9720215627058788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225493081468046d, y: 0.27621226775641483d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005138943925926731d, y: 0.8783726407342032d), new NpgsqlTypes.NpgsqlPoint(x: 0.03537542718222608d, y: 0.34000628085459506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021958060649259d, y: 0.06649074020032342d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3855184338088913d, y: 0.6330953285432283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3818632778230657d, y: 0.9123899432284084d), new NpgsqlTypes.NpgsqlPoint(x: 0.23496836704110646d, y: 0.36713743497143525d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22237421920368394d, y: 0.4414693070178164d), new NpgsqlTypes.NpgsqlPoint(x: 0.4188409487241723d, y: 0.5895975727933741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4166076973155819d, y: 0.833962504297199d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8693695054410138d, y: 0.04434079815619385d), new NpgsqlTypes.NpgsqlPoint(x: 0.27590008280966416d, y: 0.007917687495374692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346356261708384d, y: 0.32373868637243974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23227794603187402d, y: 0.04430735348089754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8136675088053038d, y: 0.6949374497441345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768291127599243d, y: 0.12751100964129525d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2463987232212289d, y: 0.23831985718607573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645780178766961d, y: 0.6543375467131468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425143037463204d, y: 0.2986358552964796d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03537544419418448d, y: 0.44807008978848417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438883760837424d, y: 0.4397486086282716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030596250941061d, y: 0.32446814287203396d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8071530643075006d, y: 0.5656123865843624d), new NpgsqlTypes.NpgsqlPoint(x: 0.05901768545054309d, y: 0.18139989222933173d), new NpgsqlTypes.NpgsqlPoint(x: 0.07780160985128848d, y: 0.44601525651779017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7465289818563356d, y: 0.2905126728341687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781979312256802d, y: 0.4262431731008244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697720676902356d, y: 0.9237753188059751d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41931506825863796d, y: 0.5508377603140248d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389723559995918d, y: 0.20340373209685614d), new NpgsqlTypes.NpgsqlPoint(x: 0.10514788031935807d, y: 0.9026796535262137d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8686965964698481d, y: 0.8786262723166441d), new NpgsqlTypes.NpgsqlPoint(x: 0.40504064543235363d, y: 0.23970849257119786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057838228768354d, y: 0.7254683757596642d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7119423901866864d, y: 0.7628476066229972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985440516838638d, y: 0.15214087715545543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664685154436277d, y: 0.30633395143195585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42366701554915664d, y: 0.48280321774400237d), new NpgsqlTypes.NpgsqlPoint(x: 0.96236047509411d, y: 0.8199914033508172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5448855572064033d, y: 0.29943811106209295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8258185998054982d, y: 0.03620250071928466d), new NpgsqlTypes.NpgsqlPoint(x: 0.2435332142479385d, y: 0.6999155050469081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656955532814938d, y: 0.30892530855395484d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7588681168872674d, y: 0.46474324060419014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608569715377805d, y: 0.7808230943736657d), new NpgsqlTypes.NpgsqlPoint(x: 0.11460868138868818d, y: 0.9187230743592947d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7123949723683907d, y: 0.38582095429820773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005703371855089d, y: 0.8082796304987141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9143778257858284d, y: 0.09203844904363734d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.603404459920858d, y: 0.6060444195375265d), new NpgsqlTypes.NpgsqlPoint(x: 0.676436830851334d, y: 0.06249387844015186d), new NpgsqlTypes.NpgsqlPoint(x: 0.38962540830962045d, y: 0.47255246718579313d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08048085233553193d, y: 0.27381805363914213d), new NpgsqlTypes.NpgsqlPoint(x: 0.10301072940785316d, y: 0.8872165579878768d), new NpgsqlTypes.NpgsqlPoint(x: 0.08255482697203043d, y: 0.11128850181928163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8587989012355486d, y: 0.04645375970080656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183140036899331d, y: 0.8885968986007814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032223496076051d, y: 0.1294673712276131d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6807208624801195d, y: 0.14679494698726958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485043325630546d, y: 0.8168199947026488d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333917991038613d, y: 0.9497233874218705d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06875247965023856d, y: 0.9470801401967811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9271400619768104d, y: 0.5420485126724799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525068515803692d, y: 0.6372636056618175d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32214134292113306d, y: 0.7988324138923195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616382955277251d, y: 0.5300421758640212d), new NpgsqlTypes.NpgsqlPoint(x: 0.798725008250825d, y: 0.5162629468049437d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4546814478277702d, y: 0.2896914487649874d), new NpgsqlTypes.NpgsqlPoint(x: 0.36722570547461253d, y: 0.34757106999599996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6001807636113756d, y: 0.029391516794433414d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09214503364385274d, y: 0.1286261869697164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367781359475741d, y: 0.4673299115390651d), new NpgsqlTypes.NpgsqlPoint(x: 0.2705457354902212d, y: 0.9631936873711947d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9010015875478896d, y: 0.08486018422088704d), new NpgsqlTypes.NpgsqlPoint(x: 0.06410426659772084d, y: 0.14704833367153558d), new NpgsqlTypes.NpgsqlPoint(x: 0.2608123193497277d, y: 0.43704556130229844d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5367976388935515d, y: 0.8515858182516867d), new NpgsqlTypes.NpgsqlPoint(x: 0.444122951489491d, y: 0.3004273997332896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627794706251172d, y: 0.35243676730916185d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3528332957203312d, y: 0.9033391416641988d), new NpgsqlTypes.NpgsqlPoint(x: 0.21015768012108338d, y: 0.1294471822439739d), new NpgsqlTypes.NpgsqlPoint(x: 0.25123763355702255d, y: 0.49577927010491596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7849713586189658d, y: 0.36361671906336723d), new NpgsqlTypes.NpgsqlPoint(x: 0.19943466038327695d, y: 0.7401789266497429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841078005529033d, y: 0.8779047003925667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17362731134739207d, y: 0.7997713468393728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607816670761182d, y: 0.3579562791652654d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928659790645268d, y: 0.36373629224827286d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6918138329871525d, y: 0.0765505658762955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158153609212663d, y: 0.8276261911251499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350969794249495d, y: 0.6895633968822859d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7160996148547091d, y: 0.003706492358796276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332136189636721d, y: 0.11593732565462112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134489224338376d, y: 0.8238760129601138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8150986041362709d, y: 0.24838573951366338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3107562457098928d, y: 0.9438229963956266d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782541699956344d, y: 0.7079639721113018d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2131210806853827d, y: 0.6738491196519575d), new NpgsqlTypes.NpgsqlPoint(x: 0.1378078590958638d, y: 0.27387394904837215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9317517448453388d, y: 0.875727333650225d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07913405223169523d, y: 0.5425585589913915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494918253695003d, y: 0.34432379882965525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7902321402903081d, y: 0.9952003337138264d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17512294624247404d, y: 0.6885727384609637d), new NpgsqlTypes.NpgsqlPoint(x: 0.2573827076223435d, y: 0.589450623677364d), new NpgsqlTypes.NpgsqlPoint(x: 0.48429472081763425d, y: 0.5560503286520774d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7730361004595203d, y: 0.8835433888258418d), new NpgsqlTypes.NpgsqlPoint(x: 0.45396565818550727d, y: 0.4069946392253576d), new NpgsqlTypes.NpgsqlPoint(x: 0.586583681147101d, y: 0.03937088233124009d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1624541373302888d, y: 0.9274323118708678d), new NpgsqlTypes.NpgsqlPoint(x: 0.438196781065327d, y: 0.31815399754518714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680776938928485d, y: 0.051193792528767657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20236262835949126d, y: 0.07610108065061627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847034429418352d, y: 0.8668301734955427d), new NpgsqlTypes.NpgsqlPoint(x: 0.10696427436619371d, y: 0.15499027020807266d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5507741134281952d, y: 0.9048943258933312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8795193854333513d, y: 0.5394651332543409d), new NpgsqlTypes.NpgsqlPoint(x: 0.38063014121434524d, y: 0.24764138702438798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6901425848382837d, y: 0.22841950456536186d), new NpgsqlTypes.NpgsqlPoint(x: 0.053796170138414534d, y: 0.027199461258053614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17590232830206987d, y: 0.35639985259502505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23038929867677338d, y: 0.4534766841451271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940342260340875d, y: 0.27714165738422214d), new NpgsqlTypes.NpgsqlPoint(x: 0.47478465183073426d, y: 0.4500801336421313d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5734165419238727d, y: 0.7233590898649054d), new NpgsqlTypes.NpgsqlPoint(x: 0.99869349939294d, y: 0.21460333720819935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252246328351449d, y: 0.860158355925332d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[29], false);
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

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 79, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);
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
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatch(connection, 125, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

