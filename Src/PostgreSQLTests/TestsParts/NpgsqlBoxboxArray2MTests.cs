

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9366309650385122d,right: 0.9770171672707642d,bottom: 0.10758700981427727d,left: 0.6724371947114022d),

new NpgsqlTypes.NpgsqlBox(top: 0.8100209163309153d,right: 0.6778824522107428d,bottom: 0.33926151621468204d,left: 0.4478784887342614d),

new NpgsqlTypes.NpgsqlBox(top: 0.38543245511791147d,right: 0.776727757423744d,bottom: 0.31974341320002175d,left: 0.16583308377296457d),

new NpgsqlTypes.NpgsqlBox(top: 0.42659301654606463d,right: 0.9881079793842137d,bottom: 0.36948111544966356d,left: 0.24051781833409736d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1813978915266684d,right: 0.6747727790523094d,bottom: 0.058867757016052846d,left: 0.4308318225355263d),

new NpgsqlTypes.NpgsqlBox(top: 0.9672839505876591d,right: 0.8806570463014285d,bottom: 0.264001960548674d,left: 0.13332094596491395d),

new NpgsqlTypes.NpgsqlBox(top: 0.433455499045854d,right: 0.7593694219295063d,bottom: 0.3345661080481622d,left: 0.055054993953441045d),

new NpgsqlTypes.NpgsqlBox(top: 0.611290150870059d,right: 0.776967799714624d,bottom: 0.05658184031864899d,left: 0.4876434764383524d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9107727499348283d,right: 0.6438051513320046d,bottom: 0.0004839489949776121d,left: 0.5820453331805344d),

new NpgsqlTypes.NpgsqlBox(top: 0.9443367510205944d,right: 0.8737196242695864d,bottom: 0.25739210757454634d,left: 0.5671705067244532d),

new NpgsqlTypes.NpgsqlBox(top: 0.4498991339750531d,right: 0.6859388614569374d,bottom: 0.3708834868633558d,left: 0.15376302484682014d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3513810102727515d,right: 0.7871142313863438d,bottom: 0.26577424693210916d,left: 0.752686909738075d),

new NpgsqlTypes.NpgsqlBox(top: 0.49944849572384886d,right: 0.6269979255105833d,bottom: 0.49005116174070773d,left: 0.18939368716096738d),

new NpgsqlTypes.NpgsqlBox(top: 0.6195588855051377d,right: 0.48047705716179956d,bottom: 0.1971280440456673d,left: 0.41211221266471587d),

new NpgsqlTypes.NpgsqlBox(top: 0.9801561980742644d,right: 0.3221883353141596d,bottom: 0.7505782105779953d,left: 0.30149089512262395d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.600532698118052d,right: 0.7651696699414536d,bottom: 0.22561234747936243d,left: 0.7437051983069802d),

new NpgsqlTypes.NpgsqlBox(top: 0.539032311613938d,right: 0.2288457911623023d,bottom: 0.33791111445261135d,left: 0.17024338160897623d),

new NpgsqlTypes.NpgsqlBox(top: 0.23046679156160577d,right: 0.44934235746186346d,bottom: 0.10095354835389281d,left: 0.3595483040700953d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4331017397758792d,right: 0.9566265072267417d,bottom: 0.4118026625509734d,left: 0.39595869922893434d),

new NpgsqlTypes.NpgsqlBox(top: 0.6806586967511589d,right: 0.8384706001703683d,bottom: 0.11903643195902347d,left: 0.4506590535577073d),

new NpgsqlTypes.NpgsqlBox(top: 0.5009738116500696d,right: 0.9992637717435002d,bottom: 0.2318191720406555d,left: 0.9584004488414d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9231182798378041d,right: 0.8554130871028087d,bottom: 0.8750384825910436d,left: 0.06355046511058948d),

new NpgsqlTypes.NpgsqlBox(top: 0.46930893962033626d,right: 0.8256926133862237d,bottom: 0.11791712334396398d,left: 0.2062701923865421d),

new NpgsqlTypes.NpgsqlBox(top: 0.05522083576824721d,right: 0.9663998000449162d,bottom: 0.023530069829134304d,left: 0.9090300133529057d),

new NpgsqlTypes.NpgsqlBox(top: 0.29382703361716855d,right: 0.8638939537461902d,bottom: 0.2562330651409638d,left: 0.4719544018962982d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7998314295855189d,right: 0.541764418417127d,bottom: 0.7491531195307713d,left: 0.4762463362739122d),

new NpgsqlTypes.NpgsqlBox(top: 0.7007712783754952d,right: 0.8924543440945615d,bottom: 0.034411340669626145d,left: 0.10385939010131473d),

new NpgsqlTypes.NpgsqlBox(top: 0.9427597820849785d,right: 0.6117495471555977d,bottom: 0.8379295918697524d,left: 0.37621225267963543d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6792327966029179d,right: 0.7596410916615554d,bottom: 0.12792229386423715d,left: 0.6062080921867327d),

new NpgsqlTypes.NpgsqlBox(top: 0.2445180037869803d,right: 0.5675300067586219d,bottom: 0.18642165450710768d,left: 0.5605859402751914d),

new NpgsqlTypes.NpgsqlBox(top: 0.8099062423342057d,right: 0.5314519659724537d,bottom: 0.0741055722912708d,left: 0.4471234802377576d),

new NpgsqlTypes.NpgsqlBox(top: 0.7366428657511779d,right: 0.7925850508434711d,bottom: 0.025666150969340662d,left: 0.651467418857127d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8864155170536683d,right: 0.9303808359380927d,bottom: 0.1501258675412983d,left: 0.1654462669432255d),

new NpgsqlTypes.NpgsqlBox(top: 0.435480517258087d,right: 0.946980432600886d,bottom: 0.1429270429953543d,left: 0.9355984542810621d),

