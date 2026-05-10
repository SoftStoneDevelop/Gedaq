

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1726048387519169d, y: 0.5361007003684424d), radius: 0.39056895992229446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8045973554756847d, y: 0.21276975577095225d), radius: 0.24471407283893265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.960713160266128d, y: 0.8834428879202353d), radius: 0.021579154762329855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4479178429443951d, y: 0.2935420048414038d), radius: 0.34411444158979165d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8823948615895083d, y: 0.41429661821165464d), radius: 0.8415046294364955d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873571232402412d, y: 0.8775847955053986d), radius: 0.12079591690116587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8040143407794205d, y: 0.45764422161458396d), radius: 0.7745668888278695d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24871091001089507d, y: 0.3404493314073388d), radius: 0.3883440301467327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17233241015066136d, y: 0.054999533537418155d), radius: 0.8788753780287607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5658095443258323d, y: 0.3376577172539459d), radius: 0.5466588502365243d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05519024946302409d, y: 0.11648337846287271d), radius: 0.5376408589929756d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7671370677648625d, y: 0.7800465552886228d), radius: 0.9088606525661055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0343530957152004d, y: 0.6032140813562884d), radius: 0.059096412901773365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38391947005163973d, y: 0.8114991268338447d), radius: 0.8376243389648628d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8446984500203292d, y: 0.39859379201172884d), radius: 0.79465593172063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8843611046615344d, y: 0.2517892651971464d), radius: 0.4066618764174431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5534025929470253d, y: 0.4321440755182865d), radius: 0.005583325698739761d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7553901784392046d, y: 0.3667217013821046d), radius: 0.21446735819011453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.426177769766826d, y: 0.8352448400537807d), radius: 0.4725422353449973d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4882703290708116d, y: 0.33124145248129033d), radius: 0.6181696365385532d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9702555368100054d, y: 0.7928790449628997d), radius: 0.6465024819706869d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6793218347735293d, y: 0.8499412128536087d), radius: 0.3856150098790788d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.57919598928083d, y: 0.7239863353064455d), radius: 0.9867650680943373d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6470014609752941d, y: 0.8098937036500061d), radius: 0.8259543831397953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8955759880270417d, y: 0.5536609298833218d), radius: 0.28757742997904234d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7262524677498522d, y: 0.828065401076275d), radius: 0.8838857953851544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2978751324008929d, y: 0.3318503498970343d), radius: 0.9694537941047985d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5706822137347912d, y: 0.3474087043223195d), radius: 0.7569852656104736d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031015019207883854d, y: 0.7820154616511762d), radius: 0.42203617475756827d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9845878095666621d, y: 0.9800152667148709d), radius: 0.7719383922198678d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9894864128548101d, y: 0.0304668534825705d), radius: 0.4787400685159352d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8729054368407324d, y: 0.01444992429731462d), radius: 0.7449899491378583d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8680531512643934d, y: 0.6909888335323195d), radius: 0.2864037368982342d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13168365543938854d, y: 0.15847905706197418d), radius: 0.02268502250913662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13032170828805645d, y: 0.1709182443316466d), radius: 0.7847633259244335d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7767132716107404d, y: 0.8010610587843131d), radius: 0.5586260332881843d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9969400036062821d, y: 0.5037755228494154d), radius: 0.2227650522825152d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.249761215772195d, y: 0.12047221714679734d), radius: 0.3296122453993767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11207010059867395d, y: 0.20167003689728924d), radius: 0.643229821143675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2600905060922568d, y: 0.7698156076909936d), radius: 0.7135883085740706d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8626078845200577d, y: 0.855274406694245d), radius: 0.9982506734390759d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02153072174449666d, y: 0.4163986764229375d), radius: 0.22683231125289127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04098022318091088d, y: 0.4791760585067243d), radius: 0.18900165408034852d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6268671131635897d, y: 0.7399950782769908d), radius: 0.4969970767204469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26986792462584286d, y: 0.04560196391743321d), radius: 0.44067628706705375d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06828378033891869d, y: 0.668358579137107d), radius: 0.9922638795002781d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.850863864049694d, y: 0.07356319069751649d), radius: 0.5095234376621104d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9086121322045945d, y: 0.622381677622278d), radius: 0.30279861733990043d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4766770950221024d, y: 0.5758606364788735d), radius: 0.9162205643130378d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49168629198165026d, y: 0.1877525386914628d), radius: 0.9173787129439309d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15528270779787767d, y: 0.2910702802259747d), radius: 0.03231878770041885d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7202240929033821d, y: 0.5350073237724263d), radius: 0.2990700730538287d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49972962865696424d, y: 0.9853048505176181d), radius: 0.34651758600701754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00013757187019514117d, y: 0.14285772477637537d), radius: 0.2051622044535658d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6741187006772751d, y: 0.19139123961426197d), radius: 0.2889758117065996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4871360537044175d, y: 0.9555858234796234d), radius: 0.4212629579384446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8197270311674835d, y: 0.874161602367651d), radius: 0.7626110098884189d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0710193253191953d, y: 0.5890053116915721d), radius: 0.19986897685738103d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20418691547851708d, y: 0.9598562560208723d), radius: 0.33165040295182346d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5832341998436118d, y: 0.4714878685706124d), radius: 0.27153124967713815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8225164522244801d, y: 0.016359845568765685d), radius: 0.7088173227323792d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8605857250548425d, y: 0.14761040270288717d), radius: 0.4939910757736997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9652327865692535d, y: 0.6681894637704835d), radius: 0.39339241086084153d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8126200073905538d, y: 0.21731150153629952d), radius: 0.35336490571602996d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8080883386628299d, y: 0.9379523949734802d), radius: 0.4863987367297513d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.897342294203079d, y: 0.87353732420146d), radius: 0.592794231323005d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8870706300874618d, y: 0.991231254646804d), radius: 0.09758906415794144d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33441641579774084d, y: 0.04530846121863963d), radius: 0.04654340461768247d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3432960561920436d, y: 0.9331678308916267d), radius: 0.8704849582608771d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.288780529274708d, y: 0.643643890010892d), radius: 0.09604050301849754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4335504858141229d, y: 0.5742038631732781d), radius: 0.8751514774487182d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33301339843003785d, y: 0.7258088402799473d), radius: 0.889452521766702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.285296233591549d, y: 0.8625616134345068d), radius: 0.027143732304790502d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04940443439007047d, y: 0.5137960560559321d), radius: 0.6860791145870151d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7482499474551189d, y: 0.6610585967589038d), radius: 0.8403259921175417d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06796830434985934d, y: 0.6565814877256524d), radius: 0.30680871575990953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6642084923892227d, y: 0.7092854301285247d), radius: 0.44410366136817225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25822330408119354d, y: 0.4982437282364284d), radius: 0.46370392294735774d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9931840209328985d, y: 0.7847371106587776d), radius: 0.7917564966475479d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8572250091042404d, y: 0.46977369990179196d), radius: 0.6928616358111273d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2444788253796032d, y: 0.6540429609191469d), radius: 0.392307997570022d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6059856459386783d, y: 0.3260205322011974d), radius: 0.3169564707366016d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11640408582097583d, y: 0.8970929308426475d), radius: 0.6420333705984842d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05591090690229816d, y: 0.5348274142203377d), radius: 0.719578205174839d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7578616339373105d, y: 0.49195284617238977d), radius: 0.4166353513212989d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5247084025148774d, y: 0.24462957900533755d), radius: 0.09714078141349392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11220383103929765d, y: 0.7555696588719447d), radius: 0.27813547995213006d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7825697606738578d, y: 0.35354981217425974d), radius: 0.5202746327791006d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06528131832546658d, y: 0.4627967183410273d), radius: 0.8471753141524766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32783564349522987d, y: 0.33936541870316383d), radius: 0.07995204332354677d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23279498385457953d, y: 0.675042995473368d), radius: 0.021113859281431502d),
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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7818851022777378d, y: 0.19004751587936375d), radius: 0.6114820726776043d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2328656016079793d, y: 0.5016789296418223d), radius: 0.45236931457323903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7662171553698143d, y: 0.28018838524709777d), radius: 0.5281343447127164d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8180797468727078d, y: 0.1423758276484366d), radius: 0.3114702363835725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24038056092660387d, y: 0.563447579390327d), radius: 0.9169081408612307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005247425606282441d, y: 0.6416135248096382d), radius: 0.1493203928064576d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36348113066539245d, y: 0.44380658143599583d), radius: 0.22322562644974653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8601356597508465d, y: 0.03010433614856345d), radius: 0.43981319720679857d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28011021690772675d, y: 0.6389423427794239d), radius: 0.39976979364371434d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11565108589438255d, y: 0.553104971580425d), radius: 0.1546571796740469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.737667894153219d, y: 0.7357831360017585d), radius: 0.06617181670969008d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5104199341674943d, y: 0.021323992151910498d), radius: 0.294820579498528d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6297740717883932d, y: 0.44142457906928345d), radius: 0.2612145391871591d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.270030213052339d, y: 0.5900638327880672d), radius: 0.922748903277041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16622998055574123d, y: 0.5568889525696855d), radius: 0.645515338679781d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6794538929302247d, y: 0.718048925892477d), radius: 0.9595557788625714d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0359033176844733d, y: 0.0013531485487633388d), radius: 0.24298151998871265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425404228770871d, y: 0.014570315576230009d), radius: 0.15517021266283637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2678171859258557d, y: 0.7433277563202908d), radius: 0.9400740888789134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10410364082128964d, y: 0.729868500404378d), radius: 0.34739745424979296d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40001626549344194d, y: 0.8160949722931499d), radius: 0.30701845343266754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4686688049762604d, y: 0.8882347077669229d), radius: 0.3484243915988472d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2405338715537707d, y: 0.14282182439057456d), radius: 0.23104140083304203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5015956124195603d, y: 0.2659984053470389d), radius: 0.8229622544998411d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33152140970468547d, y: 0.11604877352761878d), radius: 0.17495166581317767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31102921125616956d, y: 0.11170529711793586d), radius: 0.7777154458357681d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9225279627184897d, y: 0.707416724297598d), radius: 0.328656788442411d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7764858034959904d, y: 0.1718288399409238d), radius: 0.837763443494597d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6023928713104073d, y: 0.5849999955698765d), radius: 0.7518190008561583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7452958334509447d, y: 0.6812134577851847d), radius: 0.5894227124947001d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6218165529333011d, y: 0.2708310797846645d), radius: 0.8570359276890721d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19474844722914897d, y: 0.6592708185318492d), radius: 0.3258077673975508d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3444095148578512d, y: 0.44911314078681297d), radius: 0.03007682892546748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35934273679066764d, y: 0.3192233986841515d), radius: 0.7670215596872809d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8538576801515704d, y: 0.9993992808555425d), radius: 0.6717606600835092d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04296628267862368d, y: 0.17510825928610274d), radius: 0.2863725233977118d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34914869816841587d, y: 0.46129372198599217d), radius: 0.3131469377940317d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7317253205083415d, y: 0.3876796669773721d), radius: 0.9088203701465738d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.593632204247641d, y: 0.28863574107234957d), radius: 0.6679080096018241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48882158594233827d, y: 0.13985469180320864d), radius: 0.38727341977927776d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7468568565392462d, y: 0.8312555145604753d), radius: 0.3000779827411483d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5782644156268415d, y: 0.9771272444416489d), radius: 0.583179949305687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36241330146275785d, y: 0.5323956009789869d), radius: 0.24989307443226505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8590721842150302d, y: 0.587866074571853d), radius: 0.8091160525673019d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06989897673287127d, y: 0.9855887728217451d), radius: 0.21382797892705507d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7619452716167284d, y: 0.7566321671517532d), radius: 0.4151402220075221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12638051745186352d, y: 0.478184341079507d), radius: 0.13710486896738494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7944682602160765d, y: 0.19820542361763072d), radius: 0.2331070929507717d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.948245479886037d, y: 0.4649350758430921d), radius: 0.903442561990053d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5813687594173486d, y: 0.3751768873145387d), radius: 0.14384575992784832d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9376433972010702d, y: 0.9934918682787065d), radius: 0.6121653374874352d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2616807333282587d, y: 0.8989955781598998d), radius: 0.566094686759273d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4398811071285592d, y: 0.7451842919821534d), radius: 0.7756428422916737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7137927109816588d, y: 0.8160074966868361d), radius: 0.7337164129454019d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6547230077752872d, y: 0.2440124097067008d), radius: 0.8316116917241029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13718226783713727d, y: 0.48820127335683605d), radius: 0.49930203618342994d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07097012387163726d, y: 0.6208417611834356d), radius: 0.2629175457441417d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732181826320927d, y: 0.23375807668635518d), radius: 0.8784954321548425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18185852610985775d, y: 0.7185459832803635d), radius: 0.17269230833479987d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9529787020560155d, y: 0.8139252857514339d), radius: 0.29562797844478195d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5118945923671625d, y: 0.11313386142871151d), radius: 0.2583417640862783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31039873168386234d, y: 0.7924194192715335d), radius: 0.8077080747253058d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5312307641373898d, y: 0.5427866855826995d), radius: 0.6109181700964411d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.921054842295233d, y: 0.14001897361199545d), radius: 0.6170792743548502d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15686567719641054d, y: 0.36981957618302874d), radius: 0.32869943325779627d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8939240702720072d, y: 0.8721694442159594d), radius: 0.442235430819359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8452961509828959d, y: 0.3232193042161239d), radius: 0.09485586044943428d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5662991361196927d, y: 0.07709220060939703d), radius: 0.2406224168815182d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3447569238279441d, y: 0.9395802100823831d), radius: 0.735338576366163d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8024130086699549d, y: 0.3343772796768403d), radius: 0.2583027272605666d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36106446119800917d, y: 0.6446709569582808d), radius: 0.1651934957282326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09184610638351964d, y: 0.27060371532983396d), radius: 0.7728861609549403d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12820235726555418d, y: 0.9468704260368564d), radius: 0.5021712460016114d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6602509955926308d, y: 0.4512924907105921d), radius: 0.06913763748115243d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07637914297588211d, y: 0.9064000369594583d), radius: 0.09564218583468365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7201328395148195d, y: 0.2512231311540838d), radius: 0.7534534025953313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4636746167393577d, y: 0.8778329150357014d), radius: 0.37300608246343225d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9473881949011456d, y: 0.8513516631466679d), radius: 0.7390199321885339d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6638032682293452d, y: 0.40724156020364766d), radius: 0.895386924420141d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29512332414848463d, y: 0.4151286023628131d), radius: 0.6467017416597701d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6476703904175533d, y: 0.5634605420766167d), radius: 0.1173829683391352d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6178464157873381d, y: 0.45363399278175764d), radius: 0.5762579593590671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24328882504359117d, y: 0.33935545487877905d), radius: 0.4217755781691702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14377474758282238d, y: 0.2455442899783199d), radius: 0.04285026610470388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4042964109369348d, y: 0.33545754645882064d), radius: 0.539219022002564d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4431573979896307d, y: 0.986386163260074d), radius: 0.679919426001523d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6966790660277921d, y: 0.10693080052432558d), radius: 0.5882775878914484d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3958111587347748d, y: 0.44468551932626077d), radius: 0.4382208208746612d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6435279224329769d, y: 0.71857554537493d), radius: 0.5770556875525402d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10085392372668878d, y: 0.06629773164224884d), radius: 0.050185672817652294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5629622463746137d, y: 0.4578340285277469d), radius: 0.15902676206619182d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01623326762012589d, y: 0.03368149167051382d), radius: 0.24281383303725057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3192413457186245d, y: 0.7705070125687843d), radius: 0.07777033669276301d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5417120940424277d, y: 0.37909072770512753d), radius: 0.2607962102578548d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5789321748797863d, y: 0.15966326078234316d), radius: 0.16983992214007815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4990012758374581d, y: 0.9038227111525218d), radius: 0.9195960369683838d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4348800974468826d, y: 0.6515986158426131d), radius: 0.9473028323639817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12188361622686228d, y: 0.13667301452057135d), radius: 0.5843371905737944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4434790900031922d, y: 0.2729781449897034d), radius: 0.3629716715390867d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7213391776987317d, y: 0.7070518101184718d), radius: 0.9735817323970137d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12674577330144698d, y: 0.4222718504994757d), radius: 0.433812557102613d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.87503693893731d, y: 0.6322694569653989d), radius: 0.4283621726352598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7591192638779225d, y: 0.5134034256955564d), radius: 0.17697566318328972d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1883923835086614d, y: 0.08648099778583362d), radius: 0.09540470147054358d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013131143478070872d, y: 0.4539083235704302d), radius: 0.171040360383105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4490316001878586d, y: 0.28046589320032433d), radius: 0.23423546062296496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6433264724304095d, y: 0.46010034231389374d), radius: 0.35411152819632086d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8915842255362815d, y: 0.2538240764139449d), radius: 0.5563918718408547d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9846044658431522d, y: 0.284284571441091d), radius: 0.4496670708644124d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5011994664979741d, y: 0.8695898675211312d), radius: 0.10733809378670367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.995024284619341d, y: 0.09147110990878582d), radius: 0.6180505738110723d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2624837071670475d, y: 0.60231093575805d), radius: 0.8750143686555383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5254326864915394d, y: 0.7154571109283359d), radius: 0.3718108812127845d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.648337322719832d, y: 0.7322953208210419d), radius: 0.8281699531838218d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16852672308790706d, y: 0.44992961877453563d), radius: 0.795452883650373d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6528509594006469d, y: 0.5525991145537387d), radius: 0.10377683828933026d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6750919566327664d, y: 0.3490344910793862d), radius: 0.07989294010594383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38605854978020027d, y: 0.20018188717588536d), radius: 0.46392321132416015d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8243377319208584d, y: 0.39097274217300815d), radius: 0.2952490390876029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083779680424547d, y: 0.991828542541614d), radius: 0.9640684201359764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2537892659388611d, y: 0.3185836241864861d), radius: 0.7869745122612165d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1990426429301374d, y: 0.5040138625100546d), radius: 0.22987174952760292d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8935663879648269d, y: 0.9510650696981783d), radius: 0.7293803795049334d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9421129570603631d, y: 0.11840185772128375d), radius: 0.6197427340368581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9126379597781907d, y: 0.766638317589931d), radius: 0.5660417609234724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9500863003178215d, y: 0.4552332467407446d), radius: 0.9394157506782681d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3290968470786141d, y: 0.5202938643249435d), radius: 0.4376947809719782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43073097308082575d, y: 0.83346543108078d), radius: 0.9778824508105751d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9594932338979614d, y: 0.8822951937175911d), radius: 0.32309725003469114d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.044793135202437995d, y: 0.4453923793111574d), radius: 0.8881501187036575d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.777441331086211d, y: 0.9728333292995888d), radius: 0.7253501589612813d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.042926892975383324d, y: 0.45617184397228505d), radius: 0.38926775575928285d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4627764931162386d, y: 0.6645083387863715d), radius: 0.0566440579715769d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20185605271692397d, y: 0.8755676251277317d), radius: 0.15200625473772011d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.525600060174789d, y: 0.053834436140304254d), radius: 0.38403012499551115d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.571319907019738d, y: 0.6794444334639621d), radius: 0.4433189587163734d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4762545929395776d, y: 0.52881105534429d), radius: 0.5227424258333953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24279279074815063d, y: 0.9752199716163236d), radius: 0.7768995050916188d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1388843409687437d, y: 0.8042518014214401d), radius: 0.7150566775811339d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7721109631759593d, y: 0.2860438770284981d), radius: 0.5417706833151148d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3927968475235559d, y: 0.5662816800158736d), radius: 0.5435349875947803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1029598768899932d, y: 0.820553776727966d), radius: 0.8013369906021095d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9891227960733151d, y: 0.7152737080624453d), radius: 0.7741368525924668d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3436711474480154d, y: 0.4935208156569062d), radius: 0.48121954580882775d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14476671512605976d, y: 0.3953671817536095d), radius: 0.6471862692547221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020454465877507322d, y: 0.3574434211308568d), radius: 0.05532298034220706d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8774259985337871d, y: 0.6982881284527146d), radius: 0.2806092501343115d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7351692244295925d, y: 0.43047750661582784d), radius: 0.7129697679910764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3487245642471021d, y: 0.5255246709614646d), radius: 0.20671687002875005d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16168821086135476d, y: 0.9036395685809271d), radius: 0.05709040141468913d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6327013801874101d, y: 0.25103345492345475d), radius: 0.4970919956877936d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.444443151814937d, y: 0.21180889479018017d), radius: 0.24260624903790318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05042362936183353d, y: 0.22377131510568182d), radius: 0.0435401688534921d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1281622163289139d, y: 0.21797175962100046d), radius: 0.997288239706217d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43555414072542764d, y: 0.6122641450017614d), radius: 0.24108652324567703d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7734765437403602d, y: 0.34134150324179124d), radius: 0.1934236296463675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8317123544370997d, y: 0.9449231484969604d), radius: 0.0958047386974974d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18224594348740042d, y: 0.2139605692172315d), radius: 0.13692773337697262d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5731721561974604d, y: 0.8201646344502467d), radius: 0.08851808836215014d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4444731082594967d, y: 0.1547035470834427d), radius: 0.24591508924683814d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45904779313619204d, y: 0.8412780019384176d), radius: 0.3242127228357845d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48521297489263426d, y: 0.9008199828303411d), radius: 0.13515396031390037d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09532342510071234d, y: 0.9558551777031201d), radius: 0.7973238964475713d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24419901528105892d, y: 0.828566884103583d), radius: 0.678208875051407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09653515672546442d, y: 0.11076937101144102d), radius: 0.46526589818209607d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4071521923137338d, y: 0.531403567269524d), radius: 0.06468234629445946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.501303315441698d, y: 0.26449978050858214d), radius: 0.7375154466556714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.763389594281416d, y: 0.582037951287141d), radius: 0.8338479677810476d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7707430596887767d, y: 0.9196818964681368d), radius: 0.09294306398596441d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2714350813608234d, y: 0.9045398622341635d), radius: 0.755021283687645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1805791236386911d, y: 0.7782522146671313d), radius: 0.4332656577278122d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10351476193953413d, y: 0.7357800103941324d), radius: 0.16770818542343147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3660783369988422d, y: 0.7967486859163565d), radius: 0.9397190916283834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9435118659270981d, y: 0.39982731563372653d), radius: 0.6271201276689949d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04258308193624294d, y: 0.5869239450884646d), radius: 0.35944680394569684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6111741913657561d, y: 0.26857421434857487d), radius: 0.4558129094809852d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8806795016783754d, y: 0.6451836006936496d), radius: 0.3040122868965096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0487124471102367d, y: 0.524135517161815d), radius: 0.7043326547008308d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5293100570447041d, y: 0.6199590288096126d), radius: 0.3767673251063941d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6341982150246809d, y: 0.9594964872723384d), radius: 0.16981801668255359d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49916932478419274d, y: 0.2700873179613871d), radius: 0.842795046044109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24563108868186445d, y: 0.7118914775004596d), radius: 0.6299899019058184d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11698865202329889d, y: 0.48018299380603924d), radius: 0.9803379411705914d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36011691072748286d, y: 0.32625104804781246d), radius: 0.3558453398395568d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39309315902215214d, y: 0.09071453820519781d), radius: 0.2539329432641221d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5957903889956107d, y: 0.9365785284682482d), radius: 0.4297538261544154d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9417411211282158d, y: 0.8297317061474366d), radius: 0.13026842717194131d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44603074672523446d, y: 0.16507509670237908d), radius: 0.5818363646389085d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16051492942391643d, y: 0.6148821879926167d), radius: 0.32026090558530385d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4523129495159224d, y: 0.21337243601518951d), radius: 0.8664890776732577d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.507938033595695d, y: 0.2819277340364513d), radius: 0.5118085583596366d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5615680852426477d, y: 0.5931181485752162d), radius: 0.9854508556459942d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6883169629214404d, y: 0.9988487842714809d), radius: 0.9255615861814384d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030827497016104d, y: 0.012513061321944186d), radius: 0.7211131167825174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06793939754794598d, y: 0.5568440181227075d), radius: 0.7694297988449413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4510076951629244d, y: 0.5999054400948819d), radius: 0.9565673270921343d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34294534231375495d, y: 0.47619705102679233d), radius: 0.05329675786054566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9749908134874535d, y: 0.34066355234010925d), radius: 0.9355715545274353d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6064043987186721d, y: 0.6200759238060016d), radius: 0.46737653372436094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9561893029552082d, y: 0.9096576749045201d), radius: 0.2136962149076862d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5396618623418907d, y: 0.2764913931053875d), radius: 0.055918518309925d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4633363103602254d, y: 0.9984848759669077d), radius: 0.3692772462703431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4786546127634145d, y: 0.24881565560461838d), radius: 0.3492635881992615d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37337977352663165d, y: 0.01774578646548164d), radius: 0.9695199964278528d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7073097799924328d, y: 0.4442403578470825d), radius: 0.45343773564801726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7270526638704441d, y: 0.8007729307615615d), radius: 0.8537385782709067d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9862369354266518d, y: 0.38341334649573355d), radius: 0.9059927195446261d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6267927783029875d, y: 0.5444986614354813d), radius: 0.49478493450774674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3704241780915283d, y: 0.6030485087282302d), radius: 0.9359861039079007d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5959753867158943d, y: 0.6481139824572756d), radius: 0.9874176437165888d),
},
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8626078845200577d, y: 0.855274406694245d), radius: 0.9982506734390759d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02153072174449666d, y: 0.4163986764229375d), radius: 0.22683231125289127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04098022318091088d, y: 0.4791760585067243d), radius: 0.18900165408034852d),
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20418691547851708d, y: 0.9598562560208723d), radius: 0.33165040295182346d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5832341998436118d, y: 0.4714878685706124d), radius: 0.27153124967713815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8225164522244801d, y: 0.016359845568765685d), radius: 0.7088173227323792d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33441641579774084d, y: 0.04530846121863963d), radius: 0.04654340461768247d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3432960561920436d, y: 0.9331678308916267d), radius: 0.8704849582608771d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.288780529274708d, y: 0.643643890010892d), radius: 0.09604050301849754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4335504858141229d, y: 0.5742038631732781d), radius: 0.8751514774487182d),
}));
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
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06796830434985934d, y: 0.6565814877256524d), radius: 0.30680871575990953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6642084923892227d, y: 0.7092854301285247d), radius: 0.44410366136817225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25822330408119354d, y: 0.4982437282364284d), radius: 0.46370392294735774d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5247084025148774d, y: 0.24462957900533755d), radius: 0.09714078141349392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11220383103929765d, y: 0.7555696588719447d), radius: 0.27813547995213006d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7825697606738578d, y: 0.35354981217425974d), radius: 0.5202746327791006d),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 125, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[34], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[34], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 132, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 123, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
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
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

