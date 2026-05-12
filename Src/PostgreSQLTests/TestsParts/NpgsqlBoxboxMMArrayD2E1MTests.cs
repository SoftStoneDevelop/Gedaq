

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9922232632810999d,right: 0.6204673594771043d,bottom: 0.9469315535257322d,left: 0.5680121499123004d), new NpgsqlTypes.NpgsqlBox(top: 0.9419701026162846d,right: 0.7041113853043266d,bottom: 0.4001900502166278d,left: 0.04337762324797634d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9314867262627895d,right: 0.6796111307351571d,bottom: 0.28414505898998677d,left: 0.6070402064849176d), new NpgsqlTypes.NpgsqlBox(top: 0.993630845712392d,right: 0.0579027857707608d,bottom: 0.4923773525024765d,left: 0.01994927435362215d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8605902371930021d,right: 0.9520234769864081d,bottom: 0.16425278850592795d,left: 0.8391680141238019d), new NpgsqlTypes.NpgsqlBox(top: 0.4813232479416729d,right: 0.9250964584032493d,bottom: 0.12333584981820556d,left: 0.05928325809607882d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5460708042168047d,right: 0.6099638684998414d,bottom: 0.31399759639354274d,left: 0.41067705079617056d), new NpgsqlTypes.NpgsqlBox(top: 0.5433959660277852d,right: 0.4491725074051811d,bottom: 0.38565943871994146d,left: 0.1580287389895022d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9536909395778901d,right: 0.9134399907193319d,bottom: 0.041087807105649854d,left: 0.5267965785188334d), new NpgsqlTypes.NpgsqlBox(top: 0.5762775155203216d,right: 0.7810299240271426d,bottom: 0.1752883279181161d,left: 0.01542144308424831d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6637785902472345d,right: 0.33131896971568675d,bottom: 0.32374854568781586d,left: 0.20860046315028835d), new NpgsqlTypes.NpgsqlBox(top: 0.4583101472190996d,right: 0.6290925841036726d,bottom: 0.3654986911951227d,left: 0.06369662002815979d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3154350653916407d,right: 0.7376710078695108d,bottom: 0.13184852410764936d,left: 0.45258697379745694d), new NpgsqlTypes.NpgsqlBox(top: 0.7061127843266947d,right: 0.9116834363394726d,bottom: 0.6091937195453719d,left: 0.7492276326177106d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7432347469143361d,right: 0.1998561088757278d,bottom: 0.2688275535448481d,left: 0.03504612187852596d), new NpgsqlTypes.NpgsqlBox(top: 0.812249573319093d,right: 0.5913391957745375d,bottom: 0.27738801798291157d,left: 0.5802690926064238d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5422492064079696d,right: 0.662257352272582d,bottom: 0.14161636155032764d,left: 0.11934626081080302d), new NpgsqlTypes.NpgsqlBox(top: 0.11628832219648166d,right: 0.8159213948970693d,bottom: 0.009553328560411023d,left: 0.687564554710271d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.839977371547918d,right: 0.5082066179890187d,bottom: 0.7916337431656044d,left: 0.23508400410128383d), new NpgsqlTypes.NpgsqlBox(top: 0.6957028532345156d,right: 0.5995923855001214d,bottom: 0.2487697902333007d,left: 0.4597189325126382d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5441829959781687d,right: 0.9417727639075046d,bottom: 0.4959308775879935d,left: 0.6955504257972501d), new NpgsqlTypes.NpgsqlBox(top: 0.9899758244924725d,right: 0.8910906553414889d,bottom: 0.06982012399839155d,left: 0.468099780298857d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8698494859889717d,right: 0.7250346607988479d,bottom: 0.2202343972612384d,left: 0.467625696471324d), new NpgsqlTypes.NpgsqlBox(top: 0.6307395800102525d,right: 0.2520028934756443d,bottom: 0.5931990538183949d,left: 0.23181875191328316d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7873340311366264d,right: 0.37376124268392263d,bottom: 0.7161437865758287d,left: 0.3236330746268119d), new NpgsqlTypes.NpgsqlBox(top: 0.9461164292125955d,right: 0.8904892669205446d,bottom: 0.14142356333272044d,left: 0.3770617271233615d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3318884191834368d,right: 0.062295492556016185d,bottom: 0.09620929636249265d,left: 0.014801691047857668d), new NpgsqlTypes.NpgsqlBox(top: 0.6208715348207514d,right: 0.5735553996555879d,bottom: 0.15383037337300176d,left: 0.5283193692023915d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4419293010133952d,right: 0.8481632456626556d,bottom: 0.16271988574691887d,left: 0.03297269630620092d), new NpgsqlTypes.NpgsqlBox(top: 0.7248094479416207d,right: 0.7439385963929713d,bottom: 0.03438019754968591d,left: 0.4787176416280059d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7898022904730944d,right: 0.5363288046456588d,bottom: 0.3448149586415715d,left: 0.5235166068908004d), new NpgsqlTypes.NpgsqlBox(top: 0.6934999968919394d,right: 0.19226749258502673d,bottom: 0.5995458011026259d,left: 0.0005676377270922295d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7412793133004764d,right: 0.8097793427430041d,bottom: 0.04316164629175334d,left: 0.04926605414571539d), new NpgsqlTypes.NpgsqlBox(top: 0.8087036605236853d,right: 0.6948898465713015d,bottom: 0.3848968695189873d,left: 0.40743979631348537d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9185842071714834d,right: 0.2785382279627001d,bottom: 0.15418888844074718d,left: 0.1798263419749867d), new NpgsqlTypes.NpgsqlBox(top: 0.8912838985240101d,right: 0.09062623216967369d,bottom: 0.24670873212932076d,left: 0.07753645499063355d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.921955772901619d,right: 0.3858289457748667d,bottom: 0.8910142160663663d,left: 0.03213982103062685d), new NpgsqlTypes.NpgsqlBox(top: 0.9241236220061696d,right: 0.3291731071501093d,bottom: 0.5980872683123667d,left: 0.04828471238261356d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9090234418131774d,right: 0.6083151620847288d,bottom: 0.03105692340287003d,left: 0.547860429610607d), new NpgsqlTypes.NpgsqlBox(top: 0.7276334334819926d,right: 0.8253048584562176d,bottom: 0.5167462703649952d,left: 0.013484756014523147d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.747343567150176d,right: 0.8835263540692647d,bottom: 0.65734607048897d,left: 0.26681169105891855d), new NpgsqlTypes.NpgsqlBox(top: 0.9173054481666434d,right: 0.20304990356359887d,bottom: 0.8685130555366708d,left: 0.038907351397224454d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9521319701646115d,right: 0.8325983208654646d,bottom: 0.15549345301337347d,left: 0.8294163121485306d), new NpgsqlTypes.NpgsqlBox(top: 0.41201233221871725d,right: 0.1124646197382363d,bottom: 0.1747500222642363d,left: 0.11190354157787274d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.872393579058562d,right: 0.18643797368447323d,bottom: 0.40516444571680854d,left: 0.1298445625638157d), new NpgsqlTypes.NpgsqlBox(top: 0.8539572124060728d,right: 0.8054967517969721d,bottom: 0.17917914613419705d,left: 0.3771830303324132d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7603978202208955d,right: 0.7944381235594064d,bottom: 0.03199601109161332d,left: 0.6517955754240923d), new NpgsqlTypes.NpgsqlBox(top: 0.40411802955935305d,right: 0.7247743592339246d,bottom: 0.1472076120117889d,left: 0.3813100744493767d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6739119514117616d,right: 0.7237412931311933d,bottom: 0.6688213114862245d,left: 0.31146222815919444d), new NpgsqlTypes.NpgsqlBox(top: 0.6980080878773209d,right: 0.9208422884547823d,bottom: 0.31713470326944204d,left: 0.7937736986862539d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6549323944760997d,right: 0.18106811879178653d,bottom: 0.4831936319521041d,left: 0.0026511074873702967d), new NpgsqlTypes.NpgsqlBox(top: 0.36218980188429073d,right: 0.6082497447240643d,bottom: 0.12640305021434584d,left: 0.38303068755151715d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6289521416884175d,right: 0.1988077838559933d,bottom: 0.381657600924342d,left: 0.1866101659103605d), new NpgsqlTypes.NpgsqlBox(top: 0.5179535011013543d,right: 0.719191535224433d,bottom: 0.4914736693264623d,left: 0.5157141036481593d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5582654371074075d,right: 0.543057463977264d,bottom: 0.009542665539503226d,left: 0.5022885987380457d), new NpgsqlTypes.NpgsqlBox(top: 0.3892448244841189d,right: 0.8041733626569402d,bottom: 0.11891266812238133d,left: 0.15044188124745794d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6867067684708614d,right: 0.824214608717284d,bottom: 0.5579180900261559d,left: 0.016490745547264707d), new NpgsqlTypes.NpgsqlBox(top: 0.6683682069455433d,right: 0.7147096252427229d,bottom: 0.07544594806137817d,left: 0.21972068017113267d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5582370879919586d,right: 0.29493599915485014d,bottom: 0.07260676202605565d,left: 0.18631993484873954d), new NpgsqlTypes.NpgsqlBox(top: 0.30240355113385586d,right: 0.6890133713793957d,bottom: 0.07156428278311533d,left: 0.40567475333078407d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7863201363958278d,right: 0.6719326275618387d,bottom: 0.45057339250032735d,left: 0.3160452593887373d), new NpgsqlTypes.NpgsqlBox(top: 0.9645082004004041d,right: 0.7442463309679821d,bottom: 0.47646500736690267d,left: 0.6924733435762254d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4895271301556222d,right: 0.9953738781505251d,bottom: 0.07218393974284532d,left: 0.968520442882793d), new NpgsqlTypes.NpgsqlBox(top: 0.897109969676085d,right: 0.9671639388354561d,bottom: 0.13815080425682857d,left: 0.5739675122848239d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8151937617478813d,right: 0.9499578077776677d,bottom: 0.12433530519523528d,left: 0.5347861993003619d), new NpgsqlTypes.NpgsqlBox(top: 0.7715456285807555d,right: 0.7806298214391705d,bottom: 0.672549840742464d,left: 0.5942929606340807d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.23991668476612116d,right: 0.5663473135576493d,bottom: 0.17367361487477773d,left: 0.41928803683669424d), new NpgsqlTypes.NpgsqlBox(top: 0.49035801688214753d,right: 0.8010268510268682d,bottom: 0.08972057849122916d,left: 0.4516164267510563d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9784491721263946d,right: 0.7107549773424984d,bottom: 0.20714720075838322d,left: 0.20406292301027518d), new NpgsqlTypes.NpgsqlBox(top: 0.655232449618063d,right: 0.9234758583530925d,bottom: 0.3891185840510203d,left: 0.3586011232158419d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6530274043946572d,right: 0.8216559024452964d,bottom: 0.4040925605663207d,left: 0.342205140062279d), new NpgsqlTypes.NpgsqlBox(top: 0.6542914120860502d,right: 0.6373896384462346d,bottom: 0.27625321670376846d,left: 0.10336873247730483d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8325572176269553d,right: 0.27666594063388383d,bottom: 0.6233230493743876d,left: 0.025888200851343246d), new NpgsqlTypes.NpgsqlBox(top: 0.8780802360086797d,right: 0.9598125252835796d,bottom: 0.08140354092830082d,left: 0.9068193714382441d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.515720711574814d,right: 0.9608017750115759d,bottom: 0.4250720444977273d,left: 0.8695211950090477d), new NpgsqlTypes.NpgsqlBox(top: 0.3524188985994784d,right: 0.08189265021977521d,bottom: 0.16428692933424704d,left: 0.06776223429988015d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5353115005629286d,right: 0.17986361384496607d,bottom: 0.08074803556014709d,left: 0.04456712846376765d), new NpgsqlTypes.NpgsqlBox(top: 0.9531777593523787d,right: 0.27961435091551834d,bottom: 0.6402266059408654d,left: 0.2247692910059088d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9038325655032727d,right: 0.3911149667028293d,bottom: 0.7482212688143065d,left: 0.024870779013916655d), new NpgsqlTypes.NpgsqlBox(top: 0.39053691634213017d,right: 0.6957840237099849d,bottom: 0.28231694860630574d,left: 0.30115141051617267d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8944335823058757d,right: 0.5668954670690821d,bottom: 0.7980361272632612d,left: 0.2587600633769702d), new NpgsqlTypes.NpgsqlBox(top: 0.4753205235660046d,right: 0.9484226904598717d,bottom: 0.13431655846388946d,left: 0.44790218040992447d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4421149294775497d,right: 0.9916125541607587d,bottom: 0.35414543552270483d,left: 0.9001315886376668d), new NpgsqlTypes.NpgsqlBox(top: 0.2806256075524971d,right: 0.9258304710000613d,bottom: 0.17928254370651353d,left: 0.06120162415830288d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9030545650649761d,right: 0.597142743224137d,bottom: 0.36800395891882676d,left: 0.40182183092163504d), new NpgsqlTypes.NpgsqlBox(top: 0.9600015170834124d,right: 0.9738204785791928d,bottom: 0.9372411714707892d,left: 0.005164376576031304d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.46583800338559056d,right: 0.7243507835695335d,bottom: 0.20146298654475914d,left: 0.618694811646972d), new NpgsqlTypes.NpgsqlBox(top: 0.2644677147264507d,right: 0.6614460939778397d,bottom: 0.06938243207962314d,left: 0.5561464746442137d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.820425120742099d,right: 0.6704203957890976d,bottom: 0.1662725510662334d,left: 0.04103491473377885d), new NpgsqlTypes.NpgsqlBox(top: 0.5392458674433196d,right: 0.9617332767037399d,bottom: 0.2753852037116751d,left: 0.02811624574029592d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4685477573136092d,right: 0.5627108629449419d,bottom: 0.4490855433969244d,left: 0.28708569866030886d), new NpgsqlTypes.NpgsqlBox(top: 0.5218049945349402d,right: 0.08779024107194089d,bottom: 0.31786067146332597d,left: 0.03068578505220465d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8743487680408671d,right: 0.8649442116630385d,bottom: 0.47331432166779286d,left: 0.61773376900134d), new NpgsqlTypes.NpgsqlBox(top: 0.9515962998899197d,right: 0.3368349851896324d,bottom: 0.8777362188798117d,left: 0.17589837205852255d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9577367751923671d,right: 0.9788671637647829d,bottom: 0.3682003644323214d,left: 0.4491363074211763d), new NpgsqlTypes.NpgsqlBox(top: 0.5942651172306498d,right: 0.8317090639460131d,bottom: 0.564391721300741d,left: 0.5099061660977054d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.35083385759315044d,right: 0.9518388475257549d,bottom: 0.16421531484957175d,left: 0.002453037026167393d), new NpgsqlTypes.NpgsqlBox(top: 0.4693757351379326d,right: 0.3679588553829195d,bottom: 0.023356030207620226d,left: 0.24844406002618014d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.48873013413756783d,right: 0.8827246912409707d,bottom: 0.05832106545980298d,left: 0.3224843332775391d), new NpgsqlTypes.NpgsqlBox(top: 0.7261953369060633d,right: 0.9342387295782947d,bottom: 0.26941466601030284d,left: 0.3304957447843141d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.97920631687859d,right: 0.9528161523324146d,bottom: 0.4832168480360006d,left: 0.8035280870753384d), new NpgsqlTypes.NpgsqlBox(top: 0.36258896306574695d,right: 0.8597559222893142d,bottom: 0.304209720821898d,left: 0.8161838417405299d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8963989393222874d,right: 0.7267142459439726d,bottom: 0.37559816298996995d,left: 0.48812884380169863d), new NpgsqlTypes.NpgsqlBox(top: 0.9702960851081393d,right: 0.5309863077055038d,bottom: 0.45398971316042613d,left: 0.39905718712910654d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.1826597189277157d,right: 0.844264242740513d,bottom: 0.14739595325806387d,left: 0.01206162431576363d), new NpgsqlTypes.NpgsqlBox(top: 0.8890558074835899d,right: 0.7355444954825087d,bottom: 0.7042668166924033d,left: 0.40507085509958163d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7404685076087064d,right: 0.4643153310065764d,bottom: 0.343212807439812d,left: 0.3244604379959416d), new NpgsqlTypes.NpgsqlBox(top: 0.8248918278760041d,right: 0.45792650929368306d,bottom: 0.26037707345905814d,left: 0.20602577610100004d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.1542033105991807d,right: 0.7379905032346147d,bottom: 0.06990941315930899d,left: 0.675564417246046d), new NpgsqlTypes.NpgsqlBox(top: 0.5015937500608961d,right: 0.7236173863569968d,bottom: 0.41444795687307634d,left: 0.7108982746826198d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.796167712894337d,right: 0.4900118518605705d,bottom: 0.024578702442741518d,left: 0.4070742855132914d), new NpgsqlTypes.NpgsqlBox(top: 0.8557253704669266d,right: 0.697033149875275d,bottom: 0.19423294805407532d,left: 0.6212206904023531d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6967922966512531d,right: 0.2265818812472068d,bottom: 0.5442901715259941d,left: 0.19135282999403658d), new NpgsqlTypes.NpgsqlBox(top: 0.7834956540322159d,right: 0.847963017976595d,bottom: 0.377859375055955d,left: 0.5750016734674992d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.973425481701713d,right: 0.6521396587853804d,bottom: 0.1219197781634922d,left: 0.5116968809989211d), new NpgsqlTypes.NpgsqlBox(top: 0.7155646417113407d,right: 0.5766978597027903d,bottom: 0.38711322175105867d,left: 0.5140930572505772d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3380776646978185d,right: 0.8010354312445812d,bottom: 0.3084974527946087d,left: 0.3028808810167307d), new NpgsqlTypes.NpgsqlBox(top: 0.8328259840700999d,right: 0.673821289457037d,bottom: 0.8316463580502856d,left: 0.27641794854726376d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7720150477180641d,right: 0.923193726301621d,bottom: 0.2738269617377971d,left: 0.8550156100301205d), new NpgsqlTypes.NpgsqlBox(top: 0.7806978904901895d,right: 0.3007751327615885d,bottom: 0.5249835830622026d,left: 0.04043883538273718d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7166781909077342d,right: 0.8997723397493566d,bottom: 0.6959696065709811d,left: 0.4298466523878324d), new NpgsqlTypes.NpgsqlBox(top: 0.5565922169154028d,right: 0.6017774472228502d,bottom: 0.18872270447279726d,left: 0.48783416616477615d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5522713844239522d,right: 0.1755267621092358d,bottom: 0.2540866169178436d,left: 0.11527642602822508d), new NpgsqlTypes.NpgsqlBox(top: 0.12764936426143492d,right: 0.40351651960264934d,bottom: 0.054978689030157124d,left: 0.20927422537570883d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9673252491782279d,right: 0.45845817211836604d,bottom: 0.5641993726711774d,left: 0.20234723704925572d), new NpgsqlTypes.NpgsqlBox(top: 0.339486059205261d,right: 0.9092436480258907d,bottom: 0.04675030448819495d,left: 0.7084854119903186d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8107269716463029d,right: 0.8929932663082208d,bottom: 0.4001170432980389d,left: 0.6614367593106099d), new NpgsqlTypes.NpgsqlBox(top: 0.5415930184739107d,right: 0.5700057551007366d,bottom: 0.16920784744666528d,left: 0.060898239858538816d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9522999367766898d,right: 0.884363543016949d,bottom: 0.9011059027138579d,left: 0.0682007020729064d), new NpgsqlTypes.NpgsqlBox(top: 0.6160109772751743d,right: 0.8268778956135366d,bottom: 0.270235650419155d,left: 0.5961212249819932d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.963525522642617d,right: 0.8264316455525492d,bottom: 0.6539697694937668d,left: 0.4280655707653195d), new NpgsqlTypes.NpgsqlBox(top: 0.9232972955098181d,right: 0.8911418965974827d,bottom: 0.8830463160369354d,left: 0.12537195534924994d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8843299850318351d,right: 0.8345132173809084d,bottom: 0.19264552732965745d,left: 0.2494811063323975d), new NpgsqlTypes.NpgsqlBox(top: 0.8933444954146728d,right: 0.41622654321053754d,bottom: 0.20237923610999142d,left: 0.303018039216417d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4544882415325746d,right: 0.6142172770179716d,bottom: 0.4233972049719247d,left: 0.43044843860865534d), new NpgsqlTypes.NpgsqlBox(top: 0.9608386636861513d,right: 0.9760276978986446d,bottom: 0.3352799602258427d,left: 0.0920418416420159d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.17121448930159489d,right: 0.7180457640059287d,bottom: 0.005871689080983233d,left: 0.4604664212780232d), new NpgsqlTypes.NpgsqlBox(top: 0.9732484503048671d,right: 0.86232331282281d,bottom: 0.15040251782515834d,left: 0.7979672733139491d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9554462922613679d,right: 0.30886911956741614d,bottom: 0.8023039602753932d,left: 0.08666922310624481d), new NpgsqlTypes.NpgsqlBox(top: 0.3797408664205877d,right: 0.6679771358244755d,bottom: 0.2647124727762056d,left: 0.6005130475670604d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7078475950665247d,right: 0.5679014721433254d,bottom: 0.2448448114993912d,left: 0.43283714069704016d), new NpgsqlTypes.NpgsqlBox(top: 0.9598145313082781d,right: 0.42481575430870944d,bottom: 0.7761187078774864d,left: 0.2075191357685059d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9817805629462814d,right: 0.9674931590182609d,bottom: 0.8358786687521527d,left: 0.5171655095004066d), new NpgsqlTypes.NpgsqlBox(top: 0.9160956955706776d,right: 0.9215094745650545d,bottom: 0.9015984623357147d,left: 0.593859095997042d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7546681745540879d,right: 0.5892330735491945d,bottom: 0.3549470510221072d,left: 0.5373849887167439d), new NpgsqlTypes.NpgsqlBox(top: 0.8350807465531712d,right: 0.7208855469649423d,bottom: 0.37104847222996873d,left: 0.42016811207424853d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7045100588380363d,right: 0.8265984481222546d,bottom: 0.3065900977486803d,left: 0.29378136603955074d), new NpgsqlTypes.NpgsqlBox(top: 0.9813339388246257d,right: 0.5018794184748513d,bottom: 0.9330366184168356d,left: 0.021921700290371327d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.802120706960319d,right: 0.9605456193816676d,bottom: 0.5588987694159017d,left: 0.2296362211380406d), new NpgsqlTypes.NpgsqlBox(top: 0.8693294549376208d,right: 0.4492279189949483d,bottom: 0.4793677977877653d,left: 0.4116662031498748d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9385783982889518d,right: 0.35444781228382316d,bottom: 0.9280998870633017d,left: 0.1471517467435326d), new NpgsqlTypes.NpgsqlBox(top: 0.9860313916234067d,right: 0.6738617541998634d,bottom: 0.2961199613394526d,left: 0.450527507630488d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.981692851075159d,right: 0.596241494028921d,bottom: 0.6736278860298072d,left: 0.24253684141391307d), new NpgsqlTypes.NpgsqlBox(top: 0.6772668630334189d,right: 0.6157501132225786d,bottom: 0.6118182090405657d,left: 0.22806835391458946d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.1642430014603128d,right: 0.6021743131414043d,bottom: 0.1206844726679166d,left: 0.4404079095851571d), new NpgsqlTypes.NpgsqlBox(top: 0.7836406839628457d,right: 0.6829318442373437d,bottom: 0.44585710695314107d,left: 0.6655945524154523d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4890256858663601d,right: 0.6357813327897545d,bottom: 0.45033075609746476d,left: 0.1417649985418471d), new NpgsqlTypes.NpgsqlBox(top: 0.3068089427519385d,right: 0.03133033185013612d,bottom: 0.2999303845022835d,left: 0.008207759348734744d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.36393359611505327d,right: 0.5892478038863824d,bottom: 0.0013770915753260615d,left: 0.1597211858673806d), new NpgsqlTypes.NpgsqlBox(top: 0.2924917062052569d,right: 0.6773220448327822d,bottom: 0.10434695006764527d,left: 0.07371616175982165d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5914080288194304d,right: 0.7943110507516775d,bottom: 0.46219503531043704d,left: 0.21776909658733856d), new NpgsqlTypes.NpgsqlBox(top: 0.9624627087203678d,right: 0.6383469282477788d,bottom: 0.8268877741556544d,left: 0.08922543705129815d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.883107441159831d,right: 0.9267377962993941d,bottom: 0.42308463073987834d,left: 0.19523152418584278d), new NpgsqlTypes.NpgsqlBox(top: 0.981143106947535d,right: 0.8317938069779692d,bottom: 0.4684353431165277d,left: 0.510262314277564d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7301812151799468d,right: 0.9384186575049456d,bottom: 0.25956369324414297d,left: 0.05881884598063791d), new NpgsqlTypes.NpgsqlBox(top: 0.4332607081428882d,right: 0.7915699097666541d,bottom: 0.40238225364175173d,left: 0.11575868046669491d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8399502383779007d,right: 0.5687371460154942d,bottom: 0.5466247083467918d,left: 0.3743855863953972d), new NpgsqlTypes.NpgsqlBox(top: 0.8676586009726986d,right: 0.7939945991605835d,bottom: 0.18642874890383931d,left: 0.34613814631974316d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7708364825964705d,right: 0.8617272148349128d,bottom: 0.13331569550504896d,left: 0.6014482736563366d), new NpgsqlTypes.NpgsqlBox(top: 0.3683827060946795d,right: 0.9753488939033624d,bottom: 0.21347762629234757d,left: 0.041613417837274125d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7412488785777548d,right: 0.8306521452980767d,bottom: 0.7300093942873299d,left: 0.6059246355808414d), new NpgsqlTypes.NpgsqlBox(top: 0.9195946942402043d,right: 0.6564751594071323d,bottom: 0.6828272060604231d,left: 0.13092529342103298d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4507536222346523d,right: 0.5441486574489444d,bottom: 0.358528710122339d,left: 0.4991893085223027d), new NpgsqlTypes.NpgsqlBox(top: 0.19412870695898188d,right: 0.5606335862474927d,bottom: 0.07162399207343928d,left: 0.37359313187776944d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5769522846070639d,right: 0.9084525305688232d,bottom: 0.4729501632564954d,left: 0.6803607802564324d), new NpgsqlTypes.NpgsqlBox(top: 0.6527949595935995d,right: 0.508696385359183d,bottom: 0.38008064555141274d,left: 0.03429382169918249d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5656213760242019d,right: 0.4274669592797664d,bottom: 0.2814543936882833d,left: 0.040704075011388285d), new NpgsqlTypes.NpgsqlBox(top: 0.6575348210120417d,right: 0.6780567357722957d,bottom: 0.2958313174330316d,left: 0.18325667599056072d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.43837797585401916d,right: 0.7039303384082739d,bottom: 0.1323749593494482d,left: 0.3980929835845647d), new NpgsqlTypes.NpgsqlBox(top: 0.613438811519699d,right: 0.7178173256494642d,bottom: 0.37208021447546236d,left: 0.46847208279753894d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9317893024199837d,right: 0.7993497187826085d,bottom: 0.722055614696326d,left: 0.019088880670323327d), new NpgsqlTypes.NpgsqlBox(top: 0.5699723100656724d,right: 0.8078053616001492d,bottom: 0.09846863625592983d,left: 0.5612992246799826d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6573841394469067d,right: 0.918081064551465d,bottom: 0.37348127411815735d,left: 0.6526985815672887d), new NpgsqlTypes.NpgsqlBox(top: 0.5377448305199273d,right: 0.9403536471499923d,bottom: 0.5027470687756385d,left: 0.5410201388633554d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7317057934030327d,right: 0.9062653454335311d,bottom: 0.045410697393070465d,left: 0.8785990803858867d), new NpgsqlTypes.NpgsqlBox(top: 0.7846114532499379d,right: 0.827766520930326d,bottom: 0.03642759640422899d,left: 0.4365750084483d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8166320797208968d,right: 0.6894743065289601d,bottom: 0.13048099207982067d,left: 0.1337045105197362d), new NpgsqlTypes.NpgsqlBox(top: 0.9185223329115911d,right: 0.727804979401301d,bottom: 0.47453483878183944d,left: 0.1384644125364921d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8300181787785508d,right: 0.6489493533862697d,bottom: 0.8144983907603531d,left: 0.08193379114538613d), new NpgsqlTypes.NpgsqlBox(top: 0.8483467350795517d,right: 0.6685577208402674d,bottom: 0.14315644963415164d,left: 0.1767122179014844d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4534239083347986d,right: 0.950208477369775d,bottom: 0.3487989244539965d,left: 0.0023652534453484364d), new NpgsqlTypes.NpgsqlBox(top: 0.8234635656497878d,right: 0.4816463178904562d,bottom: 0.7255222555220575d,left: 0.18694985543190745d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5809779422274903d,right: 0.15490961277256554d,bottom: 0.5752010365096418d,left: 0.0659691035174026d), new NpgsqlTypes.NpgsqlBox(top: 0.7560848268770398d,right: 0.6968032566120209d,bottom: 0.05356115366081382d,left: 0.5751997156873531d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7868585473157123d,right: 0.4295439577289657d,bottom: 0.3852227823122296d,left: 0.019833128807410172d), new NpgsqlTypes.NpgsqlBox(top: 0.2937025936446309d,right: 0.8864284047738548d,bottom: 0.24195405708629092d,left: 0.15241320197962616d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8696744701825239d,right: 0.9391898240413818d,bottom: 0.16709296109507688d,left: 0.4968687656115519d), new NpgsqlTypes.NpgsqlBox(top: 0.9126713342641118d,right: 0.9434692495961302d,bottom: 0.18580254398363139d,left: 0.7890307646516669d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.968755193267888d,right: 0.5486924439955727d,bottom: 0.07876813665446358d,left: 0.2665548686039788d), new NpgsqlTypes.NpgsqlBox(top: 0.390466515123691d,right: 0.6729469043667643d,bottom: 0.29058196413991444d,left: 0.265458631943039d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9407327485042941d,right: 0.6706881651749836d,bottom: 0.5464198256542198d,left: 0.04022926993438691d), new NpgsqlTypes.NpgsqlBox(top: 0.5854549553749323d,right: 0.9424072887310995d,bottom: 0.13494795640873458d,left: 0.7570755657552047d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9729712807446107d,right: 0.9919796661471458d,bottom: 0.9235204623003532d,left: 0.8885800762526564d), new NpgsqlTypes.NpgsqlBox(top: 0.37857942320260196d,right: 0.4157997798655836d,bottom: 0.16144870343534334d,left: 0.3501743460448804d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5188912630680517d,right: 0.9178121218054726d,bottom: 0.4434080365408778d,left: 0.30656260770994526d), new NpgsqlTypes.NpgsqlBox(top: 0.6415787615439049d,right: 0.35405701805073997d,bottom: 0.08295420484945482d,left: 0.2164194473436245d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4974986891306773d,right: 0.8157118729470444d,bottom: 0.35201576642394017d,left: 0.6168042181558877d), new NpgsqlTypes.NpgsqlBox(top: 0.6934744916895443d,right: 0.42105969291235157d,bottom: 0.12103458936850142d,left: 0.049439239009893776d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8265963373233255d,right: 0.7703674034596407d,bottom: 0.5952249196388575d,left: 0.124364553371625d), new NpgsqlTypes.NpgsqlBox(top: 0.35698082214287385d,right: 0.7070206896946657d,bottom: 0.127918577921451d,left: 0.44594070145566156d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7080565974079989d,right: 0.6069980936503808d,bottom: 0.4434600775589641d,left: 0.4877986483351755d), new NpgsqlTypes.NpgsqlBox(top: 0.654365153564249d,right: 0.3253083783599363d,bottom: 0.5623811196521934d,left: 0.010230704263923363d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7790834696923374d,right: 0.645060603103375d,bottom: 0.4879293324337539d,left: 0.3525329002368396d), new NpgsqlTypes.NpgsqlBox(top: 0.7385183725821738d,right: 0.4722733712256134d,bottom: 0.699899643748619d,left: 0.2673794688774025d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7689060768993787d,right: 0.9227286342812026d,bottom: 0.35211714487606194d,left: 0.8934369181315032d), new NpgsqlTypes.NpgsqlBox(top: 0.6750886833321473d,right: 0.8115895576866692d,bottom: 0.44461550713358544d,left: 0.18876402315778817d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9517230558342159d,right: 0.8777760310746658d,bottom: 0.22119488141709864d,left: 0.6123829130737407d), new NpgsqlTypes.NpgsqlBox(top: 0.3975861379096508d,right: 0.5217309583567731d,bottom: 0.2805359987847116d,left: 0.007056214021066709d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6241802689715147d,right: 0.7330598222020037d,bottom: 0.11261307333666226d,left: 0.448712384155045d), new NpgsqlTypes.NpgsqlBox(top: 0.484671053415621d,right: 0.7617395322326364d,bottom: 0.4762417707255001d,left: 0.25418328323789363d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7703620565309214d,right: 0.59870786140214d,bottom: 0.3133857653630101d,left: 0.534308535395268d), new NpgsqlTypes.NpgsqlBox(top: 0.6993093663602863d,right: 0.9249226711820282d,bottom: 0.34840017343589813d,left: 0.5990932190832396d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.2899897890163746d,right: 0.9370902653245939d,bottom: 0.27939438118755777d,left: 0.8559921040642507d), new NpgsqlTypes.NpgsqlBox(top: 0.6920535362323451d,right: 0.362286233270536d,bottom: 0.4814734881477072d,left: 0.016671086666514623d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6762010881998936d,right: 0.2549868655344636d,bottom: 0.06347139316348849d,left: 0.06970541970681443d), new NpgsqlTypes.NpgsqlBox(top: 0.8072465201017135d,right: 0.6356307618928424d,bottom: 0.51053120224299d,left: 0.597106015846087d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6158037110660382d,right: 0.967429753817505d,bottom: 0.4532356440026488d,left: 0.8494136961826433d), new NpgsqlTypes.NpgsqlBox(top: 0.832486427068555d,right: 0.7646016725315609d,bottom: 0.5589815684619724d,left: 0.6190009076111513d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8185873157339791d,right: 0.9837499620441675d,bottom: 0.1529770711949756d,left: 0.8179793176363624d), new NpgsqlTypes.NpgsqlBox(top: 0.4673055947096849d,right: 0.9889638019686283d,bottom: 0.1414865571755387d,left: 0.8445355989332389d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.600735209119592d,right: 0.921898170829168d,bottom: 0.3881127912273742d,left: 0.6129943900141579d), new NpgsqlTypes.NpgsqlBox(top: 0.8207258229396462d,right: 0.8092460839438561d,bottom: 0.2830469538242575d,left: 0.5531411525968248d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9065673863112209d,right: 0.658248011060954d,bottom: 0.8816756302312355d,left: 0.15668833486086942d), new NpgsqlTypes.NpgsqlBox(top: 0.8078007752939573d,right: 0.40129794349442927d,bottom: 0.7083944139834428d,left: 0.27919693400228696d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.425299458286474d,right: 0.9320827688273394d,bottom: 0.42161465688900746d,left: 0.5957921540467777d), new NpgsqlTypes.NpgsqlBox(top: 0.31035836761682667d,right: 0.23008183314380748d,bottom: 0.27065777807890123d,left: 0.03046620248481191d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5870505835538523d,right: 0.2139767955832702d,bottom: 0.4692735591274583d,left: 0.12581918024065863d), new NpgsqlTypes.NpgsqlBox(top: 0.9672586727771564d,right: 0.7690454477224266d,bottom: 0.6844706661070991d,left: 0.039088100007547255d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7663591746686825d,right: 0.5760875869882377d,bottom: 0.5273728196547045d,left: 0.16152519446311397d), new NpgsqlTypes.NpgsqlBox(top: 0.5421299273869462d,right: 0.9932289242126046d,bottom: 0.15694520262685308d,left: 0.4737315530437325d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4486008384558572d,right: 0.7471887100436175d,bottom: 0.11854147427403106d,left: 0.5697027697019323d), new NpgsqlTypes.NpgsqlBox(top: 0.42467665095766394d,right: 0.3089517365476203d,bottom: 0.20565035659916586d,left: 0.14773121079529072d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8091949685580506d,right: 0.7591152948675942d,bottom: 0.2181762096654909d,left: 0.6076111135918522d), new NpgsqlTypes.NpgsqlBox(top: 0.797202876600808d,right: 0.5422351928985762d,bottom: 0.19969825072369152d,left: 0.16375960447286064d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9796867350409071d,right: 0.6860623882765774d,bottom: 0.818540022308566d,left: 0.4937416298575027d), new NpgsqlTypes.NpgsqlBox(top: 0.9326611069413269d,right: 0.8449011623988005d,bottom: 0.18960340508462603d,left: 0.6842273444433753d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.579324209878143d,right: 0.6335201671281296d,bottom: 0.4584287090322927d,left: 0.14887230477371016d), new NpgsqlTypes.NpgsqlBox(top: 0.7423511406957923d,right: 0.9666190782680576d,bottom: 0.5030017008359706d,left: 0.5972614850415306d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9346151081648547d,right: 0.9448396002605356d,bottom: 0.7771778022023667d,left: 0.27703416447518636d), new NpgsqlTypes.NpgsqlBox(top: 0.642507295800207d,right: 0.20306091069851773d,bottom: 0.17825581992835293d,left: 0.08987016065369191d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9924861691233087d,right: 0.5102316808133349d,bottom: 0.22004095212126307d,left: 0.3678677968029137d), new NpgsqlTypes.NpgsqlBox(top: 0.8915383362621746d,right: 0.7944584367741686d,bottom: 0.8608956891109416d,left: 0.29156642351204176d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2734917387549052d,right: 0.6295519866745184d,bottom: 0.05117660109301503d,left: 0.450992305311417d), new NpgsqlTypes.NpgsqlBox(top: 0.8243877968038875d,right: 0.4572230973557223d,bottom: 0.6559275150887177d,left: 0.2012434778754898d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6738636643873713d,right: 0.8536257250043803d,bottom: 0.4929912688176775d,left: 0.49413763391154175d), new NpgsqlTypes.NpgsqlBox(top: 0.7837684479793926d,right: 0.7743609125687144d,bottom: 0.3856142281061947d,left: 0.08105500297324042d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.10989201792830261d,right: 0.9840777490618234d,bottom: 0.023114451026785998d,left: 0.6357660682307149d), new NpgsqlTypes.NpgsqlBox(top: 0.7774310266088176d,right: 0.638446577207288d,bottom: 0.12255128319296071d,left: 0.5369712470948178d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6141526103311304d,right: 0.6424669759003405d,bottom: 0.3932412286522198d,left: 0.0712442079116109d), new NpgsqlTypes.NpgsqlBox(top: 0.4548908946741922d,right: 0.5386040245110146d,bottom: 0.014536078866351665d,left: 0.03399157881931014d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5894853507862234d,right: 0.4570610389385099d,bottom: 0.3815103762698926d,left: 0.36765939516249535d), new NpgsqlTypes.NpgsqlBox(top: 0.7374068624098647d,right: 0.7255079596911307d,bottom: 0.30710884367673297d,left: 0.1887664039560657d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.05724181844119214d,right: 0.15041856920902041d,bottom: 0.05592903319210485d,left: 0.13947235855478968d), new NpgsqlTypes.NpgsqlBox(top: 0.680008208272061d,right: 0.8761691829596758d,bottom: 0.41526045106494414d,left: 0.4887584033717539d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7965627463400152d,right: 0.6932240161270089d,bottom: 0.45742031462341803d,left: 0.11566437983392708d), new NpgsqlTypes.NpgsqlBox(top: 0.9754953069391706d,right: 0.8670570133361848d,bottom: 0.6715149653098328d,left: 0.32564939295528783d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4093534012231832d,right: 0.9053788153000131d,bottom: 0.03160936422196292d,left: 0.255020627903496d), new NpgsqlTypes.NpgsqlBox(top: 0.9168772074202154d,right: 0.7860314793404273d,bottom: 0.04156863522330245d,left: 0.016075000310092014d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5079218224891343d,right: 0.9988646262310324d,bottom: 0.4307057391883249d,left: 0.9064641023963605d), new NpgsqlTypes.NpgsqlBox(top: 0.2787049710405952d,right: 0.9912883713340633d,bottom: 0.1376559632667823d,left: 0.20425719288121746d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6973697308099779d,right: 0.3398641163898879d,bottom: 0.5624386318676268d,left: 0.05992184299358572d), new NpgsqlTypes.NpgsqlBox(top: 0.7661282009108289d,right: 0.41887130645628357d,bottom: 0.5442804780594458d,left: 0.022843067615006762d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.39383547617926473d,right: 0.6245115159577397d,bottom: 0.33520378095481573d,left: 0.2555205557309518d), new NpgsqlTypes.NpgsqlBox(top: 0.8946915972186971d,right: 0.9061497394137777d,bottom: 0.5479831033238676d,left: 0.19751171383853372d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.48140376123910245d,right: 0.6545574391856277d,bottom: 0.26148696354556933d,left: 0.3458441694405957d), new NpgsqlTypes.NpgsqlBox(top: 0.3392032359953193d,right: 0.8228080476990178d,bottom: 0.21547608498874382d,left: 0.4583866657069806d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.30984591195559064d,right: 0.9568792359913961d,bottom: 0.04462397917361216d,left: 0.8930017837261505d), new NpgsqlTypes.NpgsqlBox(top: 0.9910438897715461d,right: 0.9231784278816642d,bottom: 0.24142064199005908d,left: 0.6074374225934865d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4741923299883315d,right: 0.7923748636673796d,bottom: 0.4495475972572811d,left: 0.19872648881489485d), new NpgsqlTypes.NpgsqlBox(top: 0.19733122932316094d,right: 0.8823411500100614d,bottom: 0.11691563467070631d,left: 0.6913898774936633d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.762174515608221d,right: 0.08677249721425195d,bottom: 0.22679594783669477d,left: 0.0742424448968656d), new NpgsqlTypes.NpgsqlBox(top: 0.8477799346011194d,right: 0.4089591383497533d,bottom: 0.5269349606370958d,left: 0.013655508514739623d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7444814973596402d,right: 0.56064346952536d,bottom: 0.09001765660742722d,left: 0.11947827823129764d), new NpgsqlTypes.NpgsqlBox(top: 0.8416627581256845d,right: 0.033555749609438634d,bottom: 0.15574519982108237d,left: 0.00625405374978949d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3777918776823792d,right: 0.7912289454507778d,bottom: 0.1378226647288444d,left: 0.3512403866649556d), new NpgsqlTypes.NpgsqlBox(top: 0.8022714789822666d,right: 0.7000991342856175d,bottom: 0.5161627891265759d,left: 0.4050037825645657d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7449261653946115d,right: 0.6657446904171096d,bottom: 0.12824932041667325d,left: 0.09810220319853524d), new NpgsqlTypes.NpgsqlBox(top: 0.7186772121778285d,right: 0.7535659853279225d,bottom: 0.6068752936526972d,left: 0.5203731100609521d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4359337169980062d,right: 0.8701940778721083d,bottom: 0.41697319233675323d,left: 0.37760171087887173d), new NpgsqlTypes.NpgsqlBox(top: 0.9470119526695847d,right: 0.31669266881867975d,bottom: 0.1847947579967847d,left: 0.0860690013847546d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7056825750775794d,right: 0.3552627937119446d,bottom: 0.2659026416840161d,left: 0.08609931672798876d), new NpgsqlTypes.NpgsqlBox(top: 0.871591112805816d,right: 0.5735549633735246d,bottom: 0.040111616154522634d,left: 0.12814623297695005d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8594880503176769d,right: 0.9335947524863561d,bottom: 0.14142670039158778d,left: 0.26264660526656103d), new NpgsqlTypes.NpgsqlBox(top: 0.4165639759175953d,right: 0.791862546055486d,bottom: 0.216341462520783d,left: 0.3891084929985331d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9982825874517741d,right: 0.9002746901634857d,bottom: 0.33461719186081007d,left: 0.11794836673997633d), new NpgsqlTypes.NpgsqlBox(top: 0.7260851744464537d,right: 0.9283546042314937d,bottom: 0.5734041917680144d,left: 0.3771820099897105d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4801959770702573d,right: 0.7041365578925523d,bottom: 0.11062255410620192d,left: 0.5403137511491828d), new NpgsqlTypes.NpgsqlBox(top: 0.412102317350064d,right: 0.23980757071901315d,bottom: 0.08525328394261644d,left: 0.04982831787787678d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.473714544228634d,right: 0.7200723856782071d,bottom: 0.01576621649221055d,left: 0.14640457465629997d), new NpgsqlTypes.NpgsqlBox(top: 0.8593819652805404d,right: 0.8654808243713054d,bottom: 0.42976843042519763d,left: 0.12922957736614682d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9781922965343591d,right: 0.7287389773176244d,bottom: 0.05299816885856545d,left: 0.6911493399939345d), new NpgsqlTypes.NpgsqlBox(top: 0.6466650014190544d,right: 0.6909916436780671d,bottom: 0.08611064292380055d,left: 0.20979846833025428d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9770975483340137d,right: 0.5637590735662781d,bottom: 0.9351300909625057d,left: 0.3532748771311812d), new NpgsqlTypes.NpgsqlBox(top: 0.8970742468923364d,right: 0.8474443354422404d,bottom: 0.6159234859506838d,left: 0.04778237374389149d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.783019378360536d,right: 0.30383391802099313d,bottom: 0.3958478201290655d,left: 0.2798804288509459d), new NpgsqlTypes.NpgsqlBox(top: 0.8563315706904521d,right: 0.46180498532741787d,bottom: 0.3292157117561748d,left: 0.2915812198678275d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8910118623324982d,right: 0.7752418625255845d,bottom: 0.4889609598149838d,left: 0.5388075853925948d), new NpgsqlTypes.NpgsqlBox(top: 0.1838133731348095d,right: 0.6621500449795927d,bottom: 0.10308927294548698d,left: 0.008704701244015789d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5386036375488212d,right: 0.31528605850173574d,bottom: 0.2548766551092374d,left: 0.08204096878986822d), new NpgsqlTypes.NpgsqlBox(top: 0.9674597555132598d,right: 0.3345433548986827d,bottom: 0.22334868623351056d,left: 0.04019239719706569d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.38087862242204396d,right: 0.3249304754592385d,bottom: 0.36602941932932964d,left: 0.05604687432775546d), new NpgsqlTypes.NpgsqlBox(top: 0.8952659186175174d,right: 0.1185980674271937d,bottom: 0.6863724519514777d,left: 0.06991026137294731d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8081480869955031d,right: 0.20173278546168327d,bottom: 0.1432961435810488d,left: 0.06857932725412796d), new NpgsqlTypes.NpgsqlBox(top: 0.3144306178260168d,right: 0.9240983125874159d,bottom: 0.11169182306190029d,left: 0.13370366205207418d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7337204634690646d,right: 0.6796647399907197d,bottom: 0.5773864690289872d,left: 0.6554609838507078d), new NpgsqlTypes.NpgsqlBox(top: 0.657358300166815d,right: 0.8322935090044192d,bottom: 0.26185506490975996d,left: 0.6489642624625142d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9294916323944963d,right: 0.9540503491470887d,bottom: 0.571387576431603d,left: 0.5437444252744583d), new NpgsqlTypes.NpgsqlBox(top: 0.6930979826290875d,right: 0.7503359069739904d,bottom: 0.5429671757293357d,left: 0.5064127737133186d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.09228683895084888d,right: 0.9809766470762918d,bottom: 0.01970244551908973d,left: 0.9177212264753412d), new NpgsqlTypes.NpgsqlBox(top: 0.2791552605412697d,right: 0.4410870223770639d,bottom: 0.0008204771906469288d,left: 0.13669161588798684d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.545453148549417d,right: 0.47035477324654207d,bottom: 0.3339466679020373d,left: 0.2838121800352107d), new NpgsqlTypes.NpgsqlBox(top: 0.8577760236477874d,right: 0.34373139485109216d,bottom: 0.10057285227709722d,left: 0.2733560875790312d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8275155703650767d,right: 0.884171840250971d,bottom: 0.08882495042125838d,left: 0.6901099332652119d), new NpgsqlTypes.NpgsqlBox(top: 0.7011732789493623d,right: 0.42814472508860824d,bottom: 0.2565426919809659d,left: 0.38344267898437134d), }, },
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6739119514117616d,right: 0.7237412931311933d,bottom: 0.6688213114862245d,left: 0.31146222815919444d), new NpgsqlTypes.NpgsqlBox(top: 0.6980080878773209d,right: 0.9208422884547823d,bottom: 0.31713470326944204d,left: 0.7937736986862539d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6549323944760997d,right: 0.18106811879178653d,bottom: 0.4831936319521041d,left: 0.0026511074873702967d), new NpgsqlTypes.NpgsqlBox(top: 0.36218980188429073d,right: 0.6082497447240643d,bottom: 0.12640305021434584d,left: 0.38303068755151715d), }, }));
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
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8151937617478813d,right: 0.9499578077776677d,bottom: 0.12433530519523528d,left: 0.5347861993003619d), new NpgsqlTypes.NpgsqlBox(top: 0.7715456285807555d,right: 0.7806298214391705d,bottom: 0.672549840742464d,left: 0.5942929606340807d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.23991668476612116d,right: 0.5663473135576493d,bottom: 0.17367361487477773d,left: 0.41928803683669424d), new NpgsqlTypes.NpgsqlBox(top: 0.49035801688214753d,right: 0.8010268510268682d,bottom: 0.08972057849122916d,left: 0.4516164267510563d), }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.97920631687859d,right: 0.9528161523324146d,bottom: 0.4832168480360006d,left: 0.8035280870753384d), new NpgsqlTypes.NpgsqlBox(top: 0.36258896306574695d,right: 0.8597559222893142d,bottom: 0.304209720821898d,left: 0.8161838417405299d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8963989393222874d,right: 0.7267142459439726d,bottom: 0.37559816298996995d,left: 0.48812884380169863d), new NpgsqlTypes.NpgsqlBox(top: 0.9702960851081393d,right: 0.5309863077055038d,bottom: 0.45398971316042613d,left: 0.39905718712910654d), }, }));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 136, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 14, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 99, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