new NpgsqlTypes.NpgsqlBox(top: 0.7251237047883491d,right: 0.9921268734573887d,bottom: 0.6912970807678244d,left: 0.5974354005900205d),

new NpgsqlTypes.NpgsqlBox(top: 0.5932238915522215d,right: 0.8127832230857549d,bottom: 0.3773594397908536d,left: 0.14093598106142957d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8514340221546383d,right: 0.9711511588944779d,bottom: 0.5623512648778047d,left: 0.003839909624356097d),

new NpgsqlTypes.NpgsqlBox(top: 0.9556002977378407d,right: 0.9839950778606789d,bottom: 0.06497964287593594d,left: 0.10028130509038746d),

new NpgsqlTypes.NpgsqlBox(top: 0.674469515913055d,right: 0.8147853886495111d,bottom: 0.10139559878943416d,left: 0.7281589047444912d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.12622261962397752d,right: 0.5937398336860806d,bottom: 0.05932076900846328d,left: 0.04158050862166751d),

new NpgsqlTypes.NpgsqlBox(top: 0.5786729852150029d,right: 0.6012600405095828d,bottom: 0.12068173876754396d,left: 0.2256872040156378d),

new NpgsqlTypes.NpgsqlBox(top: 0.6792365913893647d,right: 0.17064422914676713d,bottom: 0.08982794384555481d,left: 0.15604211806365276d),

new NpgsqlTypes.NpgsqlBox(top: 0.4843806559246725d,right: 0.7321866625570975d,bottom: 0.05220151663767514d,left: 0.6956781227070516d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8129693177909213d,right: 0.22973101014497144d,bottom: 0.6701778692839679d,left: 0.11542155753608951d),

new NpgsqlTypes.NpgsqlBox(top: 0.8883855708207665d,right: 0.4168441643666747d,bottom: 0.6819593102289015d,left: 0.27029581415889303d),

new NpgsqlTypes.NpgsqlBox(top: 0.7887088320350147d,right: 0.7108406739242631d,bottom: 0.40459000889057106d,left: 0.5925969023887788d),

new NpgsqlTypes.NpgsqlBox(top: 0.5675215416161585d,right: 0.49425468615023227d,bottom: 0.22402255328093934d,left: 0.10111534291501367d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7727616730429968d,right: 0.8957695267293653d,bottom: 0.041274578749267654d,left: 0.18536285555327614d),

new NpgsqlTypes.NpgsqlBox(top: 0.3703103366380005d,right: 0.7381629521155846d,bottom: 0.24841816388639804d,left: 0.042261115735855226d),

new NpgsqlTypes.NpgsqlBox(top: 0.5875467644941462d,right: 0.7708533433107192d,bottom: 0.10167521047968875d,left: 0.7670308856963157d),

new NpgsqlTypes.NpgsqlBox(top: 0.674798572439593d,right: 0.6658308372945454d,bottom: 0.5343594997876135d,left: 0.49583926140616885d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9498412450064676d,right: 0.4135174128704143d,bottom: 0.8757900947938403d,left: 0.14601775952696283d),

new NpgsqlTypes.NpgsqlBox(top: 0.37501777996596586d,right: 0.8569853665391919d,bottom: 4.68751389374189E-05d,left: 0.14681018722820327d),

new NpgsqlTypes.NpgsqlBox(top: 0.8868563936468121d,right: 0.7654625716150335d,bottom: 0.24864420438097956d,left: 0.393068841629576d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6942217769402079d,right: 0.875086591051885d,bottom: 0.5070958931214942d,left: 0.4081724004915074d),

new NpgsqlTypes.NpgsqlBox(top: 0.8585197580145861d,right: 0.4542508776533146d,bottom: 0.0938485962636888d,left: 0.1227380830201582d),

new NpgsqlTypes.NpgsqlBox(top: 0.5971945940835589d,right: 0.8159497628173167d,bottom: 0.29752016432710204d,left: 0.38615607316973777d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9875716135008448d,right: 0.7058390332218935d,bottom: 0.459270959543834d,left: 0.47263291668291385d),

new NpgsqlTypes.NpgsqlBox(top: 0.5357092001392497d,right: 0.4478620987358146d,bottom: 0.1720734129899386d,left: 0.32755889654679804d),

new NpgsqlTypes.NpgsqlBox(top: 0.6057634944260443d,right: 0.5155658972775367d,bottom: 0.3071472294730966d,left: 0.259890571895787d),

new NpgsqlTypes.NpgsqlBox(top: 0.7231784012311646d,right: 0.23719413425697977d,bottom: 0.08668952007010533d,left: 0.16698726334144498d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.884235932650959d,right: 0.18116841595123134d,bottom: 0.8181703255395584d,left: 0.002813792626451206d),

new NpgsqlTypes.NpgsqlBox(top: 0.7916077955415184d,right: 0.7562671741118383d,bottom: 0.25317710883930766d,left: 0.696828987431015d),

new NpgsqlTypes.NpgsqlBox(top: 0.9655439768515407d,right: 0.7013446319795494d,bottom: 0.01059584060874641d,left: 0.2217113179681739d),

new NpgsqlTypes.NpgsqlBox(top: 0.8047276885550196d,right: 0.7618784535890651d,bottom: 0.4640445835834872d,left: 0.5827461208158873d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8199834612081173d,right: 0.5081140198816148d,bottom: 0.5229051917939838d,left: 0.11119516998364731d),

new NpgsqlTypes.NpgsqlBox(top: 0.7401516620907678d,right: 0.6340776714318814d,bottom: 0.5234573162819318d,left: 0.02992655457200233d),

new NpgsqlTypes.NpgsqlBox(top: 0.9312047363866118d,right: 0.5711881666729705d,bottom: 0.29493997159736274d,left: 0.16086380593652838d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.409420548937211d,right: 0.8009941875892184d,bottom: 0.3647042636735741d,left: 0.09849136707713702d),

