

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
    internal partial interface INpgsqlCircleMArraycircleMArrayD1
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMArrayD1 : INpgsqlCircleMArraycircleMArrayD1
    {


#region TestData

        private readonly NpgsqlCirclecircleMArrayD1E1M[] _testData = new NpgsqlCirclecircleMArrayD1E1M[]
        {
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8671240261958733d, y: 0.6470872413321442d), radius: 0.4452825340188272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.247960608529317d, y: 0.15287844124867278d), radius: 0.42285690598976544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6724054778618024d, y: 0.6868353007032486d), radius: 0.4377178058859078d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6115968760278655d, y: 0.09518424344094545d), radius: 0.32651239043950875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11975498606960022d, y: 0.8458235514328027d), radius: 0.4288715383820302d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15040818276941714d, y: 0.34063805604919783d), radius: 0.38609588719439414d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8877196156405912d, y: 0.44470788285101037d), radius: 0.49555412287442435d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8462339492770715d, y: 0.8930387493684541d), radius: 0.15537665163974468d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774309318601142d, y: 0.9873199207801799d), radius: 0.35817952869123193d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23219388889363335d, y: 0.814617812848484d), radius: 0.643701818031d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422704466501604d, y: 0.30882763049994877d), radius: 0.45601725517731573d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3836481884527144d, y: 0.19894131808476645d), radius: 0.4435753044641161d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6495483414424207d, y: 0.6378114463243082d), radius: 0.8528956934241321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2524681462165459d, y: 0.5903704485604475d), radius: 0.17265631469977227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8986990250842903d, y: 0.6424217028186825d), radius: 0.504034553961378d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49584565334230546d, y: 0.1744779494311205d), radius: 0.4730894388573975d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.527683603631837d, y: 0.05995200361228137d), radius: 0.1298277339466951d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11550294933897143d, y: 0.09322621401438125d), radius: 0.8378792660203107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7500912718504504d, y: 0.6371188870426457d), radius: 0.5684725038415537d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4752748358897413d, y: 0.479519791832971d), radius: 0.2635903400413099d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06531734215165386d, y: 0.647290941392578d), radius: 0.2673011019875934d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06022801975073899d, y: 0.8238882703476181d), radius: 0.7577071181967263d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5736665221246964d, y: 0.3182205271883336d), radius: 0.592101633137468d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4680414100587147d, y: 0.4346652888615903d), radius: 0.8937734548575711d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0016817270717131017d, y: 0.9859896694880738d), radius: 0.7929884722731074d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7794841901790591d, y: 0.42840540425889495d), radius: 0.061025287398487116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4684644137197286d, y: 0.3855547249837966d), radius: 0.8622157838741216d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24370707234977418d, y: 0.5626677435345457d), radius: 0.6942461055520308d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7779163910014518d, y: 0.7366731360085967d), radius: 0.058039518278399926d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8117304993324292d, y: 0.22225636297491735d), radius: 0.5520005525301963d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10821693021579237d, y: 0.42417609908443643d), radius: 0.16126229273608506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422570967543019d, y: 0.20323333597712656d), radius: 0.6198082117481936d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10852731141541772d, y: 0.5036847949863176d), radius: 0.6556509138527034d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00365648582224698d, y: 0.9388049349498231d), radius: 0.8000335156895401d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3606787456221625d, y: 0.2882027011081617d), radius: 0.4884559748749855d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20208677392491037d, y: 0.8156757446580648d), radius: 0.6993410421474661d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30039425618917737d, y: 0.10515729109102512d), radius: 0.30840743845529983d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43568252439982635d, y: 0.41256976541451673d), radius: 0.24536950696647175d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9355313311709476d, y: 0.38381176816062157d), radius: 0.4415497922573961d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11919131108963577d, y: 0.29155768106265323d), radius: 0.8016585152644637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1879035590485192d, y: 0.1980107970172983d), radius: 0.3927982387483696d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09738078831433272d, y: 0.7515296063849103d), radius: 0.8326694847218525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46420761470630223d, y: 0.7439695047408119d), radius: 0.9688164669429111d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052253156752849916d, y: 0.31653103223296186d), radius: 0.869709310488448d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9978490514897147d, y: 0.07451296939116214d), radius: 0.2951983137683165d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7358048589539401d, y: 0.2638701837377344d), radius: 0.4527196180513232d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004226248453133796d, y: 0.021329626522434086d), radius: 0.8943626779046326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11801194387443015d, y: 0.22401858475125547d), radius: 0.7525988938477873d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6974184448794053d, y: 0.48126705160983574d), radius: 0.6082552294273126d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7089423972959712d, y: 0.21547793029497564d), radius: 0.5901559619081304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9268876265412187d, y: 0.1497473221089921d), radius: 0.15458133977285926d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7945880542253296d, y: 0.9398680498825785d), radius: 0.8491076512321818d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29449977474889766d, y: 0.028124621612528822d), radius: 0.23754389988149782d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6530063782027313d, y: 0.0943827375545182d), radius: 0.2816464575323998d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45442072832607994d, y: 0.6837674831662485d), radius: 0.1467390930864706d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06453917452524716d, y: 0.8103804786972661d), radius: 0.6267722599814897d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04450467190305407d, y: 0.2743049794587965d), radius: 0.15486511088393495d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00880292588689846d, y: 0.6418287162291155d), radius: 0.2522371412941583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28014745763429394d, y: 0.5641827213993649d), radius: 0.7923683213154233d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2571802737618729d, y: 0.7125620948203181d), radius: 0.029630671583300572d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5193839383994044d, y: 0.9033995197713716d), radius: 0.17391416046552133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8016798537657788d, y: 0.7081561665696001d), radius: 0.6856561755069116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3425364653365328d, y: 0.2950003645237256d), radius: 0.49700350191551756d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.945915513916065d, y: 0.9834105879281153d), radius: 0.4659641256071497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8560357031532172d, y: 0.3720353468723232d), radius: 0.9694998896080697d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24637272556963696d, y: 0.5263007234766307d), radius: 0.7679739864853466d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43821727663206966d, y: 0.6184632522471586d), radius: 0.9311357946939376d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7760076563185865d, y: 0.9225690014609035d), radius: 0.8856435927825725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9748109689480728d, y: 0.6958491993909509d), radius: 0.6756502145184976d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05544023121140096d, y: 0.3328007795369601d), radius: 0.6162109715258272d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19580342118380534d, y: 0.37466054363905277d), radius: 0.30809331511829563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7929039442226599d, y: 0.8520312414764494d), radius: 0.4389042042073781d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041049188517785495d, y: 0.09915162292212809d), radius: 0.590070164114603d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1459181894129601d, y: 0.8803044137023566d), radius: 0.5598770133414281d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5988590451469691d, y: 0.44587159683190647d), radius: 0.6303414289497115d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939043687442331d, y: 0.9763033396463029d), radius: 0.45430736323614496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07064949192690428d, y: 0.8925354896802626d), radius: 0.7032326274912292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23371051755504513d, y: 0.7055075051330476d), radius: 0.42144732763321335d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8991647713048178d, y: 0.1432676651947422d), radius: 0.5099374713015308d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7824452523249034d, y: 0.2680853772527716d), radius: 0.7989953374884909d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5663285870641125d, y: 0.7247661728056766d), radius: 0.5755377640371838d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9086879305894896d, y: 0.8389803435855308d), radius: 0.9714508520577169d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9618895524238182d, y: 0.11590305768465248d), radius: 0.332116448031863d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2515565156820526d, y: 0.8833322819406371d), radius: 0.315953723638716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18528101633183125d, y: 0.36520087088547026d), radius: 0.6831115718186458d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.537817844266145d, y: 0.4419553995981216d), radius: 0.5384125755930612d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47046133296684955d, y: 0.26381031909835895d), radius: 0.9030097095766259d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6618673875033533d, y: 0.06403770323320324d), radius: 0.6217769570754236d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7086916335974288d, y: 0.9414492759170723d), radius: 0.44120582650390094d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25242642040069474d, y: 0.38575878575714206d), radius: 0.38023663645531114d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4235100885713431d, y: 0.7883653145206051d), radius: 0.35447513335247793d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3301252880538357d, y: 0.013184153464703252d), radius: 0.4450971848819152d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8296095161497465d, y: 0.9035560753894774d), radius: 0.5253827654407587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6950875513355572d, y: 0.8803026948076835d), radius: 0.9361900001564969d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5068438399275007d, y: 0.503743695782674d), radius: 0.049057555437905354d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9517412597909017d, y: 0.44623398210040977d), radius: 0.6080929115105093d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7279504067276837d, y: 0.8955358189608618d), radius: 0.9437451811694525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5952166949210816d, y: 0.11328034564726197d), radius: 0.11779061442095218d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9142855684506723d, y: 0.9497837164547327d), radius: 0.9958248846557567d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05496104760234222d, y: 0.101438191560829d), radius: 0.08201053597067631d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09721933160633167d, y: 0.3786449657038493d), radius: 0.7757827851040675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7741840191882522d, y: 0.9117389053098274d), radius: 0.7283486641811215d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8264503673344483d, y: 0.9597361628533254d), radius: 0.7971757379542002d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5822279974231513d, y: 0.9893634805053673d), radius: 0.4249040343010716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09636639595959706d, y: 0.019672235935983773d), radius: 0.5461401461409334d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19901522599200694d, y: 0.7581431260234304d), radius: 0.689396112747097d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.667478467923201d, y: 0.2634465059051069d), radius: 0.5097817368791073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4259822391922846d, y: 0.5917574473266066d), radius: 0.5035116023613214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8844494201821955d, y: 0.9091897740294747d), radius: 0.32506672443357154d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7323990073085346d, y: 0.5687037465590182d), radius: 0.5749198569503958d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9920501006178137d, y: 0.7676169108557133d), radius: 0.13696337128976743d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2794377837700456d, y: 0.9640894534529811d), radius: 0.27184513978087854d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2504685851101902d, y: 0.5057712821351128d), radius: 0.43647898092333537d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069284357267365d, y: 0.7509967985469062d), radius: 0.11553167699571842d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7168137076764806d, y: 0.59146608899572d), radius: 0.19240766849945712d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28488739856346257d, y: 0.8777317610561411d), radius: 0.4119952229173359d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12544908879275907d, y: 0.4962039465976057d), radius: 0.8626096258787258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5948123970723757d, y: 0.7473654941101519d), radius: 0.8967969663800883d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8850532911360985d, y: 0.6751946208761052d), radius: 0.061468942509565694d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18188200112105601d, y: 0.9605257415940124d), radius: 0.9690405869644452d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3259182206073955d, y: 0.6284852364354604d), radius: 0.5456022978703893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6954457483131252d, y: 0.6107433313266838d), radius: 0.7947681263346497d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11927406083834258d, y: 0.054829891501282035d), radius: 0.8453063492031477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4303284706760935d, y: 0.2187058732506395d), radius: 0.2135012064591708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09759404330734966d, y: 0.4299093161151343d), radius: 0.1775431942096669d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3830406851370287d, y: 0.10270148307934002d), radius: 0.9900452336926089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1005398218934539d, y: 0.7489620212141582d), radius: 0.5975503476322436d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37501158405949875d, y: 0.15166234913006915d), radius: 0.3503579429700251d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5742065696448407d, y: 0.2183459560881259d), radius: 0.5290223665772992d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41165771924143035d, y: 0.5387312167788819d), radius: 0.0905959895141587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7131053896492889d, y: 0.4381467290941805d), radius: 0.5740366196573126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8287987273262639d, y: 0.00016683853955312689d), radius: 0.13222782758679885d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4742771542188192d, y: 0.24548865627499228d), radius: 0.5398326048327181d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3978545397956783d, y: 0.8044974626778941d), radius: 0.5324014886869521d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18017524063769663d, y: 0.824503147705848d), radius: 0.44655714451558903d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7926280614875586d, y: 0.7726477894024211d), radius: 0.6953046213311731d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20654135015947528d, y: 0.7831249777343758d), radius: 0.44569473060977716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015445430446122677d, y: 0.07470702632781034d), radius: 0.011948517336751174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046340712579149845d, y: 0.37064589264136194d), radius: 0.6840900673140988d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2843177238930785d, y: 0.7772482856878645d), radius: 0.09671218893726041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7728927422464235d, y: 0.7916410060623016d), radius: 0.502653017027799d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7391168779165442d, y: 0.7136456478677583d), radius: 0.6801868396872187d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7943349288747727d, y: 0.3479100932862481d), radius: 0.8154593774156919d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.657502156655713d, y: 0.07574977646288983d), radius: 0.28064714162183746d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43217487760700335d, y: 0.12967591625821107d), radius: 0.06365549556510941d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2934883090644549d, y: 0.3951893003824627d), radius: 0.6757495407477055d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857744576271465d, y: 0.23965757206324068d), radius: 0.704032390557809d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6550916255848123d, y: 0.253012777190884d), radius: 0.446142510969072d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.418126564713867d, y: 0.586650633006201d), radius: 0.5932093052100752d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29565717425883953d, y: 0.12617939791041177d), radius: 0.6249055357912271d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7389260152498394d, y: 0.09350007330374621d), radius: 0.3263999531017724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6059016331169277d, y: 0.4382580218331571d), radius: 0.20038783815709815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5082797567720733d, y: 0.825475226720024d), radius: 0.23607774224708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8646330814748262d, y: 0.3997535131016776d), radius: 0.028635859971199884d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.684570578876476d, y: 0.3558913900943669d), radius: 0.4654373544185183d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7367983647201298d, y: 0.37210619690061586d), radius: 0.7917765505397988d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7008175297275391d, y: 0.4076380732852555d), radius: 0.7520241181516741d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6631319779379675d, y: 0.4778853798846695d), radius: 0.8331869367203619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.834115935808682d, y: 0.22557180482865935d), radius: 0.787849751516307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5829907255191286d, y: 0.21874553841661037d), radius: 0.6598398602539235d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.274266036581962d, y: 0.41118964739202635d), radius: 0.47154179648830374d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8969807612973884d, y: 0.02998648420071104d), radius: 0.07152210251685232d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9338991092847043d, y: 0.64699934679607d), radius: 0.5862257187110234d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5977161480772372d, y: 0.6928214039963283d), radius: 0.16858591561753955d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7663866599067907d, y: 0.22973014947315074d), radius: 0.20676960266523026d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8018321713566766d, y: 0.3232657016607208d), radius: 0.41782022594487445d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6484146545770093d, y: 0.052354861769955185d), radius: 0.22361163227162073d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6477796232660947d, y: 0.967538510943708d), radius: 0.03933815545279995d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007814396451507943d, y: 0.33988044326327127d), radius: 0.7001153105393619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16458932039309948d, y: 0.22401727842222063d), radius: 0.49359755439172937d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7628226190526609d, y: 0.7191701959144428d), radius: 0.01574704392731907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25500163811327636d, y: 0.48210637427869574d), radius: 0.14729951956735232d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5383050209087175d, y: 0.7429207526805255d), radius: 0.0997581721678259d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36319408399694264d, y: 0.10606652874317091d), radius: 0.5534415179610269d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36083768298688934d, y: 0.772681075254757d), radius: 0.03828990681674138d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24101889362857642d, y: 0.07536182987516726d), radius: 0.19878091636576345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5509497721843051d, y: 0.8331163996923173d), radius: 0.43157111122907277d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14451827900660652d, y: 0.3758097145107947d), radius: 0.6745870744507698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5630145767639634d, y: 0.08912671908512693d), radius: 0.3241604938019381d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9138441081783818d, y: 0.38938131328457515d), radius: 0.5435919993235799d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9659073634790035d, y: 0.658878037242022d), radius: 0.32467684899032656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.72682416341163d, y: 0.286380089395995d), radius: 0.2634920192501622d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4298463322290137d, y: 0.42080068684845906d), radius: 0.49630669921188086d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12495004031375245d, y: 0.8453011865466298d), radius: 0.6638186461767306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21742778827991838d, y: 0.052667003490549646d), radius: 0.015445888412360276d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3204432476823488d, y: 0.4348070542962805d), radius: 0.4681251644639446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2861243437363914d, y: 0.1632075844380031d), radius: 0.7622255379277256d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11504047213472801d, y: 0.21543006329537562d), radius: 0.7123131514421717d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06351355147624904d, y: 0.8530761201038314d), radius: 0.9792532365429478d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23508785259332543d, y: 0.25931771595116726d), radius: 0.6889428101648649d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.743687930476463d, y: 0.574228740452033d), radius: 0.2400210592958435d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6894943712467168d, y: 0.6871695039951299d), radius: 0.5699495730804784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49987771374349554d, y: 0.03000296481199316d), radius: 0.07308186370819869d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12230848108846315d, y: 0.9833240805120416d), radius: 0.9900437812008831d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5559059949369588d, y: 0.21278511819964407d), radius: 0.5546203591058234d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5452112894081137d, y: 0.6475131155505008d), radius: 0.9853627706452337d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6024128304393181d, y: 0.9648392151879003d), radius: 0.42044358608360666d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5672297974403017d, y: 0.2927105096136081d), radius: 0.9611554171529834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4122967399448618d, y: 0.6845303258498285d), radius: 0.3176825161657624d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9781061687769719d, y: 0.6219520068920349d), radius: 0.3273953935144096d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7278687734969462d, y: 0.032358485209710075d), radius: 0.8961179189408968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7530345694819296d, y: 0.16477308717164307d), radius: 0.019147916246915253d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.910153271709826d, y: 0.7019407566031134d), radius: 0.009347320817905347d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5251229141660896d, y: 0.033885695275892025d), radius: 0.05965055017395038d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5840769490244768d, y: 0.052244198652227736d), radius: 0.44141394246422194d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3880647127730461d, y: 0.19556820570230038d), radius: 0.019846774953532598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.249104883770499d, y: 0.8567774655993671d), radius: 0.517440619137892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8542442495492131d, y: 0.38468556493151407d), radius: 0.44097247489710345d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04102246155332134d, y: 0.3087784625059504d), radius: 0.5953298019388101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4865473898292152d, y: 0.7320516084165981d), radius: 0.15874034670871695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9534899582266748d, y: 0.5314670151777418d), radius: 0.9811119741468914d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37638177010062934d, y: 0.06289271414134279d), radius: 0.04740745296907567d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9682185169304572d, y: 0.9407909604673597d), radius: 0.8929220460861198d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318287297789272d, y: 0.2964991140497606d), radius: 0.2824198342679508d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8309466628477065d, y: 0.7217217326463384d), radius: 0.6195720795901075d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061006278387549906d, y: 0.22668750869935106d), radius: 0.6791308075803022d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2831905231198234d, y: 0.04132874829390032d), radius: 0.2399673744617662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8123014365107442d, y: 0.5116764903349519d), radius: 0.3230853436348774d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9173698204486446d, y: 0.7005837371696363d), radius: 0.00586685003126175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7658446815489592d, y: 0.6396809256551977d), radius: 0.8350243927956579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26046160599223667d, y: 0.47724731052238467d), radius: 0.22563029125622325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03769292598403373d, y: 0.0500090456420661d), radius: 0.5189763121107633d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7421315627094668d, y: 0.46778082589870607d), radius: 0.8489224231130018d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6635303335072624d, y: 0.08836990972154435d), radius: 0.34309702429394884d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7166496077965013d, y: 0.3348047733969999d), radius: 0.4098589362677195d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7975477662828555d, y: 0.7727882931176503d), radius: 0.6507647912389964d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7673137086749177d, y: 0.2056533397829733d), radius: 0.3197489271070506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3341193209696055d, y: 0.1520346326852562d), radius: 0.5591196211312719d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5566112027156822d, y: 0.12812841513739281d), radius: 0.35670118990845723d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 194,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9794726611371423d, y: 0.5115045629199391d), radius: 0.019018615864765387d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5264756406845956d, y: 0.0798599290823716d), radius: 0.8249288593644151d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6036372950728242d, y: 0.8702846083630262d), radius: 0.8965791133850666d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9905944797070023d, y: 0.1836623772261382d), radius: 0.9483917162926393d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7452835483577603d, y: 0.6431048012200443d), radius: 0.4377138422239423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.290219598275978d, y: 0.2456947147138917d), radius: 0.5642937759259986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7432112312950293d, y: 0.8334768659900722d), radius: 0.8008024652600554d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6046013257628433d, y: 0.2882416461775642d), radius: 0.4482653695071691d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06589341295227402d, y: 0.49496380196425205d), radius: 0.24086727718151124d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7728339142235613d, y: 0.240411018011076d), radius: 0.543942996299226d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40671116100919147d, y: 0.08742509966216294d), radius: 0.5847184673197957d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3188980870190413d, y: 0.22179776770104165d), radius: 0.6653648444367767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24564201529735352d, y: 0.32682061550331865d), radius: 0.42918042737392104d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 198,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09804219469230802d, y: 0.6151292638369568d), radius: 0.9931183356897565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5166562254586481d, y: 0.8298338202547342d), radius: 0.9775418707958036d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5964061330138286d, y: 0.5507283829617453d), radius: 0.45612188326654757d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4887439273892624d, y: 0.031091126272516534d), radius: 0.9027480006781655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46699724531641074d, y: 0.846280403475704d), radius: 0.4756141864784187d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06808041257602526d, y: 0.9085008536153584d), radius: 0.3682694981801451d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27488629197149017d, y: 0.44799487884597744d), radius: 0.2077628367447536d),
},
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 205,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2455305104315706d, y: 0.7706742362812474d), radius: 0.6664851116326159d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27909924361516614d, y: 0.23065536865513703d), radius: 0.7520911746411403d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20021914743611036d, y: 0.5539517382217891d), radius: 0.1604293757278723d),
},
    ModelInner = new NpgsqlCirclecircleMArrayD11MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40733686060247953d, y: 0.3408407258083611d), radius: 0.5530106268469057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5312781623455285d, y: 0.2853657872002525d), radius: 0.9545982673342038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8659999187150736d, y: 0.8780400287040371d), radius: 0.37702192050931527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5720833403126502d, y: 0.6014510851476584d), radius: 0.6446700738711557d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMArrayD1E1M
{
    Id = 211,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15753279967520617d, y: 0.5699321604401641d), radius: 0.2882902786143827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6482963720111382d, y: 0.23991195058916293d), radius: 0.34149103706227535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.664101163874529d, y: 0.6708964618642084d), radius: 0.3733344105686456d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23004564528766214d, y: 0.8235461175965406d), radius: 0.10397480268971893d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3693629369286183d, y: 0.4587339482729623d), radius: 0.8994838429766292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00929334147978167d, y: 0.5782987816476234d), radius: 0.4302105518964474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8625966915076556d, y: 0.00152188907446682d), radius: 0.5700206086242116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7785947507133607d, y: 0.35056517818059774d), radius: 0.6521502862136771d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd11mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemarrayd11mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd11mi_id
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
    npgsqlcirclecirclemarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20208677392491037d, y: 0.8156757446580648d), radius: 0.6993410421474661d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30039425618917737d, y: 0.10515729109102512d), radius: 0.30840743845529983d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43568252439982635d, y: 0.41256976541451673d), radius: 0.24536950696647175d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5193839383994044d, y: 0.9033995197713716d), radius: 0.17391416046552133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8016798537657788d, y: 0.7081561665696001d), radius: 0.6856561755069116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3425364653365328d, y: 0.2950003645237256d), radius: 0.49700350191551756d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemarrayd11mi_id
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
    npgsqlcirclecirclemarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemarrayd11mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5988590451469691d, y: 0.44587159683190647d), radius: 0.6303414289497115d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939043687442331d, y: 0.9763033396463029d), radius: 0.45430736323614496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07064949192690428d, y: 0.8925354896802626d), radius: 0.7032326274912292d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23371051755504513d, y: 0.7055075051330476d), radius: 0.42144732763321335d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleMArraycircleMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMArrayD1E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMArrayD1E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd11mi mi ON mi.id = m.npgsqlcirclecirclemarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd11mi mi ON mi.id = m.npgsqlcirclecirclemarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd11mi mi ON mi.id = m.npgsqlcirclecirclemarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 198, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 164, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 166, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 153, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclemarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemarrayd11mi mi ON mi.id = m.npgsqlcirclecirclemarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 108, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 162);
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((INpgsqlCircleMArraycircleMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                NpgsqlCirclecircleMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD11MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD11MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
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
FROM public.binary_npgsqlcirclecirclemarrayd1e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemarrayd11mi mi ON mi.id = m.npgsqlcirclecirclemarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleMArraycircleMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA), typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
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
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
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
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA), typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
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
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
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
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MI), typeof(NpgsqlCirclecircleMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MI>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MI>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MI>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MI>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA), typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                await ((INpgsqlCircleMArraycircleMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                var models2 = new List<NpgsqlCirclecircleMArrayD11MIWA>();
                ((INpgsqlCircleMArraycircleMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

