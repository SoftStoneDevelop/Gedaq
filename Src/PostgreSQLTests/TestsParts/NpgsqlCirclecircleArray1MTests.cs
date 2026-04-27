

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9369695960450274d, y: 0.21054157899735282d), radius: 0.07316004623358696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9952886559140147d, y: 0.24690244606147382d), radius: 0.2605965416641993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29270095561604714d, y: 0.09337435434114383d), radius: 0.455063706118495d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34913278873083387d, y: 0.22917624520867086d), radius: 0.3442342747598506d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9184405759958927d, y: 0.7915041920720189d), radius: 0.27183303820562155d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35930245808707684d, y: 0.35571060437593804d), radius: 0.5198057693850746d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.750802920585733d, y: 0.5855149950465605d), radius: 0.34343869125360793d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26886224991034546d, y: 0.7476944181375418d), radius: 0.34110377457877017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05198507984325873d, y: 0.9754523656084796d), radius: 0.5421200849235986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3845448821950316d, y: 0.09159947757973064d), radius: 0.3782515515789139d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42287302685078776d, y: 0.6267980382889321d), radius: 0.7416608945668991d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31127605767444977d, y: 0.18864025334317802d), radius: 0.8997555368461982d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7128839274675717d, y: 0.8702380778403881d), radius: 0.8443054372151749d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47615790922187107d, y: 0.8625587793178251d), radius: 0.674196932560608d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.751704047363165d, y: 0.9246259180907008d), radius: 0.506360686210636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11633800438222841d, y: 0.6154300629721271d), radius: 0.19289766152451882d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5885781198143224d, y: 0.8540938308895613d), radius: 0.27055201266124285d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5480322334592863d, y: 0.3944165832681149d), radius: 0.7087730835472063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9148571492408919d, y: 0.6623475717503061d), radius: 0.5859004253737318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6557111349964273d, y: 0.1842070967161621d), radius: 0.11188551111071154d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6253162820631084d, y: 0.8465848309263374d), radius: 0.20050115430587956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4899797280435516d, y: 0.5179568702418393d), radius: 0.19088160392430142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33861619162366796d, y: 0.9945401268999391d), radius: 0.2347521023466923d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2546258036712856d, y: 0.4807162628813384d), radius: 0.03144934406748301d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2773080634563002d, y: 0.43454170863787667d), radius: 0.811663903097391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4132704400568913d, y: 0.5558927488111809d), radius: 0.6465161535518408d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38531239186658806d, y: 0.7223729237511732d), radius: 0.14920923053159663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2738332777123096d, y: 0.6574836082204067d), radius: 0.3471389979073216d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3871911070858006d, y: 0.17654911218777058d), radius: 0.1985726036886699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22770577648016221d, y: 0.5948931169639016d), radius: 0.8415470553750463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18639237930819064d, y: 0.18404529300012662d), radius: 0.38492404039215433d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8392136665444584d, y: 0.6303342839166486d), radius: 0.685778574057709d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.549401159678624d, y: 0.4115481865362791d), radius: 0.7136956001744538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18297935187579462d, y: 0.7680280172937858d), radius: 0.6251196775339399d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6134780351255493d, y: 0.2342384247921977d), radius: 0.5786172332250797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7797092396803742d, y: 0.8774421735630759d), radius: 0.18271171803896658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21586122508609784d, y: 0.42849574882229535d), radius: 0.9480774336344598d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667522286799569d, y: 0.547585159898531d), radius: 0.7439707597466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953159601473398d, y: 0.1694101901799161d), radius: 0.7228452629791211d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5052816972176484d, y: 0.49717939344138096d), radius: 0.70316978123186d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6575668747023005d, y: 0.8419095763120397d), radius: 0.8101058199838662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33164489703207745d, y: 0.553685444948982d), radius: 0.13809155856048216d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.845488063176638d, y: 0.31166999730154743d), radius: 0.1462571371995779d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4045184957312348d, y: 0.22225857947155958d), radius: 0.8187600639482603d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10949359139174653d, y: 0.2500646585581756d), radius: 0.06259863012939892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5348988734255871d, y: 0.11365482643712521d), radius: 0.7674539960872043d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3447767946489755d, y: 0.10627797777194303d), radius: 0.17980090673172433d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8743074388928156d, y: 0.317764215654191d), radius: 0.40000744192704685d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34062514025999224d, y: 0.08097260176012755d), radius: 0.7117464385605765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9013628726905056d, y: 0.5818680505327303d), radius: 0.6328872381878918d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3412727753329903d, y: 0.7859333713306677d), radius: 0.6647218917089466d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9557165261795635d, y: 0.42262749787853926d), radius: 0.8118263756435605d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.574743041991961d, y: 0.9940479163075283d), radius: 0.22226775357665474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8575400182343251d, y: 0.8348612212797352d), radius: 0.1937522745850333d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5206058201284497d, y: 0.5585482493774451d), radius: 0.5279692707900868d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9834747289478677d, y: 0.5476167228231538d), radius: 0.6123198445170663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0657032994158212d, y: 0.33285291551625085d), radius: 0.6704048968211833d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7548043021059895d, y: 0.435213886187945d), radius: 0.8424149290605496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33002662146475137d, y: 0.8204719307671312d), radius: 0.3346260980380308d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07203277983248624d, y: 0.05338932382344652d), radius: 0.8430769756216501d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49276526462691184d, y: 0.1822298941354945d), radius: 0.24649653336824673d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32934966839758606d, y: 0.3445757842679763d), radius: 0.08336157249551512d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4812544284980631d, y: 0.7336280532275903d), radius: 0.7105714158144424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9751856238630314d, y: 0.09100599996451897d), radius: 0.9806880945206031d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34901280712282d, y: 0.3035333914269496d), radius: 0.7257697161270661d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8414691721140436d, y: 0.836225922895626d), radius: 0.5685375452607428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3676636044007563d, y: 0.01539256472719408d), radius: 0.08808372690172905d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9353635089409151d, y: 0.12278686427754293d), radius: 0.5745235739076345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6507051343314478d, y: 0.9897859038948666d), radius: 0.5490068852306544d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5350609094851728d, y: 0.6826087905805691d), radius: 0.7511335355337326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2614905909841263d, y: 0.7943497528324163d), radius: 0.8206816654550398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9449550532527191d, y: 0.9489226774645674d), radius: 0.4209450023400245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8229360839360788d, y: 0.22534094259682247d), radius: 0.7898060982953586d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865978105626345d, y: 0.06011762678257271d), radius: 0.09920033538125395d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0014884354804156619d, y: 0.11003945569225793d), radius: 0.40485083558413537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7367286323108878d, y: 0.4894946756315828d), radius: 0.6256419149079818d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8515841251479396d, y: 0.877874600526079d), radius: 0.2967914151420423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020196015757097507d, y: 0.330967682977943d), radius: 0.7097075323778032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5672087398518828d, y: 0.45922520380514886d), radius: 0.5525386418800323d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1838944898801267d, y: 0.8093607221139404d), radius: 0.7420446806708538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9446841350120426d, y: 0.46213326061380333d), radius: 0.9547017052978125d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25792218465802064d, y: 0.915409594956183d), radius: 0.5355330207895876d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3898730754637705d, y: 0.19455444609241135d), radius: 0.9430168045419532d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4351801330136207d, y: 0.8775066311784624d), radius: 0.6717638617106729d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8913982318630669d, y: 0.1751096182850822d), radius: 0.34974823212302886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8435699825058773d, y: 0.8859875549331392d), radius: 0.8744591543173166d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7976644582524725d, y: 0.07775724927005889d), radius: 0.09012252205778792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9315342060316555d, y: 0.35927254992276414d), radius: 0.08718690248396188d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.858111874456079d, y: 0.314182347928737d), radius: 0.6080618953134581d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11343922373088655d, y: 0.22730953614112737d), radius: 0.8469436512838505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6500447076063715d, y: 0.11976596370121417d), radius: 0.6762108419116146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27627494860555557d, y: 0.5099345743963293d), radius: 0.22444678135201657d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16284949767608314d, y: 0.5504789360586941d), radius: 0.4063845579932167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6395198513865475d, y: 0.5988529672562871d), radius: 0.2946782013660951d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3374822793212191d, y: 0.6510061803170323d), radius: 0.99627091989336d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2206715038412509d, y: 0.16221725344119997d), radius: 0.558842548780245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09968164699827975d, y: 0.6589191983124943d), radius: 0.09210847726329374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05344374265836993d, y: 0.417998144304062d), radius: 0.9321264224896052d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6487507789252543d, y: 0.9511924915560712d), radius: 0.17846512958757332d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19531063056529852d, y: 0.2674311195459602d), radius: 0.2008031053159257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7059065042802218d, y: 0.7595878278410505d), radius: 0.36934297706698416d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34214651127830575d, y: 0.9478374554537724d), radius: 0.9306336908432937d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2928324366884093d, y: 0.5071270033289037d), radius: 0.5344675027710658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6649613822074182d, y: 0.7823244861408024d), radius: 0.1708909168304461d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22692833969523896d, y: 0.04107012261496801d), radius: 0.5720602125099573d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19006950443955228d, y: 0.7934127788002575d), radius: 0.48644844203562054d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9031222645013555d, y: 0.07773066765832559d), radius: 0.10021822995989182d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7873584072337999d, y: 0.21236115885980467d), radius: 0.3931676296376343d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2537460299355546d, y: 0.18736760531650853d), radius: 0.022078709303492428d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47275862847196526d, y: 0.6168994260751993d), radius: 0.3887443125610658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.570549446362613d, y: 0.5365407215223099d), radius: 0.2705196471126873d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3189576572755314d, y: 0.2041084974066768d), radius: 0.33916336214590437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1184223960492552d, y: 0.8642000203423312d), radius: 0.43750846517313446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692749901822998d, y: 0.5687468827463548d), radius: 0.49263149084195623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15533744231786284d, y: 0.6854827081238832d), radius: 0.38204684170099146d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46364841021998193d, y: 0.1663686301138423d), radius: 0.4023713061837728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8416460196267179d, y: 0.6226713216539316d), radius: 0.4389282936640716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47651726225589197d, y: 0.08358876414526428d), radius: 0.7116416357969623d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865201123251407d, y: 0.6195964776940689d), radius: 0.6951332503648368d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4386138143598185d, y: 0.35839948862544124d), radius: 0.3688887943011384d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014482417442024054d, y: 0.4041418640354144d), radius: 0.7357550960530971d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7957213840979833d, y: 0.12888868014426547d), radius: 0.9369839315266691d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03667881649361748d, y: 0.576409192231297d), radius: 0.6423072847109508d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6083680180847754d, y: 0.23363091054732055d), radius: 0.9900633847372666d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9544765258471194d, y: 0.775300128209186d), radius: 0.6612278950604386d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6008692069760397d, y: 0.018756337693917935d), radius: 0.8857845681224221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2178258647806861d, y: 0.22195432139616522d), radius: 0.6357126231744439d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5936160502185794d, y: 0.7789225917939958d), radius: 0.9977321352018735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34391148444775854d, y: 0.7859908650154585d), radius: 0.20593898697243784d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9031372005354456d, y: 0.4403629826397666d), radius: 0.5283771354271933d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7160502017948875d, y: 0.1783859205976568d), radius: 0.5785140873049465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19974084430616157d, y: 0.99494011573277d), radius: 0.4196593248262689d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8621408925850823d, y: 0.32153377068380773d), radius: 0.6349281276467446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6321829122879883d, y: 0.9432735144043319d), radius: 0.13674963675210516d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5090865114992604d, y: 0.7222120762053871d), radius: 0.6930067173131426d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16977809482426498d, y: 0.3610930101573433d), radius: 0.5849219921800298d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9793585738155027d, y: 0.6174651183035933d), radius: 0.5443202442715397d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8195507101543924d, y: 0.40093898478507417d), radius: 0.8080648145634322d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5512209273155491d, y: 0.5401250963711915d), radius: 0.5118049947834848d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8970412387581939d, y: 0.7497164692755358d), radius: 0.5850098897673056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23727046633884108d, y: 0.8467794453995524d), radius: 0.8720081434844812d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4821181687261916d, y: 0.5281544051253261d), radius: 0.09332206162886936d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9897677483294011d, y: 0.1200090968252544d), radius: 0.3162075510488981d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8749672370881285d, y: 0.022117603176620926d), radius: 0.6757659132963875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.536381874543381d, y: 0.9729879563184907d), radius: 0.20064465185028135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6231667394900305d, y: 0.3052374242172943d), radius: 0.1639191770989099d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36053247098971253d, y: 0.5571340247046739d), radius: 0.9278059628391433d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14079733836719066d, y: 0.08426193868710707d), radius: 0.7659527314072039d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7841596468626882d, y: 0.7785401404885669d), radius: 0.12135529768791242d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7310992514993823d, y: 0.4817161118282568d), radius: 0.3804934001324287d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7700886744017761d, y: 0.608492035179872d), radius: 0.41570961943477835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04714945158116601d, y: 0.9058437568690896d), radius: 0.725724727435394d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43972008585563316d, y: 0.416885236098564d), radius: 0.21824843909695024d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9709507865027497d, y: 0.46802641682140045d), radius: 0.19014492866397692d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3240130204151921d, y: 0.48562245172589213d), radius: 0.8140839064474009d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6032178352067215d, y: 0.9195529666286414d), radius: 0.37792707003040504d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7023046711031505d, y: 0.24017205210486892d), radius: 0.658687278735322d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5837945095734222d, y: 0.809383421436294d), radius: 0.7015418876361175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9217696339610769d, y: 0.5052293411563499d), radius: 0.655981922304663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2723638152470832d, y: 0.750617956218291d), radius: 0.15261697397798113d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9793745881063611d, y: 0.678691604907429d), radius: 0.6553800866852602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.612468591678972d, y: 0.8747612168455128d), radius: 0.49797809553761696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37097120821662355d, y: 0.42109265545263597d), radius: 0.16934731623400423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7348108844149279d, y: 0.7533393499990542d), radius: 0.16812473894697533d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29544840481869405d, y: 0.016744289200711582d), radius: 0.16250351046956368d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3070319527705314d, y: 0.09326703108754453d), radius: 0.8070089541857822d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9219899633649205d, y: 0.1560209052456173d), radius: 0.6618595341449669d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2657086661137982d, y: 0.04689359655626624d), radius: 0.14023949097483912d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8561544202474134d, y: 0.8896793352111427d), radius: 0.0688179298453987d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5467276077793615d, y: 0.3823508574178345d), radius: 0.7798760228569994d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15215784376556263d, y: 0.9188789944076253d), radius: 0.531438787177049d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3544765519513846d, y: 0.24784262806916935d), radius: 0.8380892996442252d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7314587317749027d, y: 0.7408922330369332d), radius: 0.9277527657780817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35950651432253833d, y: 0.38167042292773223d), radius: 0.9178525096278065d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5362272334163517d, y: 0.034316894801784126d), radius: 0.299411257383988d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9889514499715516d, y: 0.898936838188888d), radius: 0.05749266149714072d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455784094250662d, y: 0.04827288624528747d), radius: 0.3287509469876939d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6659400131727921d, y: 0.2630456773113774d), radius: 0.3135836062290914d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5796696210201095d, y: 0.666260530614968d), radius: 0.3696171485768317d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6674608129361854d, y: 0.02269283782585363d), radius: 0.9779392764609625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8258381356424779d, y: 0.2504670266100758d), radius: 0.18887324908501957d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9418323161179027d, y: 0.23044895265331267d), radius: 0.5930999139497217d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11278727458516558d, y: 0.43639728464856276d), radius: 0.8479252370720309d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3528164751679308d, y: 0.0519844269519002d), radius: 0.1005100460391748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011559831182123115d, y: 0.7925050833899169d), radius: 0.2624133553270498d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.607172731293999d, y: 0.06904708413392191d), radius: 0.8029605993878243d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8188384383552046d, y: 0.5303631720929394d), radius: 0.40505686261528084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1523400366160942d, y: 0.9763737167453336d), radius: 0.3727915514275688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8808601229018976d, y: 0.3633653843654999d), radius: 0.9439743538627307d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6613390729511303d, y: 0.7076972633329495d), radius: 0.485183054196622d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.041060092963871586d, y: 0.6148714959457626d), radius: 0.1980868085727161d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6408786261715654d, y: 0.5521234746564353d), radius: 0.9196028690627311d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8505324113625038d, y: 0.2689737024728899d), radius: 0.18967710290514883d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5318483646016177d, y: 0.8134400766249514d), radius: 0.8913628586986777d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1636819772157515d, y: 0.8181799591901058d), radius: 0.27873740292376004d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3122736901179123d, y: 0.16508801355244984d), radius: 0.5477605411249379d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3492017666151116d, y: 0.05716087236932599d), radius: 0.02442902299482197d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5224385518122671d, y: 0.6133985255471299d), radius: 0.1457410918618457d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0774761180369834d, y: 0.38220875147401345d), radius: 0.454130956853421d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.673411702395522d, y: 0.49020792486482545d), radius: 0.053064431208838525d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15331602229920893d, y: 0.7429232900666057d), radius: 0.24769606401638677d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28190489098679805d, y: 0.2926587945396464d), radius: 0.9162460388768158d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14578816484746604d, y: 0.9540490517981574d), radius: 0.4471595939418329d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.800730794825749d, y: 0.4342031051438119d), radius: 0.5581712514051087d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.661007412908469d, y: 0.9199741075458094d), radius: 0.4234095510370286d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04081928292790182d, y: 0.14705044947043944d), radius: 0.9051183956009673d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8042230038226438d, y: 0.6590665268613173d), radius: 0.505632043298997d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413037467760965d, y: 0.31782328075449084d), radius: 0.2991639076534732d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8755147667728561d, y: 0.33512230045553904d), radius: 0.35993093997564696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6969871796990188d, y: 0.8833286874932154d), radius: 0.9007423923342286d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9318615325513364d, y: 0.5468006209113989d), radius: 0.7859150933009946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8520246978781357d, y: 0.9411617212971631d), radius: 0.35141035636868145d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.127952209162858d, y: 0.16125034862422238d), radius: 0.7853972068097724d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8386544756752978d, y: 0.08711568003154369d), radius: 0.42181877623877706d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7899638592503356d, y: 0.48758060938540204d), radius: 0.31177150716708046d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8167851431503388d, y: 0.90452310392759d), radius: 0.9617776908392917d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8013863158880666d, y: 0.4994913969901631d), radius: 0.10474154478675102d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757021195429705d, y: 0.7705913766534356d), radius: 0.6084369279163835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5650195848077629d, y: 0.22812688884979226d), radius: 0.2589807789783879d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5645991649238615d, y: 0.10448555362313972d), radius: 0.22775165725265423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7389675694546737d, y: 0.8049341498473437d), radius: 0.7839247102335682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8851984164944189d, y: 0.8838223495492605d), radius: 0.9192869648780623d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18709148284260702d, y: 0.19786642237812258d), radius: 0.5502957253816776d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05050982033212614d, y: 0.7369736056501761d), radius: 0.6628137214167528d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5760218350304563d, y: 0.25853434043356616d), radius: 0.30440547617407687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9127679042670083d, y: 0.0286113455891035d), radius: 0.741160771016751d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08714640011560204d, y: 0.17753259899057294d), radius: 0.6528079507811229d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5203728467664034d, y: 0.8499239198790504d), radius: 0.606825021564119d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4650237918246226d, y: 0.4708891490119753d), radius: 0.9160540275873718d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5573110411926755d, y: 0.11142909078798535d), radius: 0.3239220164444474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1273102762463576d, y: 0.9825727412896758d), radius: 0.7611947068025142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9550068921982843d, y: 0.8503259999240791d), radius: 0.44637532798885016d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4734885641505019d, y: 0.43354925696865765d), radius: 0.6361626082784674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5944003642246318d, y: 0.4172765997534189d), radius: 0.5036454070656027d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1810565277141709d, y: 0.9318469792394412d), radius: 0.5203546914734617d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2970629270130952d, y: 0.11573723067535013d), radius: 0.001154047285681692d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20221263161036218d, y: 0.1951317855642567d), radius: 0.31893944577902367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20874322414644764d, y: 0.04340896827522478d), radius: 0.9430225070508732d),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
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
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667522286799569d, y: 0.547585159898531d), radius: 0.7439707597466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6953159601473398d, y: 0.1694101901799161d), radius: 0.7228452629791211d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5052816972176484d, y: 0.49717939344138096d), radius: 0.70316978123186d),
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9557165261795635d, y: 0.42262749787853926d), radius: 0.8118263756435605d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.574743041991961d, y: 0.9940479163075283d), radius: 0.22226775357665474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8575400182343251d, y: 0.8348612212797352d), radius: 0.1937522745850333d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5206058201284497d, y: 0.5585482493774451d), radius: 0.5279692707900868d),
}));
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5350609094851728d, y: 0.6826087905805691d), radius: 0.7511335355337326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2614905909841263d, y: 0.7943497528324163d), radius: 0.8206816654550398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9449550532527191d, y: 0.9489226774645674d), radius: 0.4209450023400245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8229360839360788d, y: 0.22534094259682247d), radius: 0.7898060982953586d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3898730754637705d, y: 0.19455444609241135d), radius: 0.9430168045419532d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4351801330136207d, y: 0.8775066311784624d), radius: 0.6717638617106729d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8913982318630669d, y: 0.1751096182850822d), radius: 0.34974823212302886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8435699825058773d, y: 0.8859875549331392d), radius: 0.8744591543173166d),
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
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11343922373088655d, y: 0.22730953614112737d), radius: 0.8469436512838505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6500447076063715d, y: 0.11976596370121417d), radius: 0.6762108419116146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27627494860555557d, y: 0.5099345743963293d), radius: 0.22444678135201657d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2928324366884093d, y: 0.5071270033289037d), radius: 0.5344675027710658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6649613822074182d, y: 0.7823244861408024d), radius: 0.1708909168304461d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22692833969523896d, y: 0.04107012261496801d), radius: 0.5720602125099573d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 44, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 113, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 113, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