new NpgsqlTypes.NpgsqlBox(top: 0.5773962767712164d,right: 0.7624594048807999d,bottom: 0.06861498586691006d,left: 0.05691544928085468d),

new NpgsqlTypes.NpgsqlBox(top: 0.7492703842562164d,right: 0.8254365355757952d,bottom: 0.6407252411429916d,left: 0.22527924957765122d),

new NpgsqlTypes.NpgsqlBox(top: 0.9938435388598341d,right: 0.9374797597280289d,bottom: 0.780078394734168d,left: 0.21281330607475824d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8067037654835971d,right: 0.7108941838440008d,bottom: 0.17273876829550516d,left: 0.39732491464283404d),

new NpgsqlTypes.NpgsqlBox(top: 0.9288857537137408d,right: 0.5789442898401227d,bottom: 0.8569034853816918d,left: 0.2973729855335918d),

new NpgsqlTypes.NpgsqlBox(top: 0.8744436531141153d,right: 0.831273788106187d,bottom: 0.34172748543756626d,left: 0.05386773283701152d),

new NpgsqlTypes.NpgsqlBox(top: 0.35522668387195644d,right: 0.2830897895287693d,bottom: 0.09262736609690392d,left: 0.10143320178548776d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9713998359033015d,right: 0.9068406040725183d,bottom: 0.6316119808568871d,left: 0.36975196623468676d),

new NpgsqlTypes.NpgsqlBox(top: 0.5682315292987483d,right: 0.6220129319963266d,bottom: 0.462215267964311d,left: 0.6202143669597867d),

new NpgsqlTypes.NpgsqlBox(top: 0.8562605948985793d,right: 0.44880000838263634d,bottom: 0.4126097861179753d,left: 0.41631573719679416d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8896089895141774d,right: 0.9680203606126823d,bottom: 0.276627305482276d,left: 0.6837834786544609d),

new NpgsqlTypes.NpgsqlBox(top: 0.7775899568848702d,right: 0.5295881215527214d,bottom: 0.6707717599016676d,left: 0.4366059824895432d),

new NpgsqlTypes.NpgsqlBox(top: 0.8010666564677938d,right: 0.30774489224829815d,bottom: 0.3749086940033244d,left: 0.19779941527550993d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9744612224398945d,right: 0.2609492614663921d,bottom: 0.03770309042585107d,left: 0.09014264549147488d),

new NpgsqlTypes.NpgsqlBox(top: 0.991138493752079d,right: 0.5246075190628411d,bottom: 0.44652963295034276d,left: 0.008070707716107739d),

new NpgsqlTypes.NpgsqlBox(top: 0.6112388124340763d,right: 0.9332419511698087d,bottom: 0.05372622342720579d,left: 0.9064360414643312d),

new NpgsqlTypes.NpgsqlBox(top: 0.8760293834271395d,right: 0.6897381548763358d,bottom: 0.06917076226946428d,left: 0.35020439761438604d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8169504952878623d,right: 0.9112566046843026d,bottom: 0.15063396144684693d,left: 0.7226164492153525d),

new NpgsqlTypes.NpgsqlBox(top: 0.4803375945904892d,right: 0.5862776810161319d,bottom: 0.35021129248598204d,left: 0.4553871113688749d),

new NpgsqlTypes.NpgsqlBox(top: 0.5317228097997325d,right: 0.6512984993533394d,bottom: 0.47471437005540473d,left: 0.038672112150607396d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3817457268655786d,right: 0.7234386053769879d,bottom: 0.3175130114483886d,left: 0.17424152602775533d),

new NpgsqlTypes.NpgsqlBox(top: 0.9798845992079023d,right: 0.8392214807486371d,bottom: 0.4274782454105265d,left: 0.7759470845863333d),

new NpgsqlTypes.NpgsqlBox(top: 0.07885654840016287d,right: 0.9623775274129474d,bottom: 0.044636522484581276d,left: 0.3154509653698433d),

new NpgsqlTypes.NpgsqlBox(top: 0.9110184579061538d,right: 0.5868943461692033d,bottom: 0.3996551218309301d,left: 0.23430507272165202d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5248859395526387d,right: 0.9936776748936261d,bottom: 0.4550833036862879d,left: 0.11546752989148767d),

new NpgsqlTypes.NpgsqlBox(top: 0.772358773203997d,right: 0.24244883813044138d,bottom: 0.7406618457970371d,left: 0.13250889397308863d),

new NpgsqlTypes.NpgsqlBox(top: 0.5520267198220083d,right: 0.38416469483488125d,bottom: 0.009138013528191324d,left: 0.049915793617402615d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8578021566853018d,right: 0.616022243543196d,bottom: 0.588264852543721d,left: 0.3663490870095554d),

new NpgsqlTypes.NpgsqlBox(top: 0.8620565780211442d,right: 0.7326071660845872d,bottom: 0.32610692633432914d,left: 0.6234978847106226d),

new NpgsqlTypes.NpgsqlBox(top: 0.6394370565618286d,right: 0.5755692847147769d,bottom: 0.515021604820181d,left: 0.16724974228159772d),

new NpgsqlTypes.NpgsqlBox(top: 0.7994759640307352d,right: 0.5694204653812011d,bottom: 0.3945936144905704d,left: 0.08919784405682474d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9648775787842159d,right: 0.7057141759110259d,bottom: 0.8017091900082328d,left: 0.16417115628016277d),

new NpgsqlTypes.NpgsqlBox(top: 0.7497213684029724d,right: 0.9911838429323959d,bottom: 0.47298167293741333d,left: 0.11481244593466644d),

new NpgsqlTypes.NpgsqlBox(top: 0.12743669421656534d,right: 0.6765718915439886d,bottom: 0.11003467380980536d,left: 0.3927634772783408d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6332907882075741d,right: 0.9842288493366574d,bottom: 0.6084551262798421d,left: 0.9606307962945388d),

