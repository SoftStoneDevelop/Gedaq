

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD2
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD2 : INpgsqlBoxMArrayboxMMArrayD2
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD2E1M[] _testData = new NpgsqlBoxboxMMArrayD2E1M[]
        {
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8752015120290523d,right: 0.9588069360122333d,bottom: 0.5419032870031831d,left: 0.9331492476947223d), new NpgsqlTypes.NpgsqlBox(top: 0.32714943134383856d,right: 0.6150421120975568d,bottom: 0.10200834008211856d,left: 0.35180933816258675d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7935829737888414d,right: 0.6768145500142548d,bottom: 0.588349678393532d,left: 0.2989177905749256d), new NpgsqlTypes.NpgsqlBox(top: 0.6336173988133359d,right: 0.6827445109381522d,bottom: 0.10284320015617843d,left: 0.2809714060744466d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3776485357165589d,right: 0.9313840539203866d,bottom: 0.3307950087309447d,left: 0.668621647647764d), new NpgsqlTypes.NpgsqlBox(top: 0.38396368766927846d,right: 0.49382022911794354d,bottom: 0.22876587946517113d,left: 0.26686784348155523d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3136620010881527d,right: 0.4720645705482518d,bottom: 0.249154400469345d,left: 0.15019757151510837d), new NpgsqlTypes.NpgsqlBox(top: 0.8056978695454405d,right: 0.7594794173254812d,bottom: 0.004451834499558549d,left: 0.4897959178091832d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4879599248152352d,right: 0.8014531466003835d,bottom: 0.21972339843702293d,left: 0.10978012635704781d), new NpgsqlTypes.NpgsqlBox(top: 0.2916590306326038d,right: 0.8577743722795675d,bottom: 0.22339576919738202d,left: 0.45425732533513674d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6682233769831784d,right: 0.6204161035611947d,bottom: 0.026728601547488684d,left: 0.47931587163612077d), new NpgsqlTypes.NpgsqlBox(top: 0.9749130685980584d,right: 0.9120001863899408d,bottom: 0.3127200065283776d,left: 0.03390322757058695d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9620284671134292d,right: 0.8034069564089521d,bottom: 0.31321823007145866d,left: 0.30078966268428475d), new NpgsqlTypes.NpgsqlBox(top: 0.19582383689709626d,right: 0.7765789408316086d,bottom: 0.024814545298925017d,left: 0.6472748946242174d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4300771905849735d,right: 0.6442377908487261d,bottom: 0.19103031745975774d,left: 0.5039224944299212d), new NpgsqlTypes.NpgsqlBox(top: 0.9551830636165659d,right: 0.2699948746186728d,bottom: 0.4042112209561032d,left: 0.11981725019867684d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9069042114983735d,right: 0.5913046898208358d,bottom: 0.3912121165105571d,left: 0.4580206426879412d), new NpgsqlTypes.NpgsqlBox(top: 0.8965982286592723d,right: 0.6389692120293853d,bottom: 0.6651495921795516d,left: 0.11062677639068985d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7818402403530332d,right: 0.4349201589018391d,bottom: 0.3449710731245743d,left: 0.029395100424055354d), new NpgsqlTypes.NpgsqlBox(top: 0.9574192430207947d,right: 0.9336894401686461d,bottom: 0.0028188040853103224d,left: 0.3961037381169632d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3672376575747711d,right: 0.0856199655878912d,bottom: 0.11488260480392665d,left: 0.06336004688494201d), new NpgsqlTypes.NpgsqlBox(top: 0.8024397187840717d,right: 0.7587282057054114d,bottom: 0.6039891436195939d,left: 0.6028629096183166d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9534249444575703d,right: 0.42078108234417155d,bottom: 0.7187748859253864d,left: 0.19623378348468534d), new NpgsqlTypes.NpgsqlBox(top: 0.8928563948062778d,right: 0.2755505673181521d,bottom: 0.7112172100096484d,left: 0.1954305130535079d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6602899403617674d,right: 0.6371252542058243d,bottom: 0.11731557103571866d,left: 0.22178093438572477d), new NpgsqlTypes.NpgsqlBox(top: 0.6890481534216063d,right: 0.6682304691508955d,bottom: 0.5594070501346224d,left: 0.2086222173893526d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8715124192880821d,right: 0.42061430564925506d,bottom: 0.37750663879357527d,left: 0.3922311705931475d), new NpgsqlTypes.NpgsqlBox(top: 0.5512934337520038d,right: 0.3712949645248259d,bottom: 0.37183199065746164d,left: 0.23506952266642733d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6913169948591411d,right: 0.32132671153792447d,bottom: 0.16510949443961742d,left: 0.2164166123436566d), new NpgsqlTypes.NpgsqlBox(top: 0.7887265305562822d,right: 0.93246026467976d,bottom: 0.35673777965643083d,left: 0.427842979215904d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7081006116455016d,right: 0.9042743710058041d,bottom: 0.24065358469621045d,left: 0.7526197474483036d), new NpgsqlTypes.NpgsqlBox(top: 0.9741725872614366d,right: 0.5299060476125681d,bottom: 0.6563263629907057d,left: 0.05498352707497889d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6175348082696022d,right: 0.9106863713326129d,bottom: 0.5507879408516837d,left: 0.7809945890906508d), new NpgsqlTypes.NpgsqlBox(top: 0.24214642541713505d,right: 0.9842125342025568d,bottom: 0.1639875564065002d,left: 0.4191243500170744d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4227665535090067d,right: 0.5707143560905783d,bottom: 0.043804989659514404d,left: 0.330880203269711d), new NpgsqlTypes.NpgsqlBox(top: 0.8312950604379247d,right: 0.7530607612060773d,bottom: 0.6419670539181398d,left: 0.3845975237769407d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.30409743052546045d,right: 0.6549993224600194d,bottom: 0.2948793028296819d,left: 0.12534221164546733d), new NpgsqlTypes.NpgsqlBox(top: 0.5012878664136068d,right: 0.7290688075344892d,bottom: 0.39512386402935884d,left: 0.28381577252039003d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.757166941586321d,right: 0.7419273689280309d,bottom: 0.2895345392084948d,left: 0.21258330592315489d), new NpgsqlTypes.NpgsqlBox(top: 0.7362560996827778d,right: 0.8711444953578499d,bottom: 0.31448607821947683d,left: 0.3071164497348192d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9657857948511854d,right: 0.8491941707821345d,bottom: 0.22532324020091687d,left: 0.6414801944037729d), new NpgsqlTypes.NpgsqlBox(top: 0.8166407041824898d,right: 0.6162181121356493d,bottom: 0.303126116322054d,left: 0.006399799184898858d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8787739594148573d,right: 0.5992136631161271d,bottom: 0.1443208910922842d,left: 0.32204945449750766d), new NpgsqlTypes.NpgsqlBox(top: 0.6852641677284188d,right: 0.3887899904436709d,bottom: 0.35516331769789067d,left: 0.2873031479342584d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7232449939035532d,right: 0.7350882656445505d,bottom: 0.1847535619133429d,left: 0.5287537442856103d), new NpgsqlTypes.NpgsqlBox(top: 0.7280213620321326d,right: 0.8675675316788078d,bottom: 0.36809826161558423d,left: 0.3285559905264619d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8883316515667009d,right: 0.9218036848496141d,bottom: 0.06254952071829067d,left: 0.038311132808665604d), new NpgsqlTypes.NpgsqlBox(top: 0.5741739940503106d,right: 0.5068575287687287d,bottom: 0.01290846418723346d,left: 0.02612146180511432d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3820321875539422d,right: 0.5065196768280522d,bottom: 0.16192199922725203d,left: 0.07004913332375007d), new NpgsqlTypes.NpgsqlBox(top: 0.8287766772038255d,right: 0.680631435774831d,bottom: 0.59422162617865d,left: 0.13538188832635323d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9405838947441885d,right: 0.6238657027070861d,bottom: 0.05579188662448076d,left: 0.3094898855806172d), new NpgsqlTypes.NpgsqlBox(top: 0.6780996406616641d,right: 0.9459921362631732d,bottom: 0.6007448250273199d,left: 0.3778564724205591d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3905890712354858d,right: 0.5741117787505675d,bottom: 0.1857347586127469d,left: 0.14905900814808293d), new NpgsqlTypes.NpgsqlBox(top: 0.7306574811978885d,right: 0.7782158384186871d,bottom: 0.5342256648466667d,left: 0.7622328538458979d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5958882577448977d,right: 0.6734924713168402d,bottom: 0.2283927618045466d,left: 0.22650098194414758d), new NpgsqlTypes.NpgsqlBox(top: 0.40020712958966886d,right: 0.8473342706564121d,bottom: 0.3663988025753566d,left: 0.46889737286528066d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5869578395142482d,right: 0.9322632134031911d,bottom: 0.09890878323053465d,left: 0.679727575956133d), new NpgsqlTypes.NpgsqlBox(top: 0.5718318166094885d,right: 0.17298344695905088d,bottom: 0.30000949028466806d,left: 0.1663518544043856d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8123368246474365d,right: 0.5289583403009699d,bottom: 0.584096864861328d,left: 0.43071429793965854d), new NpgsqlTypes.NpgsqlBox(top: 0.588170680284022d,right: 0.3867328125748062d,bottom: 0.159098756701898d,left: 0.3220124684366318d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7609208104841872d,right: 0.3959272039775864d,bottom: 0.14331343477342173d,left: 0.16636128377401782d), new NpgsqlTypes.NpgsqlBox(top: 0.7821757681664586d,right: 0.29004575240471175d,bottom: 0.42122958356885165d,left: 0.15910172277350454d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.43752602487013004d,right: 0.5425654522180922d,bottom: 0.09173642519492764d,left: 0.18997981775770278d), new NpgsqlTypes.NpgsqlBox(top: 0.8185405345220538d,right: 0.9603129171799178d,bottom: 0.45017367975700884d,left: 0.22333163971928238d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.920574725761223d,right: 0.43544016831525445d,bottom: 0.21725364064189223d,left: 0.2267219677502501d), new NpgsqlTypes.NpgsqlBox(top: 0.7082207851939709d,right: 0.7738335549282173d,bottom: 0.22668746337017953d,left: 0.5441789780199257d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.307016459575719d,right: 0.9059024797779348d,bottom: 0.24854416728197104d,left: 0.5103813317398601d), new NpgsqlTypes.NpgsqlBox(top: 0.7301811898415281d,right: 0.6930567172325177d,bottom: 0.14362958240112844d,left: 0.4665069512528567d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9537842573671433d,right: 0.9355029014871616d,bottom: 0.855797684067515d,left: 0.10969965430791107d), new NpgsqlTypes.NpgsqlBox(top: 0.9512633024402639d,right: 0.49208569568853244d,bottom: 0.5861965939240875d,left: 0.04546801393062694d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5685230601129332d,right: 0.6217402285257795d,bottom: 0.5623339126875815d,left: 0.12248976868320716d), new NpgsqlTypes.NpgsqlBox(top: 0.7158027201937767d,right: 0.6726707901695564d,bottom: 0.23031531269810668d,left: 0.5745454344215889d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.14877103685403648d,right: 0.43252507315883026d,bottom: 0.02111095987538336d,left: 0.0810406307033763d), new NpgsqlTypes.NpgsqlBox(top: 0.8733533800343893d,right: 0.6370856457567065d,bottom: 0.5458589448832472d,left: 0.5670058344407566d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7125558943868988d,right: 0.8634134319211639d,bottom: 0.6130986727616683d,left: 0.054973137826319185d), new NpgsqlTypes.NpgsqlBox(top: 0.7351569815568688d,right: 0.4762648253777052d,bottom: 0.557716652945528d,left: 0.11574354555393096d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.22312316541504207d,right: 0.6161263596230271d,bottom: 0.09765853658963719d,left: 0.43244468941491954d), new NpgsqlTypes.NpgsqlBox(top: 0.9251693364374975d,right: 0.8577646942565912d,bottom: 0.6696624076248504d,left: 0.8517073858752482d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6720135924746128d,right: 0.9264903752444861d,bottom: 0.46506139519415746d,left: 0.6959742392207808d), new NpgsqlTypes.NpgsqlBox(top: 0.8702667614475201d,right: 0.8083757934319789d,bottom: 0.8172520764568818d,left: 0.09495556088472812d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6668768914420937d,right: 0.5903794488275909d,bottom: 0.23893875772375028d,left: 0.3861411903666503d), new NpgsqlTypes.NpgsqlBox(top: 0.7531385809794411d,right: 0.24456434323695186d,bottom: 0.6274664994941096d,left: 0.032748698996353354d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9318934716722909d,right: 0.4727730356904998d,bottom: 0.24797293713045365d,left: 0.3512141660637118d), new NpgsqlTypes.NpgsqlBox(top: 0.9546844752467254d,right: 0.34894843168133804d,bottom: 0.4162966540385332d,left: 0.007248819636553772d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9668559875027508d,right: 0.9917700694341802d,bottom: 0.17997414213277652d,left: 0.6985486337402004d), new NpgsqlTypes.NpgsqlBox(top: 0.5929161071106744d,right: 0.8466707604452893d,bottom: 0.4919447856644519d,left: 0.8358252446379733d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5288155004415958d,right: 0.8423909734173466d,bottom: 0.17770786151827023d,left: 0.7919820096602838d), new NpgsqlTypes.NpgsqlBox(top: 0.38507474368884653d,right: 0.5376681947494608d,bottom: 0.3573452749515572d,left: 0.4565580609709913d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.661618888876915d,right: 0.3661417435944251d,bottom: 0.1367546098451644d,left: 0.1889384095491996d), new NpgsqlTypes.NpgsqlBox(top: 0.8213550839166895d,right: 0.7120008966369579d,bottom: 0.6418130954590048d,left: 0.2728750076117683d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6158903339502154d,right: 0.2102945813090107d,bottom: 0.227654445867849d,left: 0.1139746966184223d), new NpgsqlTypes.NpgsqlBox(top: 0.8237517663097722d,right: 0.9382547203464231d,bottom: 0.36521205905664855d,left: 0.8694943127810669d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3005547193737811d,right: 0.9111277285633506d,bottom: 0.2181330518575575d,left: 0.0758754829508862d), new NpgsqlTypes.NpgsqlBox(top: 0.45516632685487635d,right: 0.5081336572614408d,bottom: 0.3819515402213216d,left: 0.36656969127632655d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8769944954534731d,right: 0.7518259409395912d,bottom: 0.6937678292662153d,left: 0.09729757049068188d), new NpgsqlTypes.NpgsqlBox(top: 0.30466533529853057d,right: 0.4356661472275559d,bottom: 0.2914350005000692d,left: 0.40271385673895554d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9936229638123885d,right: 0.8361703288266628d,bottom: 0.20004171863145603d,left: 0.802960683468851d), new NpgsqlTypes.NpgsqlBox(top: 0.3833605344136012d,right: 0.9443904356101858d,bottom: 0.10149635357738018d,left: 0.593049585462301d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5865051560181785d,right: 0.8847976114190441d,bottom: 0.17012488229425493d,left: 0.7628169383310532d), new NpgsqlTypes.NpgsqlBox(top: 0.7427006433978751d,right: 0.1291193027688643d,bottom: 0.6014320111154722d,left: 0.11588388978144293d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9877217215723957d,right: 0.8194517840300799d,bottom: 0.7588463610611962d,left: 0.8120151775589873d), new NpgsqlTypes.NpgsqlBox(top: 0.9027232848362146d,right: 0.11574117121527017d,bottom: 0.6361770449821265d,left: 0.09480011123067045d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6670964840509105d,right: 0.9623874860126782d,bottom: 0.10795683970997827d,left: 0.6177844181693863d), new NpgsqlTypes.NpgsqlBox(top: 0.6983843796822854d,right: 0.6154461864186119d,bottom: 0.07678108406097317d,left: 0.5094527467514767d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9189458530104363d,right: 0.9794824150322967d,bottom: 0.28319498005921306d,left: 0.8247342041521616d), new NpgsqlTypes.NpgsqlBox(top: 0.8407980411678536d,right: 0.45903583925121116d,bottom: 0.23924722984199398d,left: 0.028536714116328743d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7711992459975614d,right: 0.9147934471465705d,bottom: 0.1148043639045293d,left: 0.5156337214784849d), new NpgsqlTypes.NpgsqlBox(top: 0.356561933429988d,right: 0.4456180277986185d,bottom: 0.2598434083423298d,left: 0.07097381888994514d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.73914710444793d,right: 0.9921958922274413d,bottom: 0.26781570368385965d,left: 0.8150549809220864d), new NpgsqlTypes.NpgsqlBox(top: 0.931741628092042d,right: 0.4513792114688978d,bottom: 0.5429046315784857d,left: 0.38278688604102573d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9651416496294255d,right: 0.4661157078307592d,bottom: 0.3894645143897575d,left: 0.04089532759234593d), new NpgsqlTypes.NpgsqlBox(top: 0.45310080240739636d,right: 0.6047229885278661d,bottom: 0.0539862502975067d,left: 0.3706816527167166d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7888575818851434d,right: 0.21994089365926583d,bottom: 0.31357612872786456d,left: 0.032216533979813944d), new NpgsqlTypes.NpgsqlBox(top: 0.849456934469648d,right: 0.4507346595878472d,bottom: 0.23556170401385856d,left: 0.25484809856198265d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9933554401859791d,right: 0.7711983677814073d,bottom: 0.6943593807380297d,left: 0.3133151590779365d), new NpgsqlTypes.NpgsqlBox(top: 0.5528811635788953d,right: 0.866904194619077d,bottom: 0.14152130635271243d,left: 0.22920915938787978d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.741688854258531d,right: 0.19540070670009368d,bottom: 0.6113087488907192d,left: 0.016348914311450913d), new NpgsqlTypes.NpgsqlBox(top: 0.9470213074437105d,right: 0.22609809756795818d,bottom: 0.20938285038602544d,left: 0.15681920580173658d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6509282831604596d,right: 0.570807519711426d,bottom: 0.2848714745395361d,left: 0.2292672939914444d), new NpgsqlTypes.NpgsqlBox(top: 0.5841699059435134d,right: 0.8645298166865575d,bottom: 0.25669434429195326d,left: 0.3648305062740891d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6749722333161181d,right: 0.556935109036092d,bottom: 0.24932316590671855d,left: 0.06968702508613067d), new NpgsqlTypes.NpgsqlBox(top: 0.8565054997947389d,right: 0.5912174617821038d,bottom: 0.46859332748607874d,left: 0.2520814159973441d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9824179635414817d,right: 0.8446469072003784d,bottom: 0.9758356464948057d,left: 0.8222675021575642d), new NpgsqlTypes.NpgsqlBox(top: 0.855864466897847d,right: 0.8369526768737421d,bottom: 0.47598971595272754d,left: 0.29748092137328563d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9883428530473664d,right: 0.5791264922035123d,bottom: 0.7355470201100202d,left: 0.23903222498834298d), new NpgsqlTypes.NpgsqlBox(top: 0.9656434565272262d,right: 0.8445320777266696d,bottom: 0.09045782976237204d,left: 0.23362317907894403d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.46128283918548196d,right: 0.6401661364103334d,bottom: 0.24271874542356808d,left: 0.32567616758234086d), new NpgsqlTypes.NpgsqlBox(top: 0.3288166444919125d,right: 0.6341349394582673d,bottom: 0.11782054124998276d,left: 0.2117745296561513d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5604963130172733d,right: 0.1571669000874365d,bottom: 0.386035637921748d,left: 0.05772849528290214d), new NpgsqlTypes.NpgsqlBox(top: 0.47640740475240484d,right: 0.7047330761434107d,bottom: 0.35195318091253236d,left: 0.4693670595493131d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8902472031762655d,right: 0.5512699968068211d,bottom: 0.6474564568068402d,left: 0.15737287977599546d), new NpgsqlTypes.NpgsqlBox(top: 0.8074166343797284d,right: 0.28907467260387676d,bottom: 0.6579353508997733d,left: 0.12036387867221765d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8437224201294851d,right: 0.9252953401589425d,bottom: 0.2591264218432936d,left: 0.31435709016884117d), new NpgsqlTypes.NpgsqlBox(top: 0.883946321604204d,right: 0.42268825971667734d,bottom: 0.37609525825169754d,left: 0.1346271178991647d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8227485262832154d,right: 0.7820031851197587d,bottom: 0.7934480891212893d,left: 0.02412531008092933d), new NpgsqlTypes.NpgsqlBox(top: 0.8951719511935028d,right: 0.6023439357934409d,bottom: 0.09282920774560521d,left: 0.021259066895563783d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5665999647040335d,right: 0.7077220707912057d,bottom: 0.4379919386520654d,left: 0.36870043199034375d), new NpgsqlTypes.NpgsqlBox(top: 0.5312663617368051d,right: 0.8310169149183652d,bottom: 0.02963071605968781d,left: 0.1575436302619978d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5441622543266464d,right: 0.46431710371209567d,bottom: 0.5381317479529966d,left: 0.3659711502348917d), new NpgsqlTypes.NpgsqlBox(top: 0.6625092033372008d,right: 0.4174441028264365d,bottom: 0.2195290540207534d,left: 0.22172750763697047d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.713932618522551d,right: 0.6914113480094468d,bottom: 0.017707174772433998d,left: 0.6101790530032247d), new NpgsqlTypes.NpgsqlBox(top: 0.5863713991815392d,right: 0.6474943640896739d,bottom: 0.5173524477432108d,left: 0.25222933529240843d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7139800347244079d,right: 0.46422510183027743d,bottom: 0.3989884816457896d,left: 0.04922107605328929d), new NpgsqlTypes.NpgsqlBox(top: 0.9412304084006683d,right: 0.9446136131169255d,bottom: 0.1823371841155247d,left: 0.05108592177171256d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7091740468558667d,right: 0.5265957152464004d,bottom: 0.19618709633563125d,left: 0.23395676987184744d), new NpgsqlTypes.NpgsqlBox(top: 0.6714334184819007d,right: 0.8877654897451618d,bottom: 0.562194056934707d,left: 0.0723723565245411d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8459955336764943d,right: 0.852198417466456d,bottom: 0.7420595407811362d,left: 0.23619685095043175d), new NpgsqlTypes.NpgsqlBox(top: 0.7141281353753423d,right: 0.8998905514280743d,bottom: 0.29950985831491606d,left: 0.0657190006414834d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7767655196232781d,right: 0.9657946849861672d,bottom: 0.24556709788707232d,left: 0.2906445960657038d), new NpgsqlTypes.NpgsqlBox(top: 0.9952658813706471d,right: 0.6082142669130106d,bottom: 0.5591949420065596d,left: 0.29144086107293454d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.83707260187773d,right: 0.8097956514668466d,bottom: 0.07044214597681886d,left: 0.49236449081291156d), new NpgsqlTypes.NpgsqlBox(top: 0.9784137590682456d,right: 0.6367493633603762d,bottom: 0.5749874367685488d,left: 0.5949230816466707d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9966869609788642d,right: 0.4834254970092634d,bottom: 0.03818837377306128d,left: 0.03809950408725149d), new NpgsqlTypes.NpgsqlBox(top: 0.7673433483300941d,right: 0.9610813205823078d,bottom: 0.018743942193180096d,left: 0.011682990424912942d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3805569125365196d,right: 0.8126585547260661d,bottom: 0.2023064792155741d,left: 0.6122351496711648d), new NpgsqlTypes.NpgsqlBox(top: 0.9213751913623183d,right: 0.838638606810428d,bottom: 0.24182481938718725d,left: 0.7257916218225003d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7896076937225066d,right: 0.43361228201281454d,bottom: 0.05410954234682097d,left: 0.33335213816594d), new NpgsqlTypes.NpgsqlBox(top: 0.8112984963814941d,right: 0.987480258521976d,bottom: 0.5563079626251848d,left: 0.7081004925827453d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5408744832246881d,right: 0.9055127416247837d,bottom: 0.12135674486645154d,left: 0.7933534691280942d), new NpgsqlTypes.NpgsqlBox(top: 0.4438279808872786d,right: 0.6024633502950122d,bottom: 0.3180218641000644d,left: 0.16747904329872598d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2453032342300252d,right: 0.32536101340046253d,bottom: 0.22308584713648927d,left: 0.28476978827078325d), new NpgsqlTypes.NpgsqlBox(top: 0.27208172709939127d,right: 0.38908995463272256d,bottom: 0.17984488398520837d,left: 0.24716376100078596d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8788250603289217d,right: 0.6525373577079059d,bottom: 0.08671862494500138d,left: 0.25186068909726234d), new NpgsqlTypes.NpgsqlBox(top: 0.38460037178579387d,right: 0.41645760230137796d,bottom: 0.0738207001364567d,left: 0.40811607648009196d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6408853271781064d,right: 0.13347537023821798d,bottom: 0.11178620740060685d,left: 0.014052495324207936d), new NpgsqlTypes.NpgsqlBox(top: 0.38040275541748836d,right: 0.9812750546172394d,bottom: 0.2308174148646681d,left: 0.6518450659398844d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.379256881053069d,right: 0.5984414914172496d,bottom: 0.029089524191753813d,left: 0.42285828882419685d), new NpgsqlTypes.NpgsqlBox(top: 0.9022207345958628d,right: 0.9940447990817137d,bottom: 0.7346493503818925d,left: 0.7011081670452821d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4341096495721911d,right: 0.8126383791511588d,bottom: 0.20567570141357672d,left: 0.5745316440133674d), new NpgsqlTypes.NpgsqlBox(top: 0.7631132559949948d,right: 0.5237409715967545d,bottom: 0.10255520495520254d,left: 0.47434561035785683d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6594177550823374d,right: 0.8946569050979384d,bottom: 0.35147676251888404d,left: 0.2550457157895353d), new NpgsqlTypes.NpgsqlBox(top: 0.8361224982751638d,right: 0.6527531451216068d,bottom: 0.7205790605716261d,left: 0.2962660685912333d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9282685372625913d,right: 0.5756797421065998d,bottom: 0.5079302460235673d,left: 0.005307615092529416d), new NpgsqlTypes.NpgsqlBox(top: 0.795049484229492d,right: 0.08911117004319902d,bottom: 0.5641852569504116d,left: 0.055469263823568316d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.2083644687892705d,right: 0.5316688482792996d,bottom: 0.1215400556428341d,left: 0.19497568749014293d), new NpgsqlTypes.NpgsqlBox(top: 0.4695936586666577d,right: 0.7575876854120065d,bottom: 0.10703618844535201d,left: 0.40776765556495065d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5334362858978581d,right: 0.7694147031262072d,bottom: 0.2946562830487627d,left: 0.6705856049068412d), new NpgsqlTypes.NpgsqlBox(top: 0.9047449979186148d,right: 0.46679108038081274d,bottom: 0.8661366541856605d,left: 0.1421054955428912d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5944450150251527d,right: 0.8791913899160471d,bottom: 0.27474785407261015d,left: 0.39401847668783485d), new NpgsqlTypes.NpgsqlBox(top: 0.5581708960229397d,right: 0.9264087112295311d,bottom: 0.1301627173399723d,left: 0.06528527550050711d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5098044247724531d,right: 0.2134296285962447d,bottom: 0.17570718711868227d,left: 0.10866624684070958d), new NpgsqlTypes.NpgsqlBox(top: 0.9908959879680656d,right: 0.6373099112931229d,bottom: 0.5352694758632965d,left: 0.33528697202074953d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5948931477184939d,right: 0.25690968895779587d,bottom: 0.27877567804638614d,left: 0.06915678732665786d), new NpgsqlTypes.NpgsqlBox(top: 0.6257669876614605d,right: 0.5997730054648005d,bottom: 0.6025153311448519d,left: 0.1502409406473536d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.33788799342877807d,right: 0.8478814588442656d,bottom: 0.13701466273373397d,left: 0.5249617193258471d), new NpgsqlTypes.NpgsqlBox(top: 0.2907538482436778d,right: 0.5149842681051304d,bottom: 0.10237405686399659d,left: 0.20365078431731276d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8100828364272783d,right: 0.6559171759283511d,bottom: 0.6618317491543707d,left: 0.32307685924745766d), new NpgsqlTypes.NpgsqlBox(top: 0.6932662945809265d,right: 0.6091655855765123d,bottom: 0.4170209825676535d,left: 0.24627895310388548d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8661338150470232d,right: 0.7036789812334889d,bottom: 0.4113279788079971d,left: 0.5992322707816962d), new NpgsqlTypes.NpgsqlBox(top: 0.6205649641324109d,right: 0.8626941288963429d,bottom: 0.355969741015561d,left: 0.24582029992330945d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.76179091847141d,right: 0.5303244591859422d,bottom: 0.320250644681385d,left: 0.3580378252268419d), new NpgsqlTypes.NpgsqlBox(top: 0.631485791615585d,right: 0.4335880482514183d,bottom: 0.43326425530843493d,left: 0.07369237294276387d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6507216804854979d,right: 0.9195715267251007d,bottom: 0.20512006469987687d,left: 0.7909771729070381d), new NpgsqlTypes.NpgsqlBox(top: 0.4421895238898217d,right: 0.8881460676171173d,bottom: 0.23216592922300838d,left: 0.350543238416014d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.822261776717037d,right: 0.1894510776946171d,bottom: 0.6606955412008734d,left: 0.11098757341475729d), new NpgsqlTypes.NpgsqlBox(top: 0.9637414958114132d,right: 0.9201663588663975d,bottom: 0.16430175368832434d,left: 0.45245254915665767d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9238386019242424d,right: 0.9933178549091553d,bottom: 0.2382776253204003d,left: 0.5590169857178797d), new NpgsqlTypes.NpgsqlBox(top: 0.6649141875020701d,right: 0.8520566725122353d,bottom: 0.4555849671716502d,left: 0.36336190591869755d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7125008067804242d,right: 0.9475132016511147d,bottom: 0.07248543391191065d,left: 0.3409286657404965d), new NpgsqlTypes.NpgsqlBox(top: 0.3932626940549756d,right: 0.8088034285652488d,bottom: 0.30234235555956235d,left: 0.4758658373355459d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8525105425768602d,right: 0.7701803378305107d,bottom: 0.20944313079771626d,left: 0.6425614328448448d), new NpgsqlTypes.NpgsqlBox(top: 0.5482148840200828d,right: 0.9325452715885076d,bottom: 0.505470287252112d,left: 0.5035148542539106d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9953372433295172d,right: 0.9456538421867792d,bottom: 0.39594756109480167d,left: 0.8087696440967388d), new NpgsqlTypes.NpgsqlBox(top: 0.7287056598074029d,right: 0.48318861311250705d,bottom: 0.6404811830127111d,left: 0.08326897540066103d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5549361716422113d,right: 0.9030343893385374d,bottom: 0.31216877576485513d,left: 0.614265707027848d), new NpgsqlTypes.NpgsqlBox(top: 0.8515887248053672d,right: 0.6360461733187417d,bottom: 0.4360206421907177d,left: 0.022443952304441517d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4834072353426617d,right: 0.059984723801164486d,bottom: 0.46776461446303164d,left: 0.0560869289096152d), new NpgsqlTypes.NpgsqlBox(top: 0.5083298269650839d,right: 0.8064515898420251d,bottom: 0.15916554239242187d,left: 0.31103891303043707d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.34029481461936884d,right: 0.45993055288868534d,bottom: 0.1411092235509197d,left: 0.10207250914998378d), new NpgsqlTypes.NpgsqlBox(top: 0.5851273152533942d,right: 0.25713582732755413d,bottom: 0.0747234840337564d,left: 0.18543830260251337d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7095929529773142d,right: 0.8520942373324288d,bottom: 0.44360938174869546d,left: 0.777167079347387d), new NpgsqlTypes.NpgsqlBox(top: 0.6719048903047938d,right: 0.6550366655507174d,bottom: 0.29853484266308394d,left: 0.3257480585928081d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.1618554122598187d,right: 0.5408820260125945d,bottom: 0.021697677160296136d,left: 0.22358968818586555d), new NpgsqlTypes.NpgsqlBox(top: 0.9489608778286498d,right: 0.2397528282813508d,bottom: 0.8730838779285209d,left: 0.08078766581476327d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.243391501273018d,right: 0.7526512284102814d,bottom: 0.05031742628215041d,left: 0.3678365138570402d), new NpgsqlTypes.NpgsqlBox(top: 0.8350855463825044d,right: 0.958352677205957d,bottom: 0.5885948585383316d,left: 0.6639731438539326d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7407312312910523d,right: 0.9742839451737272d,bottom: 0.31552497216925857d,left: 0.8532338330473026d), new NpgsqlTypes.NpgsqlBox(top: 0.6241491831351265d,right: 0.3427430258519556d,bottom: 0.34310601830027465d,left: 0.19309955661012213d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3113393991641634d,right: 0.1800340486106341d,bottom: 0.22031924754085275d,left: 0.08787405855266872d), new NpgsqlTypes.NpgsqlBox(top: 0.5990258791314446d,right: 0.8249070022857434d,bottom: 0.2676575339806937d,left: 0.2624003149315288d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2355988864431413d,right: 0.9737563134258846d,bottom: 0.06436035072100488d,left: 0.6179517494385668d), new NpgsqlTypes.NpgsqlBox(top: 0.8371316997127787d,right: 0.29168711657528335d,bottom: 0.05577628577589955d,left: 0.1327107320714398d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6312738871426111d,right: 0.364019676731962d,bottom: 0.16100017782770892d,left: 0.17142569329341972d), new NpgsqlTypes.NpgsqlBox(top: 0.6158549672585555d,right: 0.4382517624539143d,bottom: 0.3885588187257212d,left: 0.22385653504802594d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9733925237848219d,right: 0.8884247392922614d,bottom: 0.8966862105585143d,left: 0.5576104927407688d), new NpgsqlTypes.NpgsqlBox(top: 0.6816216058735889d,right: 0.934490880574445d,bottom: 0.04766051339104249d,left: 0.05259135869535492d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5400074556120681d,right: 0.9989098580755029d,bottom: 0.1806646076332835d,left: 0.6844540355351453d), new NpgsqlTypes.NpgsqlBox(top: 0.6523810043617565d,right: 0.7125883559370535d,bottom: 0.5417799172772778d,left: 0.3722793355200973d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8236643773573701d,right: 0.5299107576073931d,bottom: 0.2663268359951917d,left: 0.4600683550320944d), new NpgsqlTypes.NpgsqlBox(top: 0.6372914053722951d,right: 0.5897471666238608d,bottom: 0.20132799964764414d,left: 0.4726190837820481d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4505553774582356d,right: 0.8463451008267759d,bottom: 0.1029537942907115d,left: 0.826169424082832d), new NpgsqlTypes.NpgsqlBox(top: 0.7310149757844113d,right: 0.47635478286680366d,bottom: 0.7120977886378073d,left: 0.1988441192165995d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8275895472216764d,right: 0.9064513087320671d,bottom: 0.4148043570553105d,left: 0.33128810107122453d), new NpgsqlTypes.NpgsqlBox(top: 0.8343175087536171d,right: 0.18218403418875673d,bottom: 0.8290998552552593d,left: 0.038715606188513885d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7221007476628247d,right: 0.21538416968853513d,bottom: 0.17567594491586125d,left: 0.010740200789647547d), new NpgsqlTypes.NpgsqlBox(top: 0.7754681880549157d,right: 0.7142635611258987d,bottom: 0.38451730208253043d,left: 0.1063311087740949d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.726020156100764d,right: 0.69233643994329d,bottom: 0.5607067079365029d,left: 0.6010517005897976d), new NpgsqlTypes.NpgsqlBox(top: 0.775558636562727d,right: 0.7449114532537333d,bottom: 0.2549437016817938d,left: 0.2806472564337865d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8907936128761537d,right: 0.8519584421897121d,bottom: 0.7732294856551776d,left: 0.32847107322120583d), new NpgsqlTypes.NpgsqlBox(top: 0.9088440835621205d,right: 0.5624208599644978d,bottom: 0.26765505318958893d,left: 0.5617493696900693d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7053704533386135d,right: 0.6933883146315221d,bottom: 0.351897452898309d,left: 0.6436676363620238d), new NpgsqlTypes.NpgsqlBox(top: 0.09828036297258713d,right: 0.652586048590093d,bottom: 0.029995752841976087d,left: 0.2436609114390227d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9828830888534575d,right: 0.38567408083310906d,bottom: 0.8249673119318782d,left: 0.03930969060688305d), new NpgsqlTypes.NpgsqlBox(top: 0.7767120356187467d,right: 0.9319770904198886d,bottom: 0.3431106862257537d,left: 0.4822547098752723d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9537963399067675d,right: 0.4671116274716963d,bottom: 0.7751887029483772d,left: 0.4114002472774666d), new NpgsqlTypes.NpgsqlBox(top: 0.6275656220321774d,right: 0.41164270859274044d,bottom: 0.5572123427809275d,left: 0.04276148553522008d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.35419215161954454d,right: 0.8689491532939616d,bottom: 0.006487102378896936d,left: 0.533994444181358d), new NpgsqlTypes.NpgsqlBox(top: 0.5096605894044746d,right: 0.3403640266147242d,bottom: 0.38004857767199696d,left: 0.19502780946542453d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2143344291063256d,right: 0.9229084555442368d,bottom: 0.05448931629129339d,left: 0.8394034043415883d), new NpgsqlTypes.NpgsqlBox(top: 0.5405602501613078d,right: 0.9695447941065872d,bottom: 0.5191317670749005d,left: 0.8734059858016371d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9691312882436122d,right: 0.5280554121769022d,bottom: 0.24080155245914514d,left: 0.11704593802081431d), new NpgsqlTypes.NpgsqlBox(top: 0.49070294777867596d,right: 0.7569278716735165d,bottom: 0.015529883029838931d,left: 0.6422427627559913d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.19555981114982712d,right: 0.5605999281631344d,bottom: 0.08816405465590516d,left: 0.35420429939802456d), new NpgsqlTypes.NpgsqlBox(top: 0.961740942866154d,right: 0.5988207146653357d,bottom: 0.3766997683419838d,left: 0.2768734894491749d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5203407514845249d,right: 0.7433032474361587d,bottom: 0.1848859499956027d,left: 0.4269116627878472d), new NpgsqlTypes.NpgsqlBox(top: 0.7225749177852606d,right: 0.9127048152202164d,bottom: 0.6157703034724632d,left: 0.6748188688841957d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3553051367880462d,right: 0.46380856150411365d,bottom: 0.0798256912434836d,left: 0.14484426598941447d), new NpgsqlTypes.NpgsqlBox(top: 0.9001848345437624d,right: 0.7884845198824373d,bottom: 0.8453272623526559d,left: 0.33736826286078603d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7563108536425497d,right: 0.9190201691342643d,bottom: 0.6755385186801498d,left: 0.3923317786481183d), new NpgsqlTypes.NpgsqlBox(top: 0.4209071456728233d,right: 0.9445314704849437d,bottom: 0.41249664384254114d,left: 0.25572358211487356d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.88732178433867d,right: 0.48313644457981175d,bottom: 0.0036004396783821946d,left: 0.2508995636019039d), new NpgsqlTypes.NpgsqlBox(top: 0.8078446070939869d,right: 0.35944475827197997d,bottom: 0.6492566147951666d,left: 0.012321974140856673d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8885972759685933d,right: 0.5121772873410039d,bottom: 0.24062249108918676d,left: 0.1730751648533232d), new NpgsqlTypes.NpgsqlBox(top: 0.7098521781283108d,right: 0.7766457212899796d,bottom: 0.5123620047260983d,left: 0.12275576039127356d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.26579104757936445d,right: 0.7922797661411125d,bottom: 0.0076391624279406045d,left: 0.09408599814563257d), new NpgsqlTypes.NpgsqlBox(top: 0.4113979997772984d,right: 0.9776558047840965d,bottom: 0.15094022056684897d,left: 0.03946901470259323d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9950710262993959d,right: 0.7033547662586417d,bottom: 0.582616227887031d,left: 0.3953101098253471d), new NpgsqlTypes.NpgsqlBox(top: 0.8429828276338152d,right: 0.15905607099986474d,bottom: 0.25174615737557093d,left: 0.10628569456946224d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4487692503920362d,right: 0.7247761297220014d,bottom: 0.4478687252705619d,left: 0.12137074913874757d), new NpgsqlTypes.NpgsqlBox(top: 0.7334492347740084d,right: 0.5177509309595839d,bottom: 0.48885247092621786d,left: 0.15659934609387505d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.18198960423692212d,right: 0.5830468090220734d,bottom: 0.06491429492853906d,left: 0.0334107689827039d), new NpgsqlTypes.NpgsqlBox(top: 0.48423281962480813d,right: 0.2185887097880701d,bottom: 0.3384407291966014d,left: 0.01432271392594786d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7370186086750324d,right: 0.8417415808123737d,bottom: 0.21054144397703933d,left: 0.08414678668013931d), new NpgsqlTypes.NpgsqlBox(top: 0.6042889425294203d,right: 0.8934925067417548d,bottom: 0.009108207290977166d,left: 0.8227940291346022d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4672336958278617d,right: 0.9795875111847289d,bottom: 0.2230177062104065d,left: 0.5575281979939748d), new NpgsqlTypes.NpgsqlBox(top: 0.7708410751417151d,right: 0.992189581341023d,bottom: 0.6226372414100321d,left: 0.1607405275527921d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9055215275953826d,right: 0.7459664013163646d,bottom: 0.11880937764172206d,left: 0.04558557065252988d), new NpgsqlTypes.NpgsqlBox(top: 0.7047561706963247d,right: 0.5723355344269553d,bottom: 0.3027374568236769d,left: 0.0431610680794523d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.1356001731704567d,right: 0.9325699431863661d,bottom: 0.13473132522300235d,left: 0.010899983894325338d), new NpgsqlTypes.NpgsqlBox(top: 0.7303401519993316d,right: 0.7275411467303665d,bottom: 0.5654727105811533d,left: 0.7024465076694475d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4557167427378378d,right: 0.7597650016811768d,bottom: 0.34719611565840547d,left: 0.4144528014360469d), new NpgsqlTypes.NpgsqlBox(top: 0.9974918894842162d,right: 0.5517745062046613d,bottom: 0.3930897982295315d,left: 0.4786717231440666d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5917970627559976d,right: 0.5938608961980518d,bottom: 0.12815483180001175d,left: 0.00906792935377898d), new NpgsqlTypes.NpgsqlBox(top: 0.33909239576851113d,right: 0.286882566469999d,bottom: 0.3045756665101621d,left: 0.08235229201202321d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5026501964135351d,right: 0.8892087908709306d,bottom: 0.2827525019758096d,left: 0.8457328211245749d), new NpgsqlTypes.NpgsqlBox(top: 0.792474844096278d,right: 0.9138645613612391d,bottom: 0.1470329996479165d,left: 0.4786477883602489d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5145991888409621d,right: 0.5715371202847986d,bottom: 0.08922113063410375d,left: 0.5226533663965658d), new NpgsqlTypes.NpgsqlBox(top: 0.5064596456055394d,right: 0.3043935112002707d,bottom: 0.43069522129341d,left: 0.000535554049685083d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6015170369516357d,right: 0.9353726425412416d,bottom: 0.11938303246605575d,left: 0.783357591320085d), new NpgsqlTypes.NpgsqlBox(top: 0.4493219988896897d,right: 0.9298423598430381d,bottom: 0.26656960651233075d,left: 0.2758323715067481d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.21670583401311416d,right: 0.3081392612514863d,bottom: 0.0021504104604150864d,left: 0.031188258918057543d), new NpgsqlTypes.NpgsqlBox(top: 0.8179211523564904d,right: 0.6134191926281545d,bottom: 0.5973570010182008d,left: 0.37162946086607196d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5618760877200477d,right: 0.3193697431565171d,bottom: 0.3814394414399592d,left: 0.13253043905717599d), new NpgsqlTypes.NpgsqlBox(top: 0.9434046904174436d,right: 0.4771769488070906d,bottom: 0.45119823437369166d,left: 0.04462618047648359d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.2536895902919152d,right: 0.9396889189258932d,bottom: 0.24889157479583313d,left: 0.25966881428059674d), new NpgsqlTypes.NpgsqlBox(top: 0.9082673577180429d,right: 0.279350402452602d,bottom: 0.025004721587681522d,left: 0.18203233127029295d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7187558021530424d,right: 0.3862889858051133d,bottom: 0.30585740101720893d,left: 0.06472968909940036d), new NpgsqlTypes.NpgsqlBox(top: 0.69405476217433d,right: 0.39284750752458963d,bottom: 0.15624260184954075d,left: 0.08510601723456568d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9506098814748696d,right: 0.5250472509736509d,bottom: 0.32017253030215376d,left: 0.1902747949328084d), new NpgsqlTypes.NpgsqlBox(top: 0.7960747393456303d,right: 0.3264441245347216d,bottom: 0.09824106504081698d,left: 0.2556199576573399d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9775028737580533d,right: 0.38509559471098d,bottom: 0.532770799834675d,left: 0.3733508065851794d), new NpgsqlTypes.NpgsqlBox(top: 0.20202704768269142d,right: 0.46884677412976195d,bottom: 0.07369564229665615d,left: 0.23210789318652403d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.36938063607564564d,right: 0.6824570949919322d,bottom: 0.035847703823268184d,left: 0.16656447925634432d), new NpgsqlTypes.NpgsqlBox(top: 0.5663497895141473d,right: 0.5994806668741888d,bottom: 0.040841115962285346d,left: 0.2559362305234971d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6395915003736539d,right: 0.39886188433231384d,bottom: 0.6275998818397086d,left: 0.3278445602483402d), new NpgsqlTypes.NpgsqlBox(top: 0.684609801329012d,right: 0.6389520156469124d,bottom: 0.2764436368729942d,left: 0.36658102112697677d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7650528328115953d,right: 0.8564709664119735d,bottom: 0.164877942903921d,left: 0.4506751639247111d), new NpgsqlTypes.NpgsqlBox(top: 0.8210243500540437d,right: 0.6754368794701784d,bottom: 0.21196058301559428d,left: 0.15702282719480276d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7430055674528973d,right: 0.7734407188161218d,bottom: 0.05195329776290947d,left: 0.23910498987655793d), new NpgsqlTypes.NpgsqlBox(top: 0.8013028255639485d,right: 0.3208186544639463d,bottom: 0.3487992510794258d,left: 0.22053616768411166d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7857957236833932d,right: 0.9089878986323555d,bottom: 0.2735756180781169d,left: 0.3392972229862439d), new NpgsqlTypes.NpgsqlBox(top: 0.13019749216134846d,right: 0.6251662451101331d,bottom: 0.07156888725185029d,left: 0.12140929920478438d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.14917033825117598d,right: 0.7692506345499733d,bottom: 0.1296613424587718d,left: 0.44353246094200294d), new NpgsqlTypes.NpgsqlBox(top: 0.9926548316970438d,right: 0.6307942661960593d,bottom: 0.4095715783734911d,left: 0.4652922403932831d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4956607527923982d,right: 0.27176767414059666d,bottom: 0.22942477151593565d,left: 0.24667628947613907d), new NpgsqlTypes.NpgsqlBox(top: 0.7999994897433386d,right: 0.7944516888879415d,bottom: 0.6830682555464956d,left: 0.7556987952586689d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8292138664279317d,right: 0.8377765031376191d,bottom: 0.32783699278885114d,left: 0.08108489937997387d), new NpgsqlTypes.NpgsqlBox(top: 0.902995985486482d,right: 0.2623536678136055d,bottom: 0.8527573217172302d,left: 0.06174418329164022d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.47676636223077173d,right: 0.8725718478195659d,bottom: 0.4176619903735236d,left: 0.2271472346964999d), new NpgsqlTypes.NpgsqlBox(top: 0.24046446123388532d,right: 0.6483935585358581d,bottom: 0.0050570046329635465d,left: 0.5436650473760113d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6079372554391124d,right: 0.5066850520072737d,bottom: 0.27957615735201335d,left: 0.4766477698110241d), new NpgsqlTypes.NpgsqlBox(top: 0.9713014111041106d,right: 0.821711303860059d,bottom: 0.8355530716862981d,left: 0.33027041405154356d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8148707123713339d,right: 0.613211094384234d,bottom: 0.7814955167613934d,left: 0.08660250688058568d), new NpgsqlTypes.NpgsqlBox(top: 0.6493066653665563d,right: 0.6963301779054456d,bottom: 0.07567136468923441d,left: 0.496654193171465d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8970419566008306d,right: 0.9135098433471485d,bottom: 0.38777852971375204d,left: 0.18415383124327522d), new NpgsqlTypes.NpgsqlBox(top: 0.7239315107944748d,right: 0.40364119023172973d,bottom: 0.47986928412432983d,left: 0.23749166780315112d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5349895621917997d,right: 0.8550324092091259d,bottom: 0.46090048702719744d,left: 0.04145447081146625d), new NpgsqlTypes.NpgsqlBox(top: 0.7359846581421923d,right: 0.5240341108082303d,bottom: 0.01876328174550934d,left: 0.2723200426286757d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6402953681678918d,right: 0.3994372071263588d,bottom: 0.5803901209750155d,left: 0.05853081754798495d), new NpgsqlTypes.NpgsqlBox(top: 0.7222354691758205d,right: 0.6411203056090627d,bottom: 0.43574837370193376d,left: 0.19269175049828857d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6054306047928154d,right: 0.7899503815325184d,bottom: 0.045750154401187126d,left: 0.24272114835616332d), new NpgsqlTypes.NpgsqlBox(top: 0.7351514306676371d,right: 0.5367127694475816d,bottom: 0.6403815941721581d,left: 0.18507202217833385d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7599695348232695d,right: 0.6274970621270047d,bottom: 0.6596959523335689d,left: 0.1545955355831049d), new NpgsqlTypes.NpgsqlBox(top: 0.5251279781900576d,right: 0.7625910630806442d,bottom: 0.37489635036319124d,left: 0.6475531738476628d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.680480691562091d,right: 0.5169222226872107d,bottom: 0.12455389160879438d,left: 0.2968738377314386d), new NpgsqlTypes.NpgsqlBox(top: 0.2730429869331815d,right: 0.9492615211479758d,bottom: 0.1691958489393499d,left: 0.09674127605161342d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3820321875539422d,right: 0.5065196768280522d,bottom: 0.16192199922725203d,left: 0.07004913332375007d), new NpgsqlTypes.NpgsqlBox(top: 0.8287766772038255d,right: 0.680631435774831d,bottom: 0.59422162617865d,left: 0.13538188832635323d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9405838947441885d,right: 0.6238657027070861d,bottom: 0.05579188662448076d,left: 0.3094898855806172d), new NpgsqlTypes.NpgsqlBox(top: 0.6780996406616641d,right: 0.9459921362631732d,bottom: 0.6007448250273199d,left: 0.3778564724205591d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9537842573671433d,right: 0.9355029014871616d,bottom: 0.855797684067515d,left: 0.10969965430791107d), new NpgsqlTypes.NpgsqlBox(top: 0.9512633024402639d,right: 0.49208569568853244d,bottom: 0.5861965939240875d,left: 0.04546801393062694d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5685230601129332d,right: 0.6217402285257795d,bottom: 0.5623339126875815d,left: 0.12248976868320716d), new NpgsqlTypes.NpgsqlBox(top: 0.7158027201937767d,right: 0.6726707901695564d,bottom: 0.23031531269810668d,left: 0.5745454344215889d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.22312316541504207d,right: 0.6161263596230271d,bottom: 0.09765853658963719d,left: 0.43244468941491954d), new NpgsqlTypes.NpgsqlBox(top: 0.9251693364374975d,right: 0.8577646942565912d,bottom: 0.6696624076248504d,left: 0.8517073858752482d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6720135924746128d,right: 0.9264903752444861d,bottom: 0.46506139519415746d,left: 0.6959742392207808d), new NpgsqlTypes.NpgsqlBox(top: 0.8702667614475201d,right: 0.8083757934319789d,bottom: 0.8172520764568818d,left: 0.09495556088472812d), }, }));
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3005547193737811d,right: 0.9111277285633506d,bottom: 0.2181330518575575d,left: 0.0758754829508862d), new NpgsqlTypes.NpgsqlBox(top: 0.45516632685487635d,right: 0.5081336572614408d,bottom: 0.3819515402213216d,left: 0.36656969127632655d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8769944954534731d,right: 0.7518259409395912d,bottom: 0.6937678292662153d,left: 0.09729757049068188d), new NpgsqlTypes.NpgsqlBox(top: 0.30466533529853057d,right: 0.4356661472275559d,bottom: 0.2914350005000692d,left: 0.40271385673895554d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9877217215723957d,right: 0.8194517840300799d,bottom: 0.7588463610611962d,left: 0.8120151775589873d), new NpgsqlTypes.NpgsqlBox(top: 0.9027232848362146d,right: 0.11574117121527017d,bottom: 0.6361770449821265d,left: 0.09480011123067045d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6670964840509105d,right: 0.9623874860126782d,bottom: 0.10795683970997827d,left: 0.6177844181693863d), new NpgsqlTypes.NpgsqlBox(top: 0.6983843796822854d,right: 0.6154461864186119d,bottom: 0.07678108406097317d,left: 0.5094527467514767d), }, }));
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 15;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 142, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 23, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 109, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
FROM public.binary_npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI), typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

