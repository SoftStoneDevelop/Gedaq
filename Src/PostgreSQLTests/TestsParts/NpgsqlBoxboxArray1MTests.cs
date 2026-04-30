

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
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7723592267722431d,right: 0.8918325588395435d,bottom: 0.7289508990338158d,left: 0.08089834498158865d),
new NpgsqlTypes.NpgsqlBox(top: 0.4814605665181114d,right: 0.163694828439093d,bottom: 0.46038910527798504d,left: 0.0006269633848529077d),
new NpgsqlTypes.NpgsqlBox(top: 0.6944610318156688d,right: 0.8157465204398762d,bottom: 0.4578738653822063d,left: 0.7082400613594557d),
new NpgsqlTypes.NpgsqlBox(top: 0.4896249744412503d,right: 0.3357298235475549d,bottom: 0.230787316194088d,left: 0.28389455958251664d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29148283586161905d,right: 0.48550463399021415d,bottom: 0.281596722612264d,left: 0.24238275427563893d),
new NpgsqlTypes.NpgsqlBox(top: 0.7483216498569906d,right: 0.97069938293145d,bottom: 0.30547729496781906d,left: 0.7219056901547798d),
new NpgsqlTypes.NpgsqlBox(top: 0.4802958334549753d,right: 0.7806389818806162d,bottom: 0.08015478472451054d,left: 0.5168198955571631d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.418092587827421d,right: 0.4512173945240642d,bottom: 0.16496012074695698d,left: 0.2870346784066927d),
new NpgsqlTypes.NpgsqlBox(top: 0.8973350467927547d,right: 0.7970901599779215d,bottom: 0.7918482863814852d,left: 0.500574178799028d),
new NpgsqlTypes.NpgsqlBox(top: 0.46834075741016046d,right: 0.9397231215842579d,bottom: 0.4437457564341887d,left: 0.6026979435544999d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9207158739888186d,right: 0.5703931624672028d,bottom: 0.233486985141242d,left: 0.0813688003649391d),
new NpgsqlTypes.NpgsqlBox(top: 0.5587409912964616d,right: 0.726003442805743d,bottom: 0.22658608945772585d,left: 0.2430790740836326d),
new NpgsqlTypes.NpgsqlBox(top: 0.4225252002240909d,right: 0.341343817907066d,bottom: 0.39830589119066917d,left: 0.04857022982817427d),
new NpgsqlTypes.NpgsqlBox(top: 0.602145302933857d,right: 0.9161035718421061d,bottom: 0.23131730725507205d,left: 0.1543048992557997d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8005663348812045d,right: 0.3984698510973028d,bottom: 0.37714980603246284d,left: 0.13169915599398252d),
new NpgsqlTypes.NpgsqlBox(top: 0.9371419073434188d,right: 0.5843279624596552d,bottom: 0.486121618461859d,left: 0.2125435698869107d),
new NpgsqlTypes.NpgsqlBox(top: 0.9833000844704906d,right: 0.9771759312992365d,bottom: 0.8044266605471995d,left: 0.8168226298327027d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9812040023392745d,right: 0.8263422018430182d,bottom: 0.7773894594342098d,left: 0.33081123506365195d),
new NpgsqlTypes.NpgsqlBox(top: 0.6631573136902197d,right: 0.8568504566005846d,bottom: 0.1754353022156201d,left: 0.6756206030853803d),
new NpgsqlTypes.NpgsqlBox(top: 0.5374673657639478d,right: 0.8714327689774514d,bottom: 0.49166719459741137d,left: 0.2145055835444345d),
new NpgsqlTypes.NpgsqlBox(top: 0.6067133597725516d,right: 0.6252296037038717d,bottom: 0.6052978165869726d,left: 0.1544078197035451d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.811926795479122d,right: 0.8389823581880075d,bottom: 0.05477503171300824d,left: 0.7123559094296379d),
new NpgsqlTypes.NpgsqlBox(top: 0.6914125582262299d,right: 0.624596165029587d,bottom: 0.37048736612655d,left: 0.4624596986806363d),
new NpgsqlTypes.NpgsqlBox(top: 0.5473671616414434d,right: 0.5504215465591781d,bottom: 0.22794567100254837d,left: 0.30207437503576284d),
new NpgsqlTypes.NpgsqlBox(top: 0.799754276702395d,right: 0.7141893457786634d,bottom: 0.6045618474611264d,left: 0.3926577866572081d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6004237740202825d,right: 0.5885809002818657d,bottom: 0.28633647047261745d,left: 0.044454032774209784d),
new NpgsqlTypes.NpgsqlBox(top: 0.7309441635409266d,right: 0.6834749363672982d,bottom: 0.25119755162519697d,left: 0.2870159298480476d),
new NpgsqlTypes.NpgsqlBox(top: 0.619902195983152d,right: 0.32805658499786505d,bottom: 0.11870343044369591d,left: 0.2552164204634314d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9024503268394526d,right: 0.8799532826316848d,bottom: 0.8539738003646353d,left: 0.6178298334497684d),
new NpgsqlTypes.NpgsqlBox(top: 0.6909282799075608d,right: 0.6157559291742942d,bottom: 0.6385505427780792d,left: 0.26165542345965764d),
new NpgsqlTypes.NpgsqlBox(top: 0.9182217524067531d,right: 0.8794406448944566d,bottom: 0.5976202240482115d,left: 0.3822675093152419d),
new NpgsqlTypes.NpgsqlBox(top: 0.6832003099680048d,right: 0.8602755603579418d,bottom: 0.49697772801322915d,left: 0.3687278412180185d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5606870786035096d,right: 0.7665701722817678d,bottom: 0.5589479477527899d,left: 0.3963873499624293d),
new NpgsqlTypes.NpgsqlBox(top: 0.36117591941115723d,right: 0.7829923421019073d,bottom: 0.08539764515166981d,left: 0.12456678636345642d),
new NpgsqlTypes.NpgsqlBox(top: 0.44028327703843895d,right: 0.9464801468214427d,bottom: 0.2670357434302516d,left: 0.6451383895033849d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5402147616531825d,right: 0.43065821501149426d,bottom: 0.35815830967578877d,left: 0.14930041155354612d),
new NpgsqlTypes.NpgsqlBox(top: 0.6496200837459073d,right: 0.8171769845998119d,bottom: 0.14774087905777544d,left: 0.7372805754180771d),
new NpgsqlTypes.NpgsqlBox(top: 0.4607747419243182d,right: 0.97019573807575d,bottom: 0.3124101834336105d,left: 0.771573320351176d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8356090713310229d,right: 0.7505365576487069d,bottom: 0.2127432237555279d,left: 0.45752359476174986d),
new NpgsqlTypes.NpgsqlBox(top: 0.5948411925322633d,right: 0.6046050694763563d,bottom: 0.4182350126558798d,left: 0.4402195202456386d),
new NpgsqlTypes.NpgsqlBox(top: 0.20444692054456082d,right: 0.7146781259875586d,bottom: 0.000762914105609136d,left: 0.19062761797114602d),
new NpgsqlTypes.NpgsqlBox(top: 0.9687385939300632d,right: 0.8636944930638301d,bottom: 0.7141728497324884d,left: 0.7514799994432053d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4696759840170288d,right: 0.6897182738409273d,bottom: 0.4312623086372125d,left: 0.07187331029535537d),
new NpgsqlTypes.NpgsqlBox(top: 0.2243952801425687d,right: 0.621241980847094d,bottom: 0.10431889992707855d,left: 0.5530240856173271d),
new NpgsqlTypes.NpgsqlBox(top: 0.716709290024588d,right: 0.969933800424902d,bottom: 0.5136039278746899d,left: 0.5932245691959928d),
new NpgsqlTypes.NpgsqlBox(top: 0.7426198425077053d,right: 0.5757744836025194d,bottom: 0.7038526850737525d,left: 0.4178727487147397d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9896547776052759d,right: 0.9762620794299676d,bottom: 0.2830523456322227d,left: 0.0276071144512956d),
new NpgsqlTypes.NpgsqlBox(top: 0.8733888193219247d,right: 0.916329974135402d,bottom: 0.37764886473209225d,left: 0.19185395015734352d),
new NpgsqlTypes.NpgsqlBox(top: 0.7452157753575837d,right: 0.9814396429322816d,bottom: 0.1717190575374059d,left: 0.9549556117577283d),
new NpgsqlTypes.NpgsqlBox(top: 0.5543705783380536d,right: 0.7253452313312803d,bottom: 0.12034864575965454d,left: 0.187500204834274d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8533341535839752d,right: 0.7670924279627126d,bottom: 0.2657900578385932d,left: 0.5910153833473821d),
new NpgsqlTypes.NpgsqlBox(top: 0.3750852083353525d,right: 0.7948413615177825d,bottom: 0.3529656356568641d,left: 0.3384846355095541d),
new NpgsqlTypes.NpgsqlBox(top: 0.3662996080104086d,right: 0.8543593386424847d,bottom: 0.2117028469201242d,left: 0.41579008945394336d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7769375009705174d,right: 0.9169848203705155d,bottom: 0.4923771282612396d,left: 0.08004494337775392d),
new NpgsqlTypes.NpgsqlBox(top: 0.9443299222735638d,right: 0.9303536840014098d,bottom: 0.7367298063512541d,left: 0.8993052554911675d),
new NpgsqlTypes.NpgsqlBox(top: 0.5284647873827142d,right: 0.728930815884484d,bottom: 0.2126350953452424d,left: 0.35315378856483737d),
new NpgsqlTypes.NpgsqlBox(top: 0.9496099973170254d,right: 0.6216155822080233d,bottom: 0.20903909474836468d,left: 0.23841711837657742d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6944092643158769d,right: 0.8792633263748346d,bottom: 0.40094048490264067d,left: 0.5402700387783291d),
new NpgsqlTypes.NpgsqlBox(top: 0.9468366801355762d,right: 0.7139097498755866d,bottom: 0.4825478558315842d,left: 0.4883530357575182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7796536551458288d,right: 0.8447519828519281d,bottom: 0.4927447457665106d,left: 0.5837225746163666d),
new NpgsqlTypes.NpgsqlBox(top: 0.8441931717355855d,right: 0.8462510120776002d,bottom: 0.5996596270827008d,left: 0.2841794751294483d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8198777471035357d,right: 0.9311075326899141d,bottom: 0.5623791047817925d,left: 0.8382051691858666d),
new NpgsqlTypes.NpgsqlBox(top: 0.5076889418191269d,right: 0.8090196301805348d,bottom: 0.36202365420298843d,left: 0.24261371546249177d),
new NpgsqlTypes.NpgsqlBox(top: 0.7353235042355513d,right: 0.8924430740313489d,bottom: 0.6791058775591557d,left: 0.454763040503639d),
new NpgsqlTypes.NpgsqlBox(top: 0.9634742491690813d,right: 0.7009455257805718d,bottom: 0.5800314022829506d,left: 0.5929627543977092d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8781076571113207d,right: 0.9280355332804837d,bottom: 0.23574727350350544d,left: 0.9204234147730023d),
new NpgsqlTypes.NpgsqlBox(top: 0.6531380054609273d,right: 0.7519637041721358d,bottom: 0.032182798123923884d,left: 0.5760903888360259d),
new NpgsqlTypes.NpgsqlBox(top: 0.4775360875050867d,right: 0.8360143429501061d,bottom: 0.2832325078680066d,left: 0.5749967179223483d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6807603157123562d,right: 0.9452876784615706d,bottom: 0.4808481955635099d,left: 0.938425528071145d),
new NpgsqlTypes.NpgsqlBox(top: 0.3663206495810508d,right: 0.7173215551881936d,bottom: 0.28592440279075715d,left: 0.5599218752017304d),
new NpgsqlTypes.NpgsqlBox(top: 0.4850977852698256d,right: 0.8187570778487177d,bottom: 0.16998116807888053d,left: 0.765275733032677d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.39382694648714d,right: 0.6488579467577585d,bottom: 0.3497922594333712d,left: 0.1266992335319992d),
new NpgsqlTypes.NpgsqlBox(top: 0.9247986088556189d,right: 0.12376256250436357d,bottom: 0.3632453462559434d,left: 0.10969340116175408d),
new NpgsqlTypes.NpgsqlBox(top: 0.9362340698304299d,right: 0.7388030055218361d,bottom: 0.3096495946054397d,left: 0.5137309112360092d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5175219835753064d,right: 0.9984725351118241d,bottom: 0.4619934943562577d,left: 0.0212315475606909d),
new NpgsqlTypes.NpgsqlBox(top: 0.37455417697700044d,right: 0.7323334018062224d,bottom: 0.04510647212241792d,left: 0.17465193586944716d),
new NpgsqlTypes.NpgsqlBox(top: 0.8315815311823057d,right: 0.9394380513526921d,bottom: 0.6952372108154654d,left: 0.1369739949355171d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42959053608059516d,right: 0.6878748787094361d,bottom: 0.13360881457109663d,left: 0.03606278107719074d),
new NpgsqlTypes.NpgsqlBox(top: 0.9921828662888865d,right: 0.9577758243307325d,bottom: 0.1016022387842983d,left: 0.7166664108886409d),
new NpgsqlTypes.NpgsqlBox(top: 0.7569475835451479d,right: 0.5594446857236508d,bottom: 0.2208094923174656d,left: 0.034864663589838196d),
new NpgsqlTypes.NpgsqlBox(top: 0.675066419399328d,right: 0.4514157279733736d,bottom: 0.35150864096350976d,left: 0.4149897758257698d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6213002612689107d,right: 0.13528187093097466d,bottom: 0.6047290047947101d,left: 0.10622848301544219d),
new NpgsqlTypes.NpgsqlBox(top: 0.7179323077121723d,right: 0.9016524953577186d,bottom: 0.7011263269680362d,left: 0.31153017465791444d),
new NpgsqlTypes.NpgsqlBox(top: 0.2290688716770557d,right: 0.3914435175363359d,bottom: 0.1292106656931552d,left: 0.294457095100469d),
new NpgsqlTypes.NpgsqlBox(top: 0.7803126542282625d,right: 0.4967864229536725d,bottom: 0.6241562161345855d,left: 0.27221553406613097d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8898529818435991d,right: 0.5703811448052598d,bottom: 0.3308729200844148d,left: 0.13226821246839904d),
new NpgsqlTypes.NpgsqlBox(top: 0.8287998695985216d,right: 0.4307401977012729d,bottom: 0.3813519139715711d,left: 0.21990887923935998d),
new NpgsqlTypes.NpgsqlBox(top: 0.2751391452573919d,right: 0.7009858922482438d,bottom: 0.08169588456095744d,left: 0.6697420116894405d),
new NpgsqlTypes.NpgsqlBox(top: 0.7054949426532241d,right: 0.8168261049103124d,bottom: 0.3715024345599143d,left: 0.7456533564057001d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5619223917449391d,right: 0.1771227461612731d,bottom: 0.3478128084491917d,left: 0.14786244742854304d),
new NpgsqlTypes.NpgsqlBox(top: 0.04315660919259057d,right: 0.9467699683566083d,bottom: 0.02480708480285765d,left: 0.6217758625120565d),
new NpgsqlTypes.NpgsqlBox(top: 0.636893686118186d,right: 0.7321880921321955d,bottom: 0.5190479242197389d,left: 0.4818481837228241d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9951617511647118d,right: 0.397527299979073d,bottom: 0.001326808092306453d,left: 0.03933123996561816d),
new NpgsqlTypes.NpgsqlBox(top: 0.6232416607853446d,right: 0.244427132049035d,bottom: 0.11024992117655996d,left: 0.06243258694514808d),
new NpgsqlTypes.NpgsqlBox(top: 0.6868461778688758d,right: 0.8800954274414917d,bottom: 0.1955115830359252d,left: 0.6067264370455779d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.656102297998642d,right: 0.803973796374512d,bottom: 0.4107144370221546d,left: 0.6738057634360379d),
new NpgsqlTypes.NpgsqlBox(top: 0.6682566720073045d,right: 0.2974956616384675d,bottom: 0.3266415390194738d,left: 0.22159879891679746d),
new NpgsqlTypes.NpgsqlBox(top: 0.1882586382574586d,right: 0.644136437965636d,bottom: 0.10381941316591503d,left: 0.6289307514931067d),
new NpgsqlTypes.NpgsqlBox(top: 0.5857174990853167d,right: 0.4508717478088683d,bottom: 0.5128105376060746d,left: 0.13038229415253844d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27561095477794184d,right: 0.8222829726353051d,bottom: 0.14743411373894666d,left: 0.010484431686118345d),
new NpgsqlTypes.NpgsqlBox(top: 0.8839931807860515d,right: 0.8976234115517966d,bottom: 0.35101822114053394d,left: 0.06555471712435978d),
new NpgsqlTypes.NpgsqlBox(top: 0.8015009405066247d,right: 0.04403128180033833d,bottom: 0.17700358829845575d,left: 0.028077383333624306d),
new NpgsqlTypes.NpgsqlBox(top: 0.4152238801553104d,right: 0.8731677363260424d,bottom: 0.1510637007266422d,left: 0.12112021826511365d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.39674926599092786d,right: 0.22735532935822855d,bottom: 0.325822829475128d,left: 0.15662170324981362d),
new NpgsqlTypes.NpgsqlBox(top: 0.8765691119340597d,right: 0.9383224988611799d,bottom: 0.5794287695735312d,left: 0.06992306554264027d),
new NpgsqlTypes.NpgsqlBox(top: 0.833711157003735d,right: 0.8801230455955488d,bottom: 0.08795825983682459d,left: 0.10311515362691681d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.537749126724962d,right: 0.8591322774018127d,bottom: 0.4388478117146215d,left: 0.696942019773798d),
new NpgsqlTypes.NpgsqlBox(top: 0.8502820077261678d,right: 0.5037974358275897d,bottom: 0.30243411250733154d,left: 0.21617806024350916d),
new NpgsqlTypes.NpgsqlBox(top: 0.9878909421199752d,right: 0.6316292181435906d,bottom: 0.49107782006513745d,left: 0.599974268126557d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8491121990636133d,right: 0.8367869476373372d,bottom: 0.7276604621333987d,left: 0.6928926220409279d),
new NpgsqlTypes.NpgsqlBox(top: 0.9532496696396796d,right: 0.6622439445102237d,bottom: 0.19058994549570096d,left: 0.18610306139184252d),
new NpgsqlTypes.NpgsqlBox(top: 0.8091430241453177d,right: 0.3247344163549396d,bottom: 0.09173322168452103d,left: 0.14048862231639625d),
new NpgsqlTypes.NpgsqlBox(top: 0.6129541382112733d,right: 0.5572376693773492d,bottom: 0.14588056737292754d,left: 0.4497089512902749d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.919610959060958d,right: 0.42966053030827256d,bottom: 0.3813592006427694d,left: 0.14152340537017882d),
new NpgsqlTypes.NpgsqlBox(top: 0.21350725261097303d,right: 0.42932312083231516d,bottom: 0.17246368814619895d,left: 0.33614902598713325d),
new NpgsqlTypes.NpgsqlBox(top: 0.5377670643451226d,right: 0.995631234086945d,bottom: 0.4872228682203287d,left: 0.5947894440971511d),
new NpgsqlTypes.NpgsqlBox(top: 0.767191542863838d,right: 0.7674750341886908d,bottom: 0.6133872467475797d,left: 0.5824611344995364d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45705407716095703d,right: 0.6988911920443326d,bottom: 0.19103848616105867d,left: 0.08351610799066267d),
new NpgsqlTypes.NpgsqlBox(top: 0.602955484562598d,right: 0.7133719568014607d,bottom: 0.10511685507606094d,left: 0.6810685275449607d),
new NpgsqlTypes.NpgsqlBox(top: 0.8457501829684986d,right: 0.9819366642482404d,bottom: 0.00931793624477606d,left: 0.26417737347981984d),
new NpgsqlTypes.NpgsqlBox(top: 0.155712859184299d,right: 0.9032516511181528d,bottom: 0.13541273319534308d,left: 0.11518829063151292d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8611799873386415d,right: 0.7576749946971201d,bottom: 0.06124948458430224d,left: 0.7146808367728454d),
new NpgsqlTypes.NpgsqlBox(top: 0.4706273550872583d,right: 0.6192452285475878d,bottom: 0.12113329372715398d,left: 0.4551787554864257d),
new NpgsqlTypes.NpgsqlBox(top: 0.8653008269053121d,right: 0.5470572199344452d,bottom: 0.5163175522884046d,left: 0.2292379427566389d),
new NpgsqlTypes.NpgsqlBox(top: 0.8007932140400821d,right: 0.8921384876644615d,bottom: 0.37703368639236323d,left: 0.2911758658917589d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7081002313782973d,right: 0.9233308711336523d,bottom: 0.022605390567685624d,left: 0.2811000515411136d),
new NpgsqlTypes.NpgsqlBox(top: 0.752380084199944d,right: 0.47563247585264645d,bottom: 0.4636507443232334d,left: 0.44937424041870966d),
new NpgsqlTypes.NpgsqlBox(top: 0.9221871900650144d,right: 0.2935021197040616d,bottom: 0.5296759495243262d,left: 0.2859015567710017d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7508921508642359d,right: 0.421660905605037d,bottom: 0.052766816706785735d,left: 0.1745297589115985d),
new NpgsqlTypes.NpgsqlBox(top: 0.4839814893533263d,right: 0.6238391418217354d,bottom: 0.18303329003662383d,left: 0.10987844072283526d),
new NpgsqlTypes.NpgsqlBox(top: 0.4668651665064244d,right: 0.44414621121506725d,bottom: 0.27591956601883405d,left: 0.07366706825939695d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8638180157769645d,right: 0.8894420284490477d,bottom: 0.537698721282726d,left: 0.7358741353429846d),
new NpgsqlTypes.NpgsqlBox(top: 0.9163311168047116d,right: 0.8487746561758516d,bottom: 0.1666047956832386d,left: 0.011197177965609706d),
new NpgsqlTypes.NpgsqlBox(top: 0.4326563351532996d,right: 0.9872263233256002d,bottom: 0.089275052531815d,left: 0.5833818799659036d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6653153589333669d,right: 0.3776250851062328d,bottom: 0.10194253782111806d,left: 0.08852708502047124d),
new NpgsqlTypes.NpgsqlBox(top: 0.8285203184942804d,right: 0.897266001746131d,bottom: 0.32239401597955486d,left: 0.7331491723790857d),
new NpgsqlTypes.NpgsqlBox(top: 0.8723136525495038d,right: 0.19750242173022703d,bottom: 0.6964251240689292d,left: 0.08113793815711923d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9200319837646365d,right: 0.9160364765348915d,bottom: 0.6033978355908574d,left: 0.6496001057910376d),
new NpgsqlTypes.NpgsqlBox(top: 0.8633710408916377d,right: 0.9449567633318993d,bottom: 0.0731039162577849d,left: 0.582018300544739d),
new NpgsqlTypes.NpgsqlBox(top: 0.6041252485561153d,right: 0.4007672635031101d,bottom: 0.4769185177062968d,left: 0.12817358975375548d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9171998581426916d,right: 0.7524737420838009d,bottom: 0.4385981375132141d,left: 0.3500987775572102d),
new NpgsqlTypes.NpgsqlBox(top: 0.8128750885838948d,right: 0.4690374522362143d,bottom: 0.7964192388126905d,left: 0.14892707083498058d),
new NpgsqlTypes.NpgsqlBox(top: 0.2975702024907466d,right: 0.7209732110729843d,bottom: 0.21027193588843496d,left: 0.5192660218404771d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30131609684139804d,right: 0.26427777335403724d,bottom: 0.06693252563126206d,left: 0.0672253987000545d),
new NpgsqlTypes.NpgsqlBox(top: 0.8196981930991436d,right: 0.12702056653061355d,bottom: 0.6363485361442819d,left: 0.09864620488940534d),
new NpgsqlTypes.NpgsqlBox(top: 0.7718353063468939d,right: 0.6630498375291534d,bottom: 0.48666045593573526d,left: 0.3657460498833387d),
new NpgsqlTypes.NpgsqlBox(top: 0.8245587459997132d,right: 0.6739070511815979d,bottom: 0.14206105533716207d,left: 0.024071620336495236d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5858211915208066d,right: 0.3944468145009289d,bottom: 0.29347754499434164d,left: 0.3529608043928243d),
new NpgsqlTypes.NpgsqlBox(top: 0.2557254542629471d,right: 0.9541043315399516d,bottom: 0.18225615068065293d,left: 0.3201821516191432d),
new NpgsqlTypes.NpgsqlBox(top: 0.5843542443214589d,right: 0.9312056430372863d,bottom: 0.4829276767798165d,left: 0.10634226522161305d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8377348358312015d,right: 0.5388141994247091d,bottom: 0.04909515266500453d,left: 0.2412842503371635d),
new NpgsqlTypes.NpgsqlBox(top: 0.3873507593635337d,right: 0.8175090095626806d,bottom: 0.24808222238260602d,left: 0.7380659270721789d),
new NpgsqlTypes.NpgsqlBox(top: 0.8672278112329715d,right: 0.31393798446265475d,bottom: 0.508699616974814d,left: 0.061527204206983876d),
new NpgsqlTypes.NpgsqlBox(top: 0.4445886577810615d,right: 0.7809340064828257d,bottom: 0.3071384361919063d,left: 0.1592784410434116d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6528098716278398d,right: 0.4551322145750668d,bottom: 0.6421857662639172d,left: 0.24042589991776908d),
new NpgsqlTypes.NpgsqlBox(top: 0.35040750842474877d,right: 0.792290691588459d,bottom: 0.19936876865477227d,left: 0.6694637257229904d),
new NpgsqlTypes.NpgsqlBox(top: 0.3008165333530429d,right: 0.9115930424924941d,bottom: 0.012240415133923821d,left: 0.17035376087948273d),
new NpgsqlTypes.NpgsqlBox(top: 0.7004481597100205d,right: 0.48401309125631076d,bottom: 0.02535857903304861d,left: 0.04294670465703476d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7307366778141843d,right: 0.9253745791947282d,bottom: 0.4651441396103623d,left: 0.5079384359135382d),
new NpgsqlTypes.NpgsqlBox(top: 0.5962322337947233d,right: 0.4592385817097866d,bottom: 0.1505519252336286d,left: 0.31421364300449506d),
new NpgsqlTypes.NpgsqlBox(top: 0.8644298902069466d,right: 0.6678217129313516d,bottom: 0.707723532584875d,left: 0.6040561314931117d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6724907730258076d,right: 0.5144868602288613d,bottom: 0.08458472583930488d,left: 0.26710991685110397d),
new NpgsqlTypes.NpgsqlBox(top: 0.4500205428977977d,right: 0.9458708791220376d,bottom: 0.25720732069198826d,left: 0.8342806028071044d),
new NpgsqlTypes.NpgsqlBox(top: 0.6623880362836001d,right: 0.8994626982365379d,bottom: 0.07131537601008875d,left: 0.16104462249220552d),
new NpgsqlTypes.NpgsqlBox(top: 0.5900468425439351d,right: 0.4932049008103758d,bottom: 0.48014291665671616d,left: 0.26620214109325024d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6887817327517359d,right: 0.9450995535943197d,bottom: 0.4477442631258738d,left: 0.04588630607463784d),
new NpgsqlTypes.NpgsqlBox(top: 0.27832118175328147d,right: 0.7072852357892765d,bottom: 0.19477558893638758d,left: 0.41523577229382647d),
new NpgsqlTypes.NpgsqlBox(top: 0.8617500659400428d,right: 0.8288138460524322d,bottom: 0.49732049390410393d,left: 0.38681126171960334d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.339778586235265d,right: 0.23658535903892552d,bottom: 0.3187243901648623d,left: 0.050406126519007555d),
new NpgsqlTypes.NpgsqlBox(top: 0.7638970304076622d,right: 0.4404082884794409d,bottom: 0.5514718553393924d,left: 0.20750774442529907d),
new NpgsqlTypes.NpgsqlBox(top: 0.6599174000443301d,right: 0.6733399018579229d,bottom: 0.4033806942021593d,left: 0.6069231409737583d),
new NpgsqlTypes.NpgsqlBox(top: 0.659708643551554d,right: 0.8649076483936061d,bottom: 0.14903083570007436d,left: 0.29869887288421304d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8767460850411648d,right: 0.5166496176847d,bottom: 0.22687885596749435d,left: 0.17801552774618856d),
new NpgsqlTypes.NpgsqlBox(top: 0.8743905703459746d,right: 0.7917975802635431d,bottom: 0.7113433370253329d,left: 0.010965645020247106d),
new NpgsqlTypes.NpgsqlBox(top: 0.8080751398951352d,right: 0.8768194377776567d,bottom: 0.7160831484230089d,left: 0.3752735971511987d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9646869899346554d,right: 0.8158928317820385d,bottom: 0.4540248448033062d,left: 0.2133053648353448d),
new NpgsqlTypes.NpgsqlBox(top: 0.9554129412303232d,right: 0.9077465960512042d,bottom: 0.08098601699507513d,left: 0.07476202487674133d),
new NpgsqlTypes.NpgsqlBox(top: 0.5495422536603344d,right: 0.8998502807326022d,bottom: 0.27667283134360565d,left: 0.1504157731216499d),
new NpgsqlTypes.NpgsqlBox(top: 0.4765533486038487d,right: 0.7334932487993817d,bottom: 0.26250071134299735d,left: 0.416511259418639d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19810651227528608d,right: 0.7721961284069414d,bottom: 0.12130239070491555d,left: 0.3367959880174791d),
new NpgsqlTypes.NpgsqlBox(top: 0.8197427984615837d,right: 0.45314129656426516d,bottom: 0.6352841844232725d,left: 0.3539172941814157d),
new NpgsqlTypes.NpgsqlBox(top: 0.8700273711053325d,right: 0.6544962312407399d,bottom: 0.09580094793605598d,left: 0.6090641063277977d),
new NpgsqlTypes.NpgsqlBox(top: 0.4734387334610184d,right: 0.7962086965897445d,bottom: 0.16328372710976113d,left: 0.3040475563143137d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8292165031780668d,right: 0.7889361129374368d,bottom: 0.223554458768344d,left: 0.5376303469141159d),
new NpgsqlTypes.NpgsqlBox(top: 0.921818155958807d,right: 0.41296455123745457d,bottom: 0.471772720804148d,left: 0.2310979591554314d),
new NpgsqlTypes.NpgsqlBox(top: 0.4729760223661861d,right: 0.6342660422509876d,bottom: 0.2110955959010713d,left: 0.24975212207252184d),
new NpgsqlTypes.NpgsqlBox(top: 0.8834687325212266d,right: 0.7467472068743646d,bottom: 0.5109805804389594d,left: 0.04783049285667984d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9525341722354649d,right: 0.9645184225674959d,bottom: 0.5836763096833257d,left: 0.838475925762101d),
new NpgsqlTypes.NpgsqlBox(top: 0.7913689562947934d,right: 0.8682909833915159d,bottom: 0.4716033884578815d,left: 0.11653259495295709d),
new NpgsqlTypes.NpgsqlBox(top: 0.6478410616917614d,right: 0.6205314900769698d,bottom: 0.2993318075885154d,left: 0.09048519771236863d),
new NpgsqlTypes.NpgsqlBox(top: 0.507538562517111d,right: 0.40801054835126316d,bottom: 0.36834447514738267d,left: 0.09651852319276832d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5673788405500599d,right: 0.922302038767817d,bottom: 0.1385606599768051d,left: 0.7135702452398366d),
new NpgsqlTypes.NpgsqlBox(top: 0.9073031985721197d,right: 0.6225628756411834d,bottom: 0.8603330323991673d,left: 0.22377291742167305d),
new NpgsqlTypes.NpgsqlBox(top: 0.3288003915037456d,right: 0.30543489951920466d,bottom: 0.08971799277391335d,left: 0.258509322125019d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1875823601256721d,right: 0.8468100875102541d,bottom: 0.048395615786759105d,left: 0.518705277062041d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792436013746103d,right: 0.7983955601196678d,bottom: 0.44860002736585924d,left: 0.37240786818354765d),
new NpgsqlTypes.NpgsqlBox(top: 0.5623721493049062d,right: 0.7416027585874668d,bottom: 0.3833107197222517d,left: 0.1927410227111157d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2226626739844464d,right: 0.5565021916854754d,bottom: 0.21230609064128514d,left: 0.13549024333903248d),
new NpgsqlTypes.NpgsqlBox(top: 0.4606617916179905d,right: 0.8588637957072669d,bottom: 0.2905821560438211d,left: 0.47866352818903035d),
new NpgsqlTypes.NpgsqlBox(top: 0.9095333979332381d,right: 0.6775855434408786d,bottom: 0.19921596358564164d,left: 0.05323011877680006d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.580626792595908d,right: 0.3302797690650523d,bottom: 0.1965451286043517d,left: 0.2978222766577151d),
new NpgsqlTypes.NpgsqlBox(top: 0.596955740222886d,right: 0.9657290862112482d,bottom: 0.16095922508612115d,left: 0.6248451895650453d),
new NpgsqlTypes.NpgsqlBox(top: 0.36828697189220516d,right: 0.2676958993323443d,bottom: 0.0032140223529798506d,left: 0.12480632475846831d),
new NpgsqlTypes.NpgsqlBox(top: 0.2815763804435347d,right: 0.9191461572277017d,bottom: 0.016975760683299757d,left: 0.8186213682353486d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8991529786730339d,right: 0.31004692229568354d,bottom: 0.10772769976000507d,left: 0.14938779522634194d),
new NpgsqlTypes.NpgsqlBox(top: 0.06446426341000189d,right: 0.6187182889789644d,bottom: 0.04241843691637137d,left: 0.5184415318945916d),
new NpgsqlTypes.NpgsqlBox(top: 0.849268927702632d,right: 0.5384152941190934d,bottom: 0.715857438322783d,left: 0.444137101795547d),
new NpgsqlTypes.NpgsqlBox(top: 0.5206188935345681d,right: 0.8544516313163407d,bottom: 0.37797155341764677d,left: 0.07818162594436928d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9265763758742713d,right: 0.8787057077772422d,bottom: 0.25354923799832974d,left: 0.1385279107670957d),
new NpgsqlTypes.NpgsqlBox(top: 0.2765558331285728d,right: 0.8587646897201892d,bottom: 0.2742520008564864d,left: 0.6246934627553056d),
new NpgsqlTypes.NpgsqlBox(top: 0.9443519741852971d,right: 0.27914932244899404d,bottom: 0.04963660818538451d,left: 0.15489339618444842d),
new NpgsqlTypes.NpgsqlBox(top: 0.862093956381048d,right: 0.7801194078360804d,bottom: 0.6406834748499528d,left: 0.027008437032879473d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8203501463975519d,right: 0.7309404150556438d,bottom: 0.3653899720762087d,left: 0.22780800536087797d),
new NpgsqlTypes.NpgsqlBox(top: 0.9070732117457437d,right: 0.7894422126129466d,bottom: 0.41614766105324563d,left: 0.5985811457470291d),
new NpgsqlTypes.NpgsqlBox(top: 0.5066208562437223d,right: 0.6342318098842512d,bottom: 0.05571159598051467d,left: 0.24110073932011433d),
new NpgsqlTypes.NpgsqlBox(top: 0.22493732762407515d,right: 0.44667861812839194d,bottom: 0.1683076997316486d,left: 0.27082425782688757d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4846947654091518d,right: 0.8935868078557082d,bottom: 0.40316224786598764d,left: 0.34309068872856463d),
new NpgsqlTypes.NpgsqlBox(top: 0.9796874707380842d,right: 0.46162511480147994d,bottom: 0.6544652484774663d,left: 0.12633636173500062d),
new NpgsqlTypes.NpgsqlBox(top: 0.6893420084190188d,right: 0.8349982800072009d,bottom: 0.04104517675255548d,left: 0.1089629119390847d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7678016914109741d,right: 0.8499185595972987d,bottom: 0.7356905922766639d,left: 0.06398983137417613d),
new NpgsqlTypes.NpgsqlBox(top: 0.5324084980351561d,right: 0.8994831520934004d,bottom: 0.023331336669971003d,left: 0.2999307540186097d),
new NpgsqlTypes.NpgsqlBox(top: 0.611182987994107d,right: 0.03777284045978202d,bottom: 0.04493117426180637d,left: 0.025146949637531724d),
new NpgsqlTypes.NpgsqlBox(top: 0.27266669431141677d,right: 0.863752285932777d,bottom: 0.12986514638876057d,left: 0.5822140395262276d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9987350125061175d,right: 0.6415842659171455d,bottom: 0.8030674073763807d,left: 0.5248261100229276d),
new NpgsqlTypes.NpgsqlBox(top: 0.6109152162452981d,right: 0.9513910216444553d,bottom: 0.1578055526055434d,left: 0.9059805647982321d),
new NpgsqlTypes.NpgsqlBox(top: 0.9980937216947542d,right: 0.9380061057848504d,bottom: 0.928552778778448d,left: 0.5919835610808931d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8662540102254284d,right: 0.9618454681787589d,bottom: 0.17089373686212672d,left: 0.5763448211559951d),
new NpgsqlTypes.NpgsqlBox(top: 0.9821872186399705d,right: 0.9843992011334278d,bottom: 0.4113648972342646d,left: 0.5865845778229584d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464599395408151d,right: 0.42629256068790566d,bottom: 0.049447349004548835d,left: 0.312781686453356d),
new NpgsqlTypes.NpgsqlBox(top: 0.8807144095984246d,right: 0.7419215900054975d,bottom: 0.05363632807181118d,left: 0.02108654468589588d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9322782137808162d,right: 0.7124836950306058d,bottom: 0.6684455696611511d,left: 0.5419448231888159d),
new NpgsqlTypes.NpgsqlBox(top: 0.35710204214533536d,right: 0.6544815379157787d,bottom: 0.3393260723924362d,left: 0.42533864605677874d),
new NpgsqlTypes.NpgsqlBox(top: 0.879715800321651d,right: 0.47578562690680504d,bottom: 0.8384778405904751d,left: 0.36566416678630553d),
new NpgsqlTypes.NpgsqlBox(top: 0.3534379701531294d,right: 0.6987880280866304d,bottom: 0.062221915502349345d,left: 0.36623685491636826d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4701515085736483d,right: 0.4270382286273444d,bottom: 0.4653205463202107d,left: 0.2917933522188395d),
new NpgsqlTypes.NpgsqlBox(top: 0.7055120506474128d,right: 0.8838636400088797d,bottom: 0.3685573233103284d,left: 0.6151655467060907d),
new NpgsqlTypes.NpgsqlBox(top: 0.5457962614667399d,right: 0.6420293812031899d,bottom: 0.47611973656318274d,left: 0.2058004500570444d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7385351149511558d,right: 0.4472317915556784d,bottom: 0.6712996963799713d,left: 0.26376952125761677d),
new NpgsqlTypes.NpgsqlBox(top: 0.08066211504771004d,right: 0.4611964623043737d,bottom: 0.016037727974587024d,left: 0.2855927466961887d),
new NpgsqlTypes.NpgsqlBox(top: 0.6646427657671841d,right: 0.9194360674857885d,bottom: 0.611257437516054d,left: 0.09226541475020278d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9534274382852909d,right: 0.926425441091829d,bottom: 0.5213890600541841d,left: 0.8415073458916837d),
new NpgsqlTypes.NpgsqlBox(top: 0.7509029303847045d,right: 0.2858057451076661d,bottom: 0.11266393677931641d,left: 0.16978861131215828d),
new NpgsqlTypes.NpgsqlBox(top: 0.7916301340819107d,right: 0.9039450997329282d,bottom: 0.4331052546084857d,left: 0.08596402857935792d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8400879137207554d,right: 0.6202227850477678d,bottom: 0.7173504309354545d,left: 0.16444531864137146d),
new NpgsqlTypes.NpgsqlBox(top: 0.9482494587199154d,right: 0.9366150475720609d,bottom: 0.7342555012566079d,left: 0.36296448964907535d),
new NpgsqlTypes.NpgsqlBox(top: 0.8012331273048577d,right: 0.9849519078535852d,bottom: 0.6583728411323034d,left: 0.23795470907943517d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7156137730660084d,right: 0.7467447041970087d,bottom: 0.2636103365289576d,left: 0.7064892128046277d),
new NpgsqlTypes.NpgsqlBox(top: 0.8030122300865827d,right: 0.8582656590590194d,bottom: 0.5792818036913518d,left: 0.7638630758954039d),
new NpgsqlTypes.NpgsqlBox(top: 0.7721807065749055d,right: 0.7160000899815981d,bottom: 0.4220548607253274d,left: 0.02716222035214999d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27660013071150014d,right: 0.651793884567574d,bottom: 0.08995321975829373d,left: 0.17829950391221405d),
new NpgsqlTypes.NpgsqlBox(top: 0.4097590439042187d,right: 0.7882265134612498d,bottom: 0.1599895076516722d,left: 0.1651092963232702d),
new NpgsqlTypes.NpgsqlBox(top: 0.6315091421236424d,right: 0.614519229554377d,bottom: 0.20010920975477853d,left: 0.19833431549921599d),
new NpgsqlTypes.NpgsqlBox(top: 0.7365414822346887d,right: 0.3991189567284906d,bottom: 0.33589681851528086d,left: 0.02611241686429433d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43133006712363d,right: 0.8477439502050047d,bottom: 0.0071687105088166225d,left: 0.558613344650267d),
new NpgsqlTypes.NpgsqlBox(top: 0.5621555855268893d,right: 0.5800790552407744d,bottom: 0.3579994693566736d,left: 0.5430737720989203d),
new NpgsqlTypes.NpgsqlBox(top: 0.6400406827974875d,right: 0.8815916124144613d,bottom: 0.10272176568515956d,left: 0.8570713566265937d),
new NpgsqlTypes.NpgsqlBox(top: 0.3675690745985317d,right: 0.8408910374154216d,bottom: 0.32515662395922595d,left: 0.20931642673938677d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15146334068301115d,right: 0.8695736631973557d,bottom: 0.059917168804711984d,left: 0.7669495481626218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7893299475588967d,right: 0.5992894919982136d,bottom: 0.6784680979979848d,left: 0.11413249897513178d),
new NpgsqlTypes.NpgsqlBox(top: 0.7095373938768196d,right: 0.7800483836004183d,bottom: 0.4199401064748164d,left: 0.45507999317074677d),
new NpgsqlTypes.NpgsqlBox(top: 0.8888808874385639d,right: 0.9354625303128256d,bottom: 0.15024269009366564d,left: 0.832394782487577d),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6944092643158769d,right: 0.8792633263748346d,bottom: 0.40094048490264067d,left: 0.5402700387783291d),
new NpgsqlTypes.NpgsqlBox(top: 0.9468366801355762d,right: 0.7139097498755866d,bottom: 0.4825478558315842d,left: 0.4883530357575182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7796536551458288d,right: 0.8447519828519281d,bottom: 0.4927447457665106d,left: 0.5837225746163666d),
new NpgsqlTypes.NpgsqlBox(top: 0.8441931717355855d,right: 0.8462510120776002d,bottom: 0.5996596270827008d,left: 0.2841794751294483d),
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
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 123, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 42, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 146, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 109, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