new NpgsqlTypes.NpgsqlBox(top: 0.7614783390867589d,right: 0.7631121925833367d,bottom: 0.4597663714697563d,left: 0.18509408539225958d),

new NpgsqlTypes.NpgsqlBox(top: 0.6680344775729967d,right: 0.4245977441876845d,bottom: 0.15289959465160685d,left: 0.4019788088846151d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5447522790465947d,right: 0.6903724912496324d,bottom: 0.0002896050617354762d,left: 0.33503120885877524d),

new NpgsqlTypes.NpgsqlBox(top: 0.24810836697141614d,right: 0.8549280646770938d,bottom: 0.10000848756854863d,left: 0.6828986210316748d),

new NpgsqlTypes.NpgsqlBox(top: 0.3338484517685859d,right: 0.74067014373256d,bottom: 0.05290676744411549d,left: 0.0433866041947808d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1623427196035403d,right: 0.611624692731533d,bottom: 0.1447962254035151d,left: 0.011278738784335496d),

new NpgsqlTypes.NpgsqlBox(top: 0.860577917209622d,right: 0.4426482573162289d,bottom: 0.07866739232657594d,left: 0.2876139336528917d),

new NpgsqlTypes.NpgsqlBox(top: 0.27528197926501297d,right: 0.3293263068371798d,bottom: 0.21448298182656633d,left: 0.019313697041744238d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3839721394264718d,right: 0.6874041829460973d,bottom: 0.15658890512573853d,left: 0.19996641921870517d),

new NpgsqlTypes.NpgsqlBox(top: 0.6297410575846629d,right: 0.698923933039299d,bottom: 0.4649920880291323d,left: 0.32556188574914147d),

new NpgsqlTypes.NpgsqlBox(top: 0.7699732527477351d,right: 0.3600890709538067d,bottom: 0.1429012693792464d,left: 0.06977203343820515d),

new NpgsqlTypes.NpgsqlBox(top: 0.572459175909168d,right: 0.5612730587485935d,bottom: 0.1985543622295467d,left: 0.04408493580023243d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4065470433443934d,right: 0.8330454527627823d,bottom: 0.30602951800895983d,left: 0.3592651215562014d),

new NpgsqlTypes.NpgsqlBox(top: 0.2604957546732023d,right: 0.9923536475138647d,bottom: 0.2369383859990084d,left: 0.8389744945292639d),

new NpgsqlTypes.NpgsqlBox(top: 0.6185265701367213d,right: 0.7638412709613687d,bottom: 0.29992243876021596d,left: 0.7625377781423665d),

new NpgsqlTypes.NpgsqlBox(top: 0.8928125809133364d,right: 0.9693345013079779d,bottom: 0.8456760522301612d,left: 0.630895017023964d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8006673335087421d,right: 0.9906988380726532d,bottom: 0.5458735811191067d,left: 0.9009058246195932d),

new NpgsqlTypes.NpgsqlBox(top: 0.14147399777826575d,right: 0.4573888783039062d,bottom: 0.11114410626469673d,left: 0.20779276370189814d),

new NpgsqlTypes.NpgsqlBox(top: 0.5425252881266682d,right: 0.5509644777575422d,bottom: 0.13294255147583878d,left: 0.5229072217233245d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9392283379353814d,right: 0.9302238051829635d,bottom: 0.3338968613419201d,left: 0.2413195343569331d),

new NpgsqlTypes.NpgsqlBox(top: 0.9498307709398492d,right: 0.917416553224283d,bottom: 0.4670257818289063d,left: 0.26454469514565093d),

new NpgsqlTypes.NpgsqlBox(top: 0.466442491763683d,right: 0.8798210002004769d,bottom: 0.3106725098441674d,left: 0.039478633504127836d),

new NpgsqlTypes.NpgsqlBox(top: 0.9051297588577608d,right: 0.8604664631771656d,bottom: 0.8160124365293165d,left: 0.5701519319970132d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9584992390853111d,right: 0.7725678868165878d,bottom: 0.16777608008927325d,left: 0.7462861141194944d),

new NpgsqlTypes.NpgsqlBox(top: 0.34916513743014954d,right: 0.892918438043199d,bottom: 0.0010256336817351386d,left: 0.47300023070420283d),

new NpgsqlTypes.NpgsqlBox(top: 0.17549087993314205d,right: 0.8424933599623436d,bottom: 0.026860335331880925d,left: 0.4346367734660961d),

new NpgsqlTypes.NpgsqlBox(top: 0.6364076064740605d,right: 0.7145075519515286d,bottom: 0.2839694241522457d,left: 0.32929528830827937d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.94659802816593d,right: 0.8597105864030286d,bottom: 0.8546011108373681d,left: 0.8458785481477265d),

new NpgsqlTypes.NpgsqlBox(top: 0.7817990070503473d,right: 0.8182060362640731d,bottom: 0.7755954603795281d,left: 0.07018849123241977d),

new NpgsqlTypes.NpgsqlBox(top: 0.7045418297523666d,right: 0.5296104045778232d,bottom: 0.4985533647968574d,left: 0.038445453217328396d),

new NpgsqlTypes.NpgsqlBox(top: 0.9847013309825982d,right: 0.807311786343545d,bottom: 0.5645854462017298d,left: 0.13623188954291765d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6145922433890778d,right: 0.5316598456479324d,bottom: 0.4872718439049577d,left: 0.10755043734245595d),

new NpgsqlTypes.NpgsqlBox(top: 0.49465878041574585d,right: 0.975951348971311d,bottom: 0.054471651271355004d,left: 0.5589567146865582d),

new NpgsqlTypes.NpgsqlBox(top: 0.8142421774327955d,right: 0.2916455994918301d,bottom: 0.18048347997816083d,left: 0.1439789475226253d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.600142597439063d,right: 0.3653641516676538d,bottom: 0.4934223025374792d,left: 0.12273580746283419d),

new NpgsqlTypes.NpgsqlBox(top: 0.7962419238825894d,right: 0.9181156128882425d,bottom: 0.5882142759120238d,left: 0.44476885852786574d),

new NpgsqlTypes.NpgsqlBox(top: 0.8765255792400686d,right: 0.3512391885556755d,bottom: 0.5647740294851284d,left: 0.12115356620935003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9767468905651111d,right: 0.9594245243114686d,bottom: 0.7860880220498775d,left: 0.8096026774993301d),

new NpgsqlTypes.NpgsqlBox(top: 0.8589623868140718d,right: 0.5317658565092995d,bottom: 0.21941762625447192d,left: 0.34899258993505833d),

new NpgsqlTypes.NpgsqlBox(top: 0.5662507923838914d,right: 0.9777999148112085d,bottom: 0.2550421524204808d,left: 0.20661770439861593d),

new NpgsqlTypes.NpgsqlBox(top: 0.9479741689964056d,right: 0.9913676654963096d,bottom: 0.6858829289070448d,left: 0.2053364534313039d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7475674066831846d,right: 0.411435546675037d,bottom: 0.6935082998906092d,left: 0.07710799077964581d),

new NpgsqlTypes.NpgsqlBox(top: 0.5597875131178177d,right: 0.48653355300488077d,bottom: 0.34084579330666187d,left: 0.013554633387839798d),

new NpgsqlTypes.NpgsqlBox(top: 0.9841412821757197d,right: 0.79560134914472d,bottom: 0.5657745421552018d,left: 0.14689864161556077d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.98188653935186d,right: 0.5540692152070624d,bottom: 0.009318480473640811d,left: 0.4438416229126565d),

new NpgsqlTypes.NpgsqlBox(top: 0.7747846189342268d,right: 0.42355408886587365d,bottom: 0.2317031072119613d,left: 0.24747711056728172d),

new NpgsqlTypes.NpgsqlBox(top: 0.681312464406813d,right: 0.8112972990426511d,bottom: 0.5163488607096547d,left: 0.19157002227775877d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3401058509576168d,right: 0.3183508405119131d,bottom: 0.032797975336737895d,left: 0.056734340918281445d),

new NpgsqlTypes.NpgsqlBox(top: 0.6332547274941858d,right: 0.8155016117620242d,bottom: 0.273992396937875d,left: 0.3474557637457705d),

new NpgsqlTypes.NpgsqlBox(top: 0.898590819060639d,right: 0.2675551720945015d,bottom: 0.8026002116555164d,left: 0.024260290847610833d),

new NpgsqlTypes.NpgsqlBox(top: 0.5247722124376051d,right: 0.7537437835752595d,bottom: 0.24648494554160172d,left: 0.5168531287889527d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9111143651377394d,right: 0.07219087012941305d,bottom: 0.5985777921859198d,left: 0.0001120744156303255d),

new NpgsqlTypes.NpgsqlBox(top: 0.7698446891542855d,right: 0.6253568960568895d,bottom: 0.592710178127157d,left: 0.1663556327784661d),

new NpgsqlTypes.NpgsqlBox(top: 0.7921087536606004d,right: 0.5025448539933884d,bottom: 0.7340536161142198d,left: 0.1105214711671415d),

new NpgsqlTypes.NpgsqlBox(top: 0.49949424777083096d,right: 0.7016837183555821d,bottom: 0.31774263863624175d,left: 0.04016847086600028d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7379698863131292d,right: 0.832078864929754d,bottom: 0.4335219622320643d,left: 0.8179616358549334d),

new NpgsqlTypes.NpgsqlBox(top: 0.7203631789722739d,right: 0.8457295832252155d,bottom: 0.030998889854304545d,left: 0.3935369461256937d),

new NpgsqlTypes.NpgsqlBox(top: 0.4878995235245751d,right: 0.6005899029687272d,bottom: 0.37848587587585036d,left: 0.5795696223099461d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7152405545205328d,right: 0.2711609628096271d,bottom: 0.5229886925443883d,left: 0.15548020092914483d),

new NpgsqlTypes.NpgsqlBox(top: 0.6825822941777705d,right: 0.9974805981114733d,bottom: 0.6702871058106467d,left: 0.2731485736046255d),

new NpgsqlTypes.NpgsqlBox(top: 0.8640460461839349d,right: 0.3031816458209725d,bottom: 0.7011264172160355d,left: 0.1618531390825627d),

new NpgsqlTypes.NpgsqlBox(top: 0.3407472401129841d,right: 0.2786537731158645d,bottom: 0.16587366893031041d,left: 0.040664561279217804d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7810746624335094d,right: 0.838160171724392d,bottom: 0.5392535118886054d,left: 0.1344435595738377d),

new NpgsqlTypes.NpgsqlBox(top: 0.3633341683229441d,right: 0.22818428089846088d,bottom: 0.1361809572434406d,left: 0.2107016331413183d),

new NpgsqlTypes.NpgsqlBox(top: 0.5704512877398797d,right: 0.3793693430999162d,bottom: 0.07088359484461781d,left: 0.28056859608334117d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8037669886294102d,right: 0.3608909023445115d,bottom: 0.7598584797071626d,left: 0.07988257834031876d),

new NpgsqlTypes.NpgsqlBox(top: 0.846877466563286d,right: 0.7767544826457127d,bottom: 0.1953765378807797d,left: 0.15323124667197496d),

new NpgsqlTypes.NpgsqlBox(top: 0.7406620811397742d,right: 0.8136476399233605d,bottom: 0.5359445715388796d,left: 0.09967637891519898d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9050572182588371d,right: 0.38962857297910525d,bottom: 0.37809866363730615d,left: 0.06221401960252626d),

new NpgsqlTypes.NpgsqlBox(top: 0.7784602907124307d,right: 0.6427686615331173d,bottom: 0.3467360107408958d,left: 0.40749142430899776d),

new NpgsqlTypes.NpgsqlBox(top: 0.9125255473386937d,right: 0.8116296455269869d,bottom: 0.31099255379317914d,left: 0.7917927532100524d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9798237875260828d,right: 0.7698358705313486d,bottom: 0.5198057355717072d,left: 0.0008368139309340439d),

new NpgsqlTypes.NpgsqlBox(top: 0.5245234392245185d,right: 0.6330514764870041d,bottom: 0.20551124587462855d,left: 0.41962519292857603d),

new NpgsqlTypes.NpgsqlBox(top: 0.7680836637547871d,right: 0.9906757637277943d,bottom: 0.5672300162565683d,left: 0.7694117739146559d),

new NpgsqlTypes.NpgsqlBox(top: 0.7804009825891853d,right: 0.46831418492431376d,bottom: 0.2190361813221211d,left: 0.11285979263493784d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5007659321351745d,right: 0.25332341193683894d,bottom: 0.18359235466260249d,left: 0.08831553835829886d),

new NpgsqlTypes.NpgsqlBox(top: 0.9037584059129843d,right: 0.7169182805092954d,bottom: 0.20331127874667188d,left: 0.08021293695752552d),

new NpgsqlTypes.NpgsqlBox(top: 0.30760697882490784d,right: 0.8245174323489122d,bottom: 0.12180643682187575d,left: 0.25579731338663425d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8524735882604796d,right: 0.7356783636995712d,bottom: 0.09003036349865812d,left: 0.5697550435183938d),

new NpgsqlTypes.NpgsqlBox(top: 0.9666871142561854d,right: 0.7000177254039864d,bottom: 0.2395483444202261d,left: 0.3754787422535971d),

new NpgsqlTypes.NpgsqlBox(top: 0.459381811845853d,right: 0.9299652368831205d,bottom: 0.30701848493117256d,left: 0.47147662451270056d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6796356541984291d,right: 0.6516701558510434d,bottom: 0.24548871537226913d,left: 0.3748840123545828d),

new NpgsqlTypes.NpgsqlBox(top: 0.7453269412255723d,right: 0.8423221991118625d,bottom: 0.16928682103405046d,left: 0.7583451081245175d),

new NpgsqlTypes.NpgsqlBox(top: 0.5651366982595744d,right: 0.7540601027433592d,bottom: 0.4421659652082992d,left: 0.5829368607619339d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7642441748821396d,right: 0.9026441216409739d,bottom: 0.7403005403402453d,left: 0.3613415046009948d),

new NpgsqlTypes.NpgsqlBox(top: 0.6721578081639981d,right: 0.7691725314447383d,bottom: 0.6641642737172916d,left: 0.763114752370989d),

new NpgsqlTypes.NpgsqlBox(top: 0.49892405101089354d,right: 0.6250443332252829d,bottom: 0.4574708055031761d,left: 0.25856918154363306d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7187530575627836d,right: 0.450197467542117d,bottom: 0.3350182561906858d,left: 0.39525309944194875d),

new NpgsqlTypes.NpgsqlBox(top: 0.49630345207091187d,right: 0.9280447671991076d,bottom: 0.3516969336480854d,left: 0.4373994677830343d),

new NpgsqlTypes.NpgsqlBox(top: 0.5803844312185945d,right: 0.6417991682516303d,bottom: 0.49272575258367024d,left: 0.025906142719004488d),

new NpgsqlTypes.NpgsqlBox(top: 0.8075060536908575d,right: 0.9261177033979239d,bottom: 0.32459613405789d,left: 0.09248447031536333d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.586338943185567d,right: 0.7639445987389427d,bottom: 0.09790468005116137d,left: 0.20988715621530507d),

new NpgsqlTypes.NpgsqlBox(top: 0.7712046052183484d,right: 0.24632383172056227d,bottom: 0.5980605567706454d,left: 0.0002897571803962551d),

new NpgsqlTypes.NpgsqlBox(top: 0.6456535639154213d,right: 0.8717713977580275d,bottom: 0.22060951956701358d,left: 0.21847047075764114d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.628161643001571d,right: 0.9659624518758817d,bottom: 0.402994630732168d,left: 0.7951602979279573d),

new NpgsqlTypes.NpgsqlBox(top: 0.6123232788359811d,right: 0.7585824580256152d,bottom: 0.06721650117308997d,left: 0.6492396709517915d),

new NpgsqlTypes.NpgsqlBox(top: 0.2910222783514532d,right: 0.4576556462800234d,bottom: 0.2140633204905058d,left: 0.34236624019545747d),

new NpgsqlTypes.NpgsqlBox(top: 0.6470027631105926d,right: 0.6577524388619878d,bottom: 0.05411396066960439d,left: 0.3561438081076034d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9523884965367564d,right: 0.9200887947102463d,bottom: 0.02102657048354384d,left: 0.6722903518148611d),

new NpgsqlTypes.NpgsqlBox(top: 0.19848307119857178d,right: 0.7697269479939507d,bottom: 0.044245454663015216d,left: 0.6066839562836664d),

new NpgsqlTypes.NpgsqlBox(top: 0.59571413242743d,right: 0.8881475692016195d,bottom: 0.3640355927144381d,left: 0.2190947780044633d),

new NpgsqlTypes.NpgsqlBox(top: 0.4910956231479936d,right: 0.9960154101937385d,bottom: 0.4380400673819159d,left: 0.04578831426138885d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23809763335921819d,right: 0.7394545474949995d,bottom: 0.024591382319934296d,left: 0.10965203338099094d),

new NpgsqlTypes.NpgsqlBox(top: 0.2420211801414731d,right: 0.9556139902764499d,bottom: 0.19711711959932687d,left: 0.8393224549777192d),

new NpgsqlTypes.NpgsqlBox(top: 0.8042950038820361d,right: 0.8860448040405265d,bottom: 0.2674825904710467d,left: 0.7974977907228223d),

new NpgsqlTypes.NpgsqlBox(top: 0.15300723340000166d,right: 0.5241603467603477d,bottom: 0.04011581482699944d,left: 0.4263233031906243d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9103859248950352d,right: 0.8015802492286783d,bottom: 0.7040057570239416d,left: 0.17251395734546848d),

new NpgsqlTypes.NpgsqlBox(top: 0.8541870247849057d,right: 0.5831577149149798d,bottom: 0.08827507489488418d,left: 0.5493112447096293d),

new NpgsqlTypes.NpgsqlBox(top: 0.572630554312266d,right: 0.8484632486229405d,bottom: 0.4215557658459963d,left: 0.5143603704920705d),

new NpgsqlTypes.NpgsqlBox(top: 0.457508768117161d,right: 0.9716278475200072d,bottom: 0.39267925605413856d,left: 0.800931076612347d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8030106946441187d,right: 0.98704048211996d,bottom: 0.42521498421203463d,left: 0.7634965398180721d),

new NpgsqlTypes.NpgsqlBox(top: 0.8490490634780136d,right: 0.6406095725805043d,bottom: 0.2006756144743237d,left: 0.238652166312615d),

new NpgsqlTypes.NpgsqlBox(top: 0.7740333096210816d,right: 0.6524204057218886d,bottom: 0.08057632832094319d,left: 0.3751972553699725d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6240762816588158d,right: 0.7815624933912726d,bottom: 0.0011377836210232362d,left: 0.5344360186783794d),

new NpgsqlTypes.NpgsqlBox(top: 0.6037528894305689d,right: 0.45417547641785605d,bottom: 0.1388843438171974d,left: 0.28427060287023853d),

new NpgsqlTypes.NpgsqlBox(top: 0.7290136565303313d,right: 0.9536759569497331d,bottom: 0.7247224373177414d,left: 0.21702277936613568d),

new NpgsqlTypes.NpgsqlBox(top: 0.7769673979036479d,right: 0.2720378953965261d,bottom: 0.12224898712496168d,left: 0.26994051270664665d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9393011013780821d,right: 0.21585989555142993d,bottom: 0.397839665002768d,left: 0.10561412617547428d),

new NpgsqlTypes.NpgsqlBox(top: 0.9940178395459298d,right: 0.2850772735852257d,bottom: 0.20381958908608855d,left: 0.22982356511327184d),

new NpgsqlTypes.NpgsqlBox(top: 0.7288907122626646d,right: 0.8365530638262123d,bottom: 0.48083192856100543d,left: 0.40401645226307403d),

new NpgsqlTypes.NpgsqlBox(top: 0.9370335806123228d,right: 0.026324030034431845d,bottom: 0.7313695890459353d,left: 0.0021236923006674457d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4611874509623983d,right: 0.4747051192567918d,bottom: 0.3304872137776117d,left: 0.1590738049220296d),

new NpgsqlTypes.NpgsqlBox(top: 0.4240918342994584d,right: 0.43543062781235764d,bottom: 0.41047481978348455d,left: 0.12051182259770099d),

new NpgsqlTypes.NpgsqlBox(top: 0.9431733990158244d,right: 0.8066144787475276d,bottom: 0.14756782023228543d,left: 0.4075487956744557d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7926240181609069d,right: 0.7576832228877391d,bottom: 0.42696983365584507d,left: 0.3760637046198758d),

new NpgsqlTypes.NpgsqlBox(top: 0.6725847650753093d,right: 0.5989597279496253d,bottom: 0.08275488346651028d,left: 0.5821692862631086d),

new NpgsqlTypes.NpgsqlBox(top: 0.7020380245970106d,right: 0.6458903519291971d,bottom: 0.21439716615943083d,left: 0.4657068286064383d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7782569900142067d,right: 0.839514821884336d,bottom: 0.021052455805181225d,left: 0.2040820015873498d),

new NpgsqlTypes.NpgsqlBox(top: 0.9158485507282775d,right: 0.7172267486573892d,bottom: 0.8091924615676186d,left: 0.07714682749006774d),

new NpgsqlTypes.NpgsqlBox(top: 0.6494559968426173d,right: 0.8547254639467383d,bottom: 0.27984643737391335d,left: 0.4006143509165039d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6462296601736575d,right: 0.893549602830682d,bottom: 0.314781503081876d,left: 0.27966132861573834d),

new NpgsqlTypes.NpgsqlBox(top: 0.6074469904552064d,right: 0.4199736511005834d,bottom: 0.2614396901727003d,left: 0.41612058600321866d),

new NpgsqlTypes.NpgsqlBox(top: 0.22363316773147324d,right: 0.52624848043176d,bottom: 0.031547883062040705d,left: 0.17979570921640808d),

new NpgsqlTypes.NpgsqlBox(top: 0.7767275852865078d,right: 0.8399760383943851d,bottom: 0.46071909899567465d,left: 0.5236946657253151d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3309500898118226d,right: 0.4776912614678136d,bottom: 0.24802533377057467d,left: 0.32754677731888426d),

new NpgsqlTypes.NpgsqlBox(top: 0.5793377961920116d,right: 0.7331948890913109d,bottom: 0.5727104187235175d,left: 0.0037400997502911038d),

new NpgsqlTypes.NpgsqlBox(top: 0.44097374661809885d,right: 0.9549983503218293d,bottom: 0.30731427158343383d,left: 0.6363187602248792d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7271733040949999d,right: 0.7672082415585563d,bottom: 0.3981262852364461d,left: 0.08700098282175694d),

new NpgsqlTypes.NpgsqlBox(top: 0.9237135558119134d,right: 0.8645189636422556d,bottom: 0.04436912365000434d,left: 0.7722479772642094d),

new NpgsqlTypes.NpgsqlBox(top: 0.534017289827625d,right: 0.5557187207523006d,bottom: 0.1689861970415184d,left: 0.334637608860086d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7816932721940669d,right: 0.612884758888368d,bottom: 0.3127077355362323d,left: 0.27230746774846204d),

new NpgsqlTypes.NpgsqlBox(top: 0.5853730937711777d,right: 0.9424871272746373d,bottom: 0.14468618422449686d,left: 0.06568330233514752d),

new NpgsqlTypes.NpgsqlBox(top: 0.6955864623570936d,right: 0.365798527799299d,bottom: 0.6904147819465976d,left: 0.28969831271224533d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.902595464942517d,right: 0.8923548099162291d,bottom: 0.7228590650183127d,left: 0.12973746486771665d),

new NpgsqlTypes.NpgsqlBox(top: 0.7398872234701216d,right: 0.4372281428529954d,bottom: 0.03649010869449032d,left: 0.37099847752419257d),

new NpgsqlTypes.NpgsqlBox(top: 0.8421156244873806d,right: 0.9391273070480886d,bottom: 0.4176781452387741d,left: 0.45128244041990884d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8889272510843624d,right: 0.6584043032813622d,bottom: 0.3325300021268891d,left: 0.23083256762043536d),

new NpgsqlTypes.NpgsqlBox(top: 0.40386776358716225d,right: 0.39803439899699233d,bottom: 0.13248622703010005d,left: 0.36752824400259765d),

new NpgsqlTypes.NpgsqlBox(top: 0.8253821643270025d,right: 0.9312828126731484d,bottom: 0.07110141746000176d,left: 0.3291546901925606d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3869173618884736d,right: 0.2512820921694685d,bottom: 0.03162350137444403d,left: 0.003993118167801235d),

new NpgsqlTypes.NpgsqlBox(top: 0.2452172352394153d,right: 0.950087161075174d,bottom: 0.2308594229936245d,left: 0.06117104485228331d),

new NpgsqlTypes.NpgsqlBox(top: 0.9778810133616422d,right: 0.9220676033147487d,bottom: 0.642182960727973d,left: 0.36728885972632597d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 197,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5975537981942547d,right: 0.4635317644067334d,bottom: 0.26945712000768074d,left: 0.05795050845212624d),

new NpgsqlTypes.NpgsqlBox(top: 0.9779470598746557d,right: 0.6073145052096998d,bottom: 0.4649845562018343d,left: 0.550939830806171d),

new NpgsqlTypes.NpgsqlBox(top: 0.40713416099334554d,right: 0.22309744316462066d,bottom: 0.06955847561439343d,left: 0.07203330123041696d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6349335902435894d,right: 0.6323878407670256d,bottom: 0.3613804957949682d,left: 0.46093776556005284d),

new NpgsqlTypes.NpgsqlBox(top: 0.6455896516108655d,right: 0.1239064650779953d,bottom: 0.6410197814418263d,left: 0.09138049795571401d),

new NpgsqlTypes.NpgsqlBox(top: 0.9225621846469194d,right: 0.8041052823676065d,bottom: 0.7329598790694659d,left: 0.32934181021055076d),

new NpgsqlTypes.NpgsqlBox(top: 0.34981177176588885d,right: 0.7188191656155579d,bottom: 0.16961372268040342d,left: 0.6333504190095318d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 201,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.611210192527355d,right: 0.9717245213256043d,bottom: 0.33674477435759154d,left: 0.12508517665454977d),

new NpgsqlTypes.NpgsqlBox(top: 0.8918781445773827d,right: 0.5560063534183812d,bottom: 0.1788465399962188d,left: 0.017031430265237235d),

new NpgsqlTypes.NpgsqlBox(top: 0.7310654662992386d,right: 0.38119256839001303d,bottom: 0.6740390447558399d,left: 0.2523567377527469d),

new NpgsqlTypes.NpgsqlBox(top: 0.3144099057158789d,right: 0.35198218980711593d,bottom: 0.25598619748537343d,left: 0.29744397562160574d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7991984685128015d,right: 0.6162907645334984d,bottom: 0.38367297341331363d,left: 0.07218941857900907d),

new NpgsqlTypes.NpgsqlBox(top: 0.3307155334911315d,right: 0.9859199922931675d,bottom: 0.013081622460098252d,left: 0.0455929324552915d),

new NpgsqlTypes.NpgsqlBox(top: 0.5050683033475722d,right: 0.6257238036405782d,bottom: 0.4061492096665862d,left: 0.40039776063252064d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5302883492040522d,right: 0.9698211862620085d,bottom: 0.31196395100297636d,left: 0.009625941225377632d),

new NpgsqlTypes.NpgsqlBox(top: 0.18515593210529024d,right: 0.3454068037922219d,bottom: 0.0217746546755907d,left: 0.3281742978037496d),

new NpgsqlTypes.NpgsqlBox(top: 0.8481230281638806d,right: 0.5425444371181153d,bottom: 0.626762627680873d,left: 0.003046754501626947d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 202,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9749372568169096d,right: 0.5119037552243374d,bottom: 0.7502919754662639d,left: 0.12990887587091915d),

new NpgsqlTypes.NpgsqlBox(top: 0.4370697312281737d,right: 0.8132673926346848d,bottom: 0.28519511129432695d,left: 0.3874780621855207d),

new NpgsqlTypes.NpgsqlBox(top: 0.7931070909909276d,right: 0.7879827519267267d,bottom: 0.7786592472971131d,left: 0.11699854885323513d),

new NpgsqlTypes.NpgsqlBox(top: 0.3621846919441347d,right: 0.29495725641303905d,bottom: 0.14959001679196704d,left: 0.24369179206698044d),

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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr1.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 193;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 197;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 58, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 180, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[34], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
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

